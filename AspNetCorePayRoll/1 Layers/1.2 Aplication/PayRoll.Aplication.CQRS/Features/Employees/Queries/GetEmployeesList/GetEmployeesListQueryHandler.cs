using AutoMapper;
using MediatR;
using PayRoll.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PayRoll.Aplication.CQRS.Features.Employees.Queries.GetEmployeesList
{
    public class GetEmployeesListQueryHandler : IRequestHandler<GetEmployeesListQuery, List<EmployeesVm>>
    {

        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public GetEmployeesListQueryHandler(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<List<EmployeesVm>> Handle(GetEmployeesListQuery request, CancellationToken cancellationToken)
        {
            var employeesList = await _employeeRepository.GetEmployeeByCompanyIdEmployeeId(request.CompanyID, request.EmployeeID);
            return _mapper.Map<List<EmployeesVm>>(employeesList);
            
        }
    }
}
