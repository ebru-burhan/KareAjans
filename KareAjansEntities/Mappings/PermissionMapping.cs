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
               new Permission { PermissionID =(int) Enums.UserType.Administrator, UserType = Enums.UserType.Administrator, CreatedDate = DateTime.Now },
               new Permission { PermissionID = (int)Enums.UserType.ModelEmployee, UserType = Enums.UserType.ModelEmployee, CreatedDate = DateTime.Now },
               new Permission { PermissionID = (int)Enums.UserType.Accountant, UserType = Enums.UserType.Accountant, CreatedDate = DateTime.Now }
             );

        }
    }
}
