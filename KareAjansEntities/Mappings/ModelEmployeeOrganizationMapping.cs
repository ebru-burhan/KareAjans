using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.Mappings
{
    public class ModelEmployeeOrganizationMapping : IEntityTypeConfiguration<ModelEmployeeOrganization>
    {
        public void Configure(EntityTypeBuilder<ModelEmployeeOrganization> builder)
        {
            builder.ToTable("ModelEmployeeOrganizations");
           

            builder
                .HasKey(x => new { x.ModelEmployeeId, x.OrganizationId });

            builder
                .HasOne<ModelEmployee>(x => x.ModelEmployee)
                .WithMany(meo => meo.ModelEmployeeOrganizations)
                .HasForeignKey(x => x.ModelEmployeeId);

            builder
                .HasOne<Organization>(x => x.Organization)
                .WithMany(meo => meo.ModelEmployeeOrganizations)
                .HasForeignKey(x => x.OrganizationId);
        }
    }
}
