using System;
using System.Collections.Generic;

#nullable disable

namespace PayRoll.Domain.Entities
{
    public partial class PayRollKindPayroll
    {
        public int? CompanyId { get; set; }
        public int KindPayrollId { get; set; }
        public string KindPayrollName { get; set; }
        public string KindPayrollFrecuency { get; set; }
        public string KindPayrollIndHoliday { get; set; }
        public string KindPayrollIndBonus { get; set; }
        public string KindPayrollIndCts { get; set; }
    }
}
