using System;
using System.Collections.Generic;

#nullable disable

namespace PayRoll.Domain.Entities
{
    public partial class PayRollCloseFrequency
    {
        public string CloseOYear { get; set; }
        public string CloseOMonth { get; set; }
        public string CloseOFrequency { get; set; }
        public int KindPayrollId { get; set; }
        public string CloseOStatus { get; set; }
    }
}
