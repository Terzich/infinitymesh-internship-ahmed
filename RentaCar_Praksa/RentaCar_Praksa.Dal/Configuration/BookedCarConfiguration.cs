using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.Configuration
{
    public class BookedCarConfiguration:BaseEntityConfiguration<BookedCar>
    {
        public override void Configure(EntityTypeBuilder<BookedCar> builder)
        {
            base.Configure(builder);

            builder.Property(b => b.From).IsRequired();
            builder.Property(b => b.To).IsRequired();

            builder.HasOne(b => b.Car).WithMany(b => b.BookedCars).HasForeignKey(b => b.CarID);
            builder.HasOne(b => b.User).WithMany(b => b.BookedCars).HasForeignKey(b => b.UserID);
            builder.HasOne(b => b.Review).WithOne(b => b.BookedCar).HasForeignKey<Review>(b => b.BookedCarID);

            builder.HasData(new List<BookedCar>
            {

                new BookedCar
                {
                    Id=1,
                    CarID=1,
                    UserID=2,
                    From=DateTime.UtcNow,
                    To=new DateTime(2020,10,27),
                    TotalPrice=300,
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="Terzic"
                },
                new BookedCar
                {
                    Id=2,
                    CarID=3,
                    UserID=1,
                    From=DateTime.UtcNow,
                    To=new DateTime(2020,10,28),
                    TotalPrice=360,
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="Terzic"
                },
            });



        }

    }
}
