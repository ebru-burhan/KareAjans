using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.Mappings
{
    public class PermissionMapping : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("Permissions");
            builder.Property(x => x.UserType).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();

            //seed == db oluşurken gerekli olan ilk datalar prodegree,user,expensetype,sitecontent , permission
            builder.HasData(
               new Permission { PermissionID = 1, UserType = Enums.UserType.Administrator, CreatedDate = DateTime.Now },
               new Permission { PermissionID = 2, UserType = Enums.UserType.ModelEmployee, CreatedDate = DateTime.Now },
               new Permission { PermissionID = 3, UserType = Enums.UserType.Accountant, CreatedDate = DateTime.Now },
               new Permission { PermissionID = 4, UserType = Enums.UserType.ITManager, CreatedDate = DateTime.Now }
             );

        }
    }
}
