using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentaCar_Praksa.Dal.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel(IReadOnlyCollection<User> users)
        {
            Collection = users.Select(u => new UserDto(u)).ToList();
        }
        public IReadOnlyCollection<UserDto> Collection { get; set; }
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public string Address { get; set; }
        //public string Email { get; set; }
        //public string Username { get; set; }
        //public string Password { get; set; }
        //public int CityID { get; set; }
        //public City City { get; set; }
    }
}
