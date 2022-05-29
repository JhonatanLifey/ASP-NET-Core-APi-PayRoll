using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Aplication.CQRS.Features.Employees.Commands.SaveEmployee
{
    public class SaveEmployeeCommand : IRequest<int>
    {
        public int CompanyId { get; set; }
        public int? AfpId { get; set; }
        public int EmployeeId { get; set; }
        public int? RolId { get; set; }
        public int? KindPayRoll { get; set; }
        public int? PlaceId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeActive { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeMiddle { get; set; }
        public string EmployeeSurname { get; set; }
        public DateTime EmployeeDateStart { get; set; }
        public DateTime? EmployeeDateEnd { get; set; }
        public DateTime EmployeeBirthDate { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeSuburd { get; set; }
        public string EmployeeState { get; set; }
        public string EmployeeCodePost { get; set; }
        public decimal EmployeeSalary { get; set; }
        public string EmployeeKindAfpsnp { get; set; }
        public string EmployeeNumberAfp { get; set; }
        public string EmployeeIndAsigFamiliar { get; set; }
    }
}
