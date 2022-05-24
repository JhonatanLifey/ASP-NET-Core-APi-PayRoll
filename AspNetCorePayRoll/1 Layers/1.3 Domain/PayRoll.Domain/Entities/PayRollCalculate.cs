using System;
using System.Collections.Generic;

#nullable disable

namespace PayRoll.Domain.Entities
{
    public partial class PayRollCalculate
    {
        public int? CompanyId { get; set; }
        public int CalculateId { get; set; }
        public string CalculateCode { get; set; }
        public string CalculateName { get; set; }
        public string CalculateDetail { get; set; }
        public string CalculateGroup { get; set; }
        public string CalculateType { get; set; }
        public string CalculateIndHoliday { get; set; }
        public string CalculateIndGratificacion { get; set; }
        public string CalculateIndCts { get; set; }
        public string CalculateIndUtilidades { get; set; }
        public int? FormulaId { get; set; }
    }
}
