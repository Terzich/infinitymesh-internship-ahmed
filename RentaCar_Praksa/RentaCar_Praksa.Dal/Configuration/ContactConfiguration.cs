using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.Configuration
{
    public class ContactConfiguration:BaseEntityConfiguration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Question).HasMaxLength(100).IsRequired();
            builder.HasOne(b => b.User).WithMany(b => b.Contacts).HasForeignKey(b => b.UserID);

            builder.HasData(new List<Contact>
            {
                new Contact
                {
                    Id=1,
                    Question="Koliko dugo mogu da rentam vozilo?",
                    UserID=2,
                    CreatedAt=DateTime.Now,
                    CreatedBy="Terzic",

                },
                new Contact
                {
                    Id=2,
                    Question="Da li su vozila odrzavana redovno?",
                    UserID=2,
                    CreatedAt=DateTime.Now,
                    CreatedBy="Terzic",
                }

            });

        }
    }
}
