using System;
using System.Collections.Generic;

#nullable disable

namespace PayRoll.Domain.Entities
{
    public partial class PayRollAfpdetail
    {
        public int AfpId { get; set; }
        public string AfpYear { get; set; }
        public string AfpMonth { get; set; }
        public decimal? AfpRate { get; set; }
    }
}
