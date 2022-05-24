using System;
using System.Collections.Generic;

#nullable disable

namespace PayRoll.Domain.Entities
{
    public partial class MasterCompany
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNumberTax { get; set; }
        public string CompanyNumber { get; set; }
        public string CompanyStreet { get; set; }
        public string CompanySuburb { get; set; }
        public string CompanyState { get; set; }
        public string CompanyPhone { get; set; }
    }
}
