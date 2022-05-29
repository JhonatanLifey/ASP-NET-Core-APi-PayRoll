using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Aplication.CQRS.Features.Employees.Commands.DeleteEmploye
{
    public class DeleteEmployeeCommand : IRequest
    {
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }

    }
}
