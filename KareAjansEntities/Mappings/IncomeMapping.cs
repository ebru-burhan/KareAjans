using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.Mappings
{
    public class IncomeMapping : IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {
            builder.ToTable("Incomes");
            builder.Property(x => x.Amount).HasColumnType("money").IsRequired();
        }
    }
}
