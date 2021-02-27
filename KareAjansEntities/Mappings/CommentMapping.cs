using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.Mappings
{
    public class CommentMapping : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.Message).HasMaxLength(400).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();

            //otomatik yapıyo gerek yok
            /*
            builder
               .HasOne<ModelEmployee>(x => x.ModelEmployee)
               .WithMany(meo => meo.Comments)
               .HasForeignKey(x => x.ModelEmployeeId);
            */
        }
    }
}
