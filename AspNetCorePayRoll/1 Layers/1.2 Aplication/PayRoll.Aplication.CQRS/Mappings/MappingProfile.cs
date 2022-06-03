using AutoMapper;
using PayRoll.Aplication.CQRS.Features.Employees.Commands.SaveEmployee;
using PayRoll.Aplication.CQRS.Features.Employees.Commands.UpdateEmployee;
using PayRoll.Aplication.CQRS.Features.Employees.Queries.GetEmployeeByCompanyIdEmployeeId;
using PayRoll.Aplication.CQRS.Features.Employees.Queries.GetEmployeesByCompany;
using PayRoll.Domain.Entities;

namespace PayRoll.Aplication.CQRS.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeesVm>().ReverseMap();
            CreateMap<Employee, SaveEmployeeCommand>().ReverseMap();
            CreateMap<Employee, UpdateEmployeeCommand>().ReverseMap();
            CreateMap<Employee, EmployeeVm>().ReverseMap();
        }
    }
}
