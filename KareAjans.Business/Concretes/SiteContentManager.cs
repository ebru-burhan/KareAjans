using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class SiteContentManager : ISiteContentService
    {
        private readonly ISiteContentRepository _siteContentRepo;

        public SiteContentManager(ISiteContentRepository siteContentRepo)
        {
            _siteContentRepo = siteContentRepo;
        }

        public List<SiteContentDTO> GetSiteContents()
        {
            IQueryable<SiteContent> siteContents = _siteContentRepo.GetAll();
            List<SiteContentDTO> dtolist = new List<SiteContentDTO>();

            foreach (SiteContent item in siteContents)
            {
                dtolist.Add(ConvertToDto(item));
            }
            return dtolist;
        }

        public void AddSiteContent(SiteContentDTO dto)
        {
            _siteContentRepo.Add(ConvertToEntity(dto));
        }

        public void DeleteSiteContent(SiteContentDTO dto)
        {
            _siteContentRepo.Delete(ConvertToEntity(dto));
        }

        public void UpdateSiteContent(SiteContentDTO dto)
        {
            _siteContentRepo.Update(ConvertToEntity(dto));
        }


        #region Private
        //--------------dto dan entity ve enttyden dto çevrme methodlar----------------------
        private SiteContentDTO ConvertToDto(SiteContent siteContent)
        {
            SiteContentDTO dto = new SiteContentDTO()
            {
                ID = siteContent.SiteContentID,
                SiteContentType = siteContent.SiteContentType,
                Text = siteContent.Text
            };

            return dto;
        }

        private SiteContent ConvertToEntity(SiteContentDTO dto)
        {
            SiteContent entity = new SiteContent()
            {
                SiteContentID = dto.ID,
                SiteContentType = dto.SiteContentType,
                Text = dto.Text
            };

            return entity;
        }

       
        #endregion
    }
}
