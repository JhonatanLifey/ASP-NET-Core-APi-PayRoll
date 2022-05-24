using System;
using System.Collections.Generic;

#nullable disable

namespace PayRoll.Domain.Entities
{
    public partial class PayRollPayrollConcept
    {
        public decimal CompanyId { get; set; }
        public decimal PayrollConceptId { get; set; }
        public string CalculateId { get; set; }
        public string PayrollConceptName { get; set; }
        public string PayrollConceptIndInput { get; set; }
    }
}
