using Microsoft.EntityFrameworkCore;
using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal
{
    public class RentaCarDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<BookedCar> BookedCars { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }




    }
}
