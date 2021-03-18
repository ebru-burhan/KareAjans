using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.Mappings
{
    public class SiteContentMapping : IEntityTypeConfiguration<SiteContent>
    {
        public void Configure(EntityTypeBuilder<SiteContent> builder)
        {
            builder.ToTable("SiteContents");
            builder.Property(x => x.SiteContentType).IsRequired();
            builder.Property(x => x.Text).IsRequired();

            //seed == db oluşurken gerekli olan ilk datalar prodegree,user,expensetype,sitecontent , permission
            builder.HasData(
                new SiteContent { SiteContentID = 1,SiteContentType = Enums.SiteContentType.About,Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc efficitur mauris ac metus molestie, eu aliquet nisi ornare. Praesent ultricies erat quis enim molestie mollis. Phasellus in nunc ut justo efficitur sagittis id nec nisi. Aliquam erat volutpat. Phasellus posuere odio ut nulla tincidunt tincidunt.", CreatedDate = DateTime.Now },
                new SiteContent { SiteContentID = 2,SiteContentType = Enums.SiteContentType.References,Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc efficitur mauris ac metus molestie, eu aliquet nisi ornare. Praesent ultricies erat quis enim molestie mollis. Phasellus in nunc ut justo efficitur sagittis id nec nisi. Aliquam erat volutpat. Phasellus posuere odio ut nulla tincidunt tincidunt.", CreatedDate = DateTime.Now }
              );
        }
    }
}
