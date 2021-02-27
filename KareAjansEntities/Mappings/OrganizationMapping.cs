using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.Mappings
{
    public class OrganizationMapping : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.ToTable("Organizations");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.OrganizationName).HasMaxLength(40).IsRequired();
            builder.Property(x => x.StartingDate).IsRequired();
            builder.Property(x => x.EndingDate).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
        }
    }
}
