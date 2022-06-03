using System;

namespace PayRoll.Domain.Common
{
    public abstract class EntityBase  //Crearte addicional field for all entities
    {

        public int Id { get; protected set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate{ get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate{ get; set; }

    }
}
