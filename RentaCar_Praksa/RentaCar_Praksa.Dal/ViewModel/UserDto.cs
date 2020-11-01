using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.ViewModel
{
    public class UserDto
    {

        public UserDto()
        {

        }
        public UserDto(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Surname = user.Surname;
            DateOfBirth = user.DateOfBirth;
            Address = user.Address;
            Email = user.Email;
            Username = user.Username;
            Password = user.Password;
            CityID = user.CityID;
            City = user.City;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }
    }
}
