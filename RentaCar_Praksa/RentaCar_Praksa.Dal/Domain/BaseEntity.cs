using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifideAt { get; set; }

        protected BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
        }


    }
}
