using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.Configuration
{
    public class UserConfiguration:BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.HasOne(b => b.City).WithMany(b => b.Users).HasForeignKey(b => b.CityID);
            builder.HasMany(b => b.UserRoles).WithOne(b => b.User).HasForeignKey(b => b.UserID);
            builder.HasMany(b => b.Contacts).WithOne(b => b.User).HasForeignKey(b => b.UserID);
            builder.HasMany(b => b.BookedCars).WithOne(b => b.User).HasForeignKey(b => b.UserID);


            builder.HasData(new List<User>
            {
                new User
                {
                    Id=1,
                    Name="Ahmed",
                    Surname="Terzic",
                    CityID=1,
                    DateOfBirth=new DateTime(1999,01,13),
                    Email="ahmedterzic@hotmail.com",
                    Address="Prusac bb 70223",
                    Username="Terzic",
                    Password="ahmed123",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="Terzic",

                },
                new User
                {
                    Id=2,
                    Name="John",
                    Surname="NijeDOE",
                    CityID=2,
                    DateOfBirth=new DateTime(1998,04,23),
                    Email="nijedoe@hotmail.com",
                    Address="Logavina br. 21",
                    Username="NijeDOE",
                    Password="jihn123",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="Terzic",

                }
                

            });

        }

    }
}
