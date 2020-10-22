using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Domain
{
    public class UserRole:BaseEntity
    {
        public int UserID{ get; set; }
        public int RoleID { get; set; }
        public User User{ get; set; }
        public Role Role{ get; set; }
        
    }
}
