using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.Configuration
{
    public class RoleConfiguration:BaseEntityConfiguration<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.RoleName).IsRequired();
            builder.HasMany(b => b.UserRoles).WithOne(b => b.Role).HasForeignKey(b => b.RoleID);

            builder.HasData(new List<Role>
            {
                new Role
                {
                    Id=1,
                    RoleName="Administrator",
                    CreatedAt=DateTime.Now,
                    CreatedBy="Terzic",
                   
                },
                new Role
                {
                    Id=2,
                    RoleName="Client",
                    CreatedAt=DateTime.Now,
                    CreatedBy="Terzic",

                }

            });

        }
    }
}
