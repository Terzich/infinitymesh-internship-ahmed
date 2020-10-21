using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Domain
{
    public class City:BaseEntity
    {
        public string CityName { get; set; }
        public List<User> Users { get; set; }
        public City(string username) : base(username)
        {

        }
    }
}
