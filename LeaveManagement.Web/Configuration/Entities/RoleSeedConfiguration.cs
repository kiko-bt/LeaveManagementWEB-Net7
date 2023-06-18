﻿using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
               new IdentityRole
               {
                   Id = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                   Name = Roles.Administrator,
                   NormalizedName = Roles.Administrator.ToUpper()
               },
               new IdentityRole
               {
                   Id = "cac43a7e-f8cc-9948-baaf-1aqd431cacbt",
                   Name = Roles.User,
                   NormalizedName = Roles.User.ToUpper()
               });
        }
    }
}