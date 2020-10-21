using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Domain
{
    public class Role:BaseEntity
    {
        public string RoleName { get; set; }
        public List<UserRole> UserRole { get; set; }

        public Role(string username):base(username)
        {

        }


    }
}
