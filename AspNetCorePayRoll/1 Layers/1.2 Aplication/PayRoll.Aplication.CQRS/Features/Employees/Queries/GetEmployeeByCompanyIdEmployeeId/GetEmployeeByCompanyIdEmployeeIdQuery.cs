using MediatR;
using System.Collections.Generic;

namespace PayRoll.Aplication.CQRS.Features.Employees.Queries.GetEmployeeByCompanyIdEmployeeId
{
    public class GetEmployeeByCompanyIdEmployeeIdQuery: IRequest<EmployeeVm>
    {
        
            public int CompanyID { get; set; }

            public int EmployeeID { get; set; }

            public GetEmployeeByCompanyIdEmployeeIdQuery(int companyID, int employeeID)
            {
                CompanyID = companyID;
                EmployeeID = employeeID;
            }
        
    }
}
