using KareAjans.Entity;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface ISiteContentService: IService
    {
        List<SiteContentDTO> GetSiteContents();
        void AddSiteContent(SiteContentDTO dto);
        void DeleteSiteContent(SiteContentDTO dto);
        void UpdateSiteContent(SiteContentDTO dto);
    }
}
