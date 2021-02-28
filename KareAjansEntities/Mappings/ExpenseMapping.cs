using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.Mappings
{
    public class ExpenseMapping : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.ToTable("Expenses");
            builder.Property(x => x.Amount).HasColumnType("money").IsRequired();

            //builder.HasOne<ModelEmployeeOrganization>(x => x.ModelEmployeeOrganization)
            //    .WithMany(x => x.Expenses)
            //    .HasForeignKey(x => x.ModelEmployeeOrganizationId);
        
        }
    }
}
