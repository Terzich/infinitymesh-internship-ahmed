using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.Configuration
{
    public class ColorConfiguration:BaseEntityConfiguration<Color>
    {
        public override void Configure(EntityTypeBuilder<Color> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.ColorName).IsRequired();

            builder.HasMany(b => b.Cars).WithOne(b => b.Color).HasForeignKey(b => b.ColorID);

            builder.HasData(new List<Color>
            {
                new Color
                {
                    Id=1,
                    ColorName="Metalik siva",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="Terzic"
                },
                new Color
                {
                    Id=2,
                    ColorName="Metalik crna",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="Terzic"
                },
                new Color
                {
                    Id=3,
                    ColorName="Metalik crvena",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="Terzic"
                },
                new Color
                {
                    Id=4,
                    ColorName="Mat crna",
                    CreatedAt=DateTime.UtcNow,
                    CreatedBy="Terzic"
                },

            });


        }

    }
}
