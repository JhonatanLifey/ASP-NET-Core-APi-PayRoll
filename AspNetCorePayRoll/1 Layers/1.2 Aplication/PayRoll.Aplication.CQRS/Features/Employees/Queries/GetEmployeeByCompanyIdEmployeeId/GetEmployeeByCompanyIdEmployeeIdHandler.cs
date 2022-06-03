using AutoMapper;
using MediatR;
using PayRoll.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PayRoll.Aplication.CQRS.Features.Employees.Queries.GetEmployeeByCompanyIdEmployeeId
{
    public class GetEmployeeByCompanyIdEmployeeIdHandler : IRequestHandler<GetEmployeeByCompanyIdEmployeeIdQuery, EmployeeVm>
    {

        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public GetEmployeeByCompanyIdEmployeeIdHandler(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<EmployeeVm> Handle(GetEmployeeByCompanyIdEmployeeIdQuery request, CancellationToken cancellationToken)
        {
            var employeesList = await _employeeRepository.GetEmployeeByCompanyIdEmployeeId(request.CompanyID, request.EmployeeID);
            return _mapper.Map<EmployeeVm>(employeesList);
        }
    }
}
