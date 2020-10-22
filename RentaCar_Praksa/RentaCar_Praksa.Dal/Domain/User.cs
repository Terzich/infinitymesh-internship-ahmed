using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar_Praksa.Dal.Domain
{
    public class User:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }
        //public List<BookedCar> BookedCars { get; set; }
        public List<Contact> Contacts { get; set; }

    }
}
