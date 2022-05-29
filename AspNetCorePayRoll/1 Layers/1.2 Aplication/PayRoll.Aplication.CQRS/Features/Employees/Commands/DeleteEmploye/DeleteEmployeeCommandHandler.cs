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

namespace PayRoll.Aplication.CQRS.Features.Employees.Commands.DeleteEmploye
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<DeleteEmployeeCommandHandler> _logger;

        public DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMapper mapper, ILogger<DeleteEmployeeCommandHandler> logger)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {

            var DeleteEmployee = await _employeeRepository.GetEmployeeByCompanyIdEmployeeId(request.CompanyId, request.EmployeeId);
            if (DeleteEmployee == null) {
                throw new NotFoundException(nameof(Employee), request.EmployeeId);
            }

            await _employeeRepository.DeleteAsync(DeleteEmployee);
            _logger.LogInformation($"Employee {DeleteEmployee.EmployeeName} is successfully delete");

            return Unit.Value;

        }
    }
}
