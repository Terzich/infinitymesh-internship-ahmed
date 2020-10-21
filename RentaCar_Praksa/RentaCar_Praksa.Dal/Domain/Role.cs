using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Domain
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public List<UserRole> UserRole { get; set; }

    }
}
