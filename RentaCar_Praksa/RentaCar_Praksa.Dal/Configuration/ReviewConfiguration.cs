using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.Configuration
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {

            builder.Property(b => b.Comment).IsRequired();
            builder.Property(b => b.Rating).IsRequired();

            builder.HasKey(b => b.BookedCarID);

            builder.HasOne(b => b.BookedCar).WithOne(b => b.Review).HasForeignKey<Review>(b => b.BookedCarID);

        }
    }
}
