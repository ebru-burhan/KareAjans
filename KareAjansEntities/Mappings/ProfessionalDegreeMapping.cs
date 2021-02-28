using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.Mappings
{
    public class ProfessionalDegreeMapping : IEntityTypeConfiguration<ProfessionalDegree>
    {
        public void Configure(EntityTypeBuilder<ProfessionalDegree> builder)
        {
            builder.ToTable("ProfessionalDegrees");
            builder.Property(x => x.Title).HasMaxLength(40).IsRequired();
            builder.Property(x => x.DailyWage).HasColumnType("money");
            builder.Property(x => x.DailyPercentage).HasColumnType("tinyint");
            builder.Property(x => x.CreatedDate).IsRequired();

            //seed == db oluşurken gerekli olan ilk datalar prodegree,user,expensetype,sitecontent
            builder.HasData(
                new ProfessionalDegree { ProfessionalDegreeID = 1, Title = "Kategori1", DailyWage = 40, CreatedDate = DateTime.Now },
                new ProfessionalDegree { ProfessionalDegreeID = 2, Title = "Kategori2", DailyWage = 100, CreatedDate = DateTime.Now },
                new ProfessionalDegree { ProfessionalDegreeID = 3, Title = "Kategori3", DailyWage = 0, DailyPercentage = 20, CreatedDate = DateTime.Now }
                               
               );
        }
    }
}
