using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using PayRoll.Aplication.CQRS.Exceptions;
using PayRoll.Domain.Entities;
using PayRoll.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PayRoll.Aplication.CQRS.Features.Employees.Commands.Update
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand>
    {

        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateEmployeeCommandHandler> _logger;

        public UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMapper mapper, ILogger<UpdateEmployeeCommandHandler> logger)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            //update employee

            var updateEmployee = await _employeeRepository.GetEmployeeByCompanyIdEmployeeId(request.CompanyId, request.EmployeeId);

            if (updateEmployee == null) {
                throw new NotFoundException(nameof(Employee), request.EmployeeId);
            }
            _mapper.Map(request, updateEmployee, typeof(UpdateEmployeeCommand), typeof(Employee));

            await _employeeRepository.UpdateAsync(updateEmployee);

            _logger.LogInformation($"Update {updateEmployee.EmployeeName} employee was successfully");

            return Unit.Value;
        }
    }
}
