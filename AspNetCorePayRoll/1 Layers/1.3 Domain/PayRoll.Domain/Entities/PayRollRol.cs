using System;
using System.Collections.Generic;

#nullable disable

namespace PayRoll.Domain.Entities
{
    public partial class PayRollRol
    {
        public int? CompanyId { get; set; }
        public int RolId { get; set; }
        public string RolCode { get; set; }
        public string RolDescripcion { get; set; }
        public string RolStatus { get; set; }
    }
}
