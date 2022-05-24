using System;
using System.Collections.Generic;

#nullable disable

namespace PayRoll.Domain.Entities
{
    public partial class PayRollPayroll
    {
        public decimal CompanyId { get; set; }
        public decimal PaymentId { get; set; }
        public decimal EmployeeId { get; set; }
        public string PayrollConceptId { get; set; }
        public string PaymentYear { get; set; }
        public string PaymentMonth { get; set; }
        public decimal? PaymentAmountInput { get; set; }
        public decimal? PaymentAmountCalc { get; set; }
        public string PaymentIndInput { get; set; }
    }
}
