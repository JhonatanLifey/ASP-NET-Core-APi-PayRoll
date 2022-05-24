using System;
using System.Collections.Generic;

#nullable disable

namespace PayRoll.Domain.Entities
{
    public partial class PayRollPlace
    {
        public int? CompanyId { get; set; }
        public int PlaceId { get; set; }
        public string PlaceName { get; set; }
    }
}
