using System;

namespace PayRoll.Domain.Common
{
    public abstract class EntityBase  //Crearte addicional field for all entities
    {

        public int Id { get; protected set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate{ get; set; }
        public string LastModifyBy { get; set; }
        public string LastMpdifyBy { get; set; }
        public DateTime? LastModifiedDate{ get; set; }

    }
}
