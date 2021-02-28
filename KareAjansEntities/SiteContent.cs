using KareAjans.Entity.Abstracts;
using KareAjans.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity
{
    public class SiteContent : BaseEntity
    {
        public int SiteContentID { get; set; }
        public SiteContentType SiteContentType { get; set; }
        public string Text { get; set; }
    }
}
