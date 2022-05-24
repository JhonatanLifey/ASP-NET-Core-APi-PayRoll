using System;
using System.Collections.Generic;

#nullable disable

namespace PayRoll.Domain.Entities
{
    public partial class PayRollHoliday
    {
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }
        public int HolidayId { get; set; }
        public string HolidayYear { get; set; }
        public string HolidayMonth { get; set; }
        public DateTime? HolidayDateStart { get; set; }
        public DateTime? HolidayDateEnd { get; set; }
        public int? HolidayDays { get; set; }
        public string HolidayYearProcess { get; set; }
    }
}
