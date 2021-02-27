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
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(40).IsRequired();
            builder.Property(x => x.DailyWage).HasColumnType("money").IsRequired();
            builder.Property(x => x.DailyPercentage).HasColumnType("tinyint").IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
        }
    }
}
