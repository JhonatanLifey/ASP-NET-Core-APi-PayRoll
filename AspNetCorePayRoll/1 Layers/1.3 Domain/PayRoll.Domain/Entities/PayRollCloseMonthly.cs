using System;
using System.Collections.Generic;

#nullable disable

namespace PayRoll.Domain.Entities
{
    public partial class PayRollCloseMonthly
    {
        public string CloseMYear { get; set; }
        public string CloseMMonth { get; set; }
        public int KindPayrollId { get; set; }
        public string CloseMStatus { get; set; }
    }
}
