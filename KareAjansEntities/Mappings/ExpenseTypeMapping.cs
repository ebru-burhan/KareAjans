using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.Mappings
{
    public class ExpenseTypeMapping : IEntityTypeConfiguration<ExpenseType>
    {
        public void Configure(EntityTypeBuilder<ExpenseType> builder)
        {
            builder.ToTable("ExpenseTypes");
            builder.Property(x => x.Title).HasMaxLength(40).IsRequired();
            builder.Property(x => x.Amount).HasColumnType("money");
            builder.Property(x => x.CreatedDate).IsRequired();

            //seed == db oluşurken gerekli olan ilk datalar prodegree,user,expensetype,sitecontent , permission
            builder.HasData(
                new ExpenseType { ExpenseTypeID = 1,Title = "Yemek", Amount = 10, CreatedDate = DateTime.Now },
                new ExpenseType { ExpenseTypeID = 2,Title = "Konaklama", Amount = 40, CreatedDate = DateTime.Now },
                new ExpenseType { ExpenseTypeID = 3,Title = "Maas", Amount = 0, CreatedDate = DateTime.Now }
              );

        }
    }
}
