using Microsoft.EntityFrameworkCore;
using RentaCar_Praksa.Dal.Configuration;
using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal
{
    public class RentaCarDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        //public DbSet<BookedCar> BookedCars { get; set; }
        //public DbSet<Car> Cars { get; set; }
        public DbSet<City> Cities { get; set; }
        //public DbSet<Color> Colors { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        //public DbSet<Review> Reviews { get; set; }
        //public DbSet<Role> Roles { get; set; }
        //public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = "Server=.;Initial Catalog=RentaCar;Integrated Security=true";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());


            base.OnModelCreating(modelBuilder);
        }




    }
}
