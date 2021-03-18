using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(x => x.FirstName).HasMaxLength(40).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(40).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(40).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(40).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();

            //seed == db oluşurken gerekli olan ilk datalar prodegree,user,expensetype,sitecontent , permission
            builder.HasData(
                new User { UserID = 1, FirstName = "Ebru", LastName = "Burhan", Email = "yonetici@kareajans.com", Password = "1234", PermissionId = 1, CreatedDate = DateTime.Now },
                new User { UserID = 2, FirstName = "Muhasebeci", LastName = "Insan", Email = "muhasebe@kareajans.com", Password = "1234", PermissionId = 3, CreatedDate = DateTime.Now }
              );
            // TODO: createdDAte silinebilir
            // TODO: passwordde min lenght koy
        }
    }
}
