using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Aplication.CQRS.Features.Employees.Queries.GetEmployeesList
{
    public class GetEmployeesListQuery: IRequest<List<EmployeesVm>>
    {
        public int CompanyID { get; set; }

        public int EmployeeID { get; set; }

        public GetEmployeesListQuery(int companyID, int employeeID)
        {
            CompanyID = companyID;
            EmployeeID = employeeID;
        }
    }
}
