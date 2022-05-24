using System;
using System.Collections.Generic;

#nullable disable

namespace PayRoll.Domain.Entities
{
    public partial class PayRollProvisionCt
    {
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }
        public string ProcessMonth { get; set; }
        public string ProcessYear { get; set; }
        public decimal? ProcessAmount { get; set; }
    }
}
