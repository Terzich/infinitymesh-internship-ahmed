using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Domain
{
    public class Contact:BaseEntity
    {
        public string Question { get; set; }
        public string Response { get; set; }
        public string? Email { get; set; }
        public int? UserID { get; set; }
        public User? User { get; set; }

        public Contact(string username) : base(username)
        {

        }

    }
}
