using KareAjans.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class SiteContentDTO
    {
        public int ID { get; set; }
        public SiteContentType SiteContentType { get; set; }
        public string Text { get; set; }
    }
}
