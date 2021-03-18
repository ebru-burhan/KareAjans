using KareAjans.Entity;
using KareAjans.Entity.Enums;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface ISiteContentService: IService
    {
        List<SiteContentDTO> GetSiteContents();
        void UpdateSiteContent(SiteContentDTO dto);

        //----------
        SiteContentDTO GetSiteContentByType(SiteContentType type);
    }
}
