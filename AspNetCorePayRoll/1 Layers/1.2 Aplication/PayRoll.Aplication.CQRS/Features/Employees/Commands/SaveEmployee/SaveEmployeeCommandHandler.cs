using AutoMapper;
using MediatR;
using PayRoll.Domain.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;
using PayRoll.CrossCutting.Common.Interfaces;
using Microsoft.Extensions.Logging;
using PayRoll.Domain.Entities;
using PayRoll.CrossCutting.Common.Models;

namespace PayRoll.Aplication.CQRS.Features.Employees.Commands.SaveEmployee
{
    public class SaveEmployeeCommandHandler : IRequestHandler<SaveEmployeeCommand, int>
    {

        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly ILogger<SaveEmployeeCommandHandler> _logger;

        public SaveEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMapper mapper, IEmailService emailService, ILogger<SaveEmployeeCommandHandler> logger)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
            _emailService = emailService;
            _logger = logger;
        }

        public async Task<int> Handle(SaveEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employeeEntity  = _mapper.Map<Employee>(request);
            var newEmployee     = await _employeeRepository.AddAsync(employeeEntity);
            _logger.LogInformation($"Employee {newEmployee.EmployeeId} is successfully created.");
            await SendMail(newEmployee);
            return newEmployee.EmployeeId;

        }

        private async Task SendMail(Employee employee)
        {
            var email = new Email() { To = "JhonatanLifey@hotmail.com", Body = $"Order was created.", Subject = "Employee was created" };

            try
            {
                await _emailService.SendEmail(email);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Employee {employee.EmployeeId} failed due to an error with the mail service: {ex.Message}");
            }
        }
    }
}
