using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.Configuration
{
    public class CarConfiguration:BaseEntityConfiguration<Car>
    {
        public override void Configure(EntityTypeBuilder<Car> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.CarName).IsRequired();
            builder.Property(b => b.HorsePower).IsRequired();
            builder.Property(b => b.YearOFProduction).IsRequired();
            builder.Property(b => b.Price).IsRequired();
            builder.Property(b => b.NumberOfDoors).IsRequired();

            builder.HasMany(b => b.BookedCars).WithOne(b => b.Car).HasForeignKey(b => b.CarID);
            builder.HasOne(b => b.Color).WithMany(b => b.Cars).HasForeignKey(b => b.ColorID);

            builder.HasData(new List<Car>
            {

                new Car
                {
                    Id=1,
                    CarName="Mercedes Benz E220",
                    YearOFProduction=2012,
                    HorsePower=131,
                    NumberOfDoors=5,
                    Price=150,
                    ColorID=1,
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="Terzic"
                },
                new Car
                {
                    Id=2,
                    CarName="Mercedes Benz C220",
                    YearOFProduction=2012,
                    HorsePower=131,
                    NumberOfDoors=5,
                    Price=110,
                    ColorID=2,
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="Terzic"
                },
                new Car
                {
                    Id=3,
                    CarName="Volkswagen Golf VII",
                    YearOFProduction=2016,
                    HorsePower=111,
                    NumberOfDoors=5,
                    Price=120,
                    ColorID=3,
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="Terzic"
                }
            });



        }


    }
}
