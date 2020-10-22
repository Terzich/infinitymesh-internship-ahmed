using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.Configuration
{
    public class UserRoleConfiguration:BaseEntityConfiguration<UserRole>
    {
        public override void Configure(EntityTypeBuilder<UserRole> builder)
        {
            base.Configure(builder);
            builder.HasOne(b => b.User).WithMany(b => b.UserRoles).HasForeignKey(b => b.UserID);
            builder.HasOne(b => b.Role).WithMany(b => b.UserRoles).HasForeignKey(b => b.RoleID);

            builder.HasData(new List<UserRole>
            {
                new UserRole
                {
                    Id=1,
                     CreatedAt=DateTime.Now,
                    CreatedBy="Terzic",
                    RoleID=1,
                    UserID=1
                },
                new UserRole
                {
                    Id=2,
                     CreatedAt=DateTime.Now,
                    CreatedBy="Terzic",
                    RoleID=2,
                    UserID=2
                }


            });

        }
    }
}
