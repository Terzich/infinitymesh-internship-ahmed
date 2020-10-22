using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.Configuration
{
    public class CityConfiguration:BaseEntityConfiguration<City>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.CityName).IsRequired().HasMaxLength(30);
            builder.HasMany(b => b.Users).WithOne(b => b.City).HasForeignKey(b => b.CityID);
            builder.HasData(new List<City>
            {
                new City
                {
                    Id=1,
                    CityName="Bugojno",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="Terzic",
                   
                },
                new City
                {
                    Id=2,
                    CityName="Sarajevo",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="Terzic",

                },
                new City
                {
                    Id=3,
                    CityName="Mostar",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="Terzic",

                },

            });

        }
    }
}
