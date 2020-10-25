using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentaCar_Praksa.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar_Praksa.Dal.Configuration
{
    public class UserRoleConfiguration:IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(b => new { b.RoleID, b.UserID });

            builder.HasOne(b => b.User).WithMany(b => b.UserRoles).HasForeignKey(b => b.UserID);
            builder.HasOne(b => b.Role).WithMany(b => b.UserRoles).HasForeignKey(b => b.RoleID);

            builder.HasData(new List<UserRole>
            {
                new UserRole
                {
                    RoleID=1,
                    UserID=1
                },
                new UserRole
                {
                    RoleID=2,
                    UserID=2
                }

            });

        }
    }
}
