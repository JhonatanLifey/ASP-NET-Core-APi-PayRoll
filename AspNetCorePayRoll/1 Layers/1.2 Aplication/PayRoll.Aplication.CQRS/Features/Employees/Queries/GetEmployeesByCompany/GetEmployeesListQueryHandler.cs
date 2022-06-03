using AutoMapper;
using MediatR;
using PayRoll.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PayRoll.Aplication.CQRS.Features.Employees.Queries.GetEmployeesByCompany
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
            var employeesList = await _employeeRepository.GetEmployeesByCompany(request.CompanyID);
            return _mapper.Map<List<EmployeesVm>>(employeesList);
            
        }
    }
}
