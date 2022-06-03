using MediatR;
using PayRoll.Aplication.CQRS.Features.Employees.Queries.GetEmployeesByCompany;
using System.Collections.Generic;

namespace PayRoll.Aplication.CQRS.Features.Employees.Queries.GetEmployeesByCompany
{
    public class GetEmployeesListQuery: IRequest<List<EmployeesVm>>
    {
        public int CompanyID { get; set; }


        public GetEmployeesListQuery(int companyID)
        {
            CompanyID = companyID;
        }
    }
}
