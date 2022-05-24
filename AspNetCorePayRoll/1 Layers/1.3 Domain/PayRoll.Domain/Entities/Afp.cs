using System;
using System.Collections.Generic;

#nullable disable

namespace PayRoll.Domain.Entities
{
    public partial class Afp
    {
        public int AfpId { get; set; }
        public string AfpName { get; set; }
        public string AfpStatus { get; set; }
        public string AfpIdRtps { get; set; }
    }
}
