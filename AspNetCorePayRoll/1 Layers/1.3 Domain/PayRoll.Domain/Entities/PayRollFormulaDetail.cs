using System;
using System.Collections.Generic;

#nullable disable

namespace PayRoll.Domain.Entities
{
    public partial class PayRollFormulaDetail
    {
        public int CompanyId { get; set; }
        public int FormulaId { get; set; }
        public int FormulaItem { get; set; }
        public string FormulaVariable { get; set; }
        public string FormulaVariableType { get; set; }
    }
}
