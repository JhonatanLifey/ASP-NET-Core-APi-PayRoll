using System;
using System.Collections.Generic;

#nullable disable

namespace PayRoll.Domain.Entities
{
    public partial class PayRollFormula
    {
        public int? CompanyId { get; set; }
        public int FormulaId { get; set; }
        public string FormulaDescription { get; set; }
        public string Formula { get; set; }
        public string FormulaStatus { get; set; }
    }
}
