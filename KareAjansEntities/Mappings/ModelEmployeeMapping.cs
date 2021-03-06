using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.Mappings
{
    public class ModelEmployeeMapping : IEntityTypeConfiguration<ModelEmployee>
    {
        public void Configure(EntityTypeBuilder<ModelEmployee> builder)
        {
            builder.ToTable("ModelEmployees");
            builder.Property(x => x.FirstName).HasMaxLength(40).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(40).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(400).IsRequired();
            builder.Property(x => x.PhoneNo1).HasMaxLength(11).IsRequired();
            builder.Property(x => x.PhoneNo2).HasMaxLength(11).IsRequired();
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.Weight).HasColumnType("tinyint").IsRequired();
            builder.Property(x => x.Height).HasColumnType("tinyint").IsRequired();
            builder.Property(x => x.ShoeSize).IsRequired();
            builder.Property(x => x.EyeColor).IsRequired();
            builder.Property(x => x.HairColor).IsRequired();
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.BodySize).IsRequired();
            builder.Property(x => x.ForeignLanguage).HasMaxLength(40);
            builder.Property(x => x.Speciality).HasMaxLength(400);
        }
    }
}
