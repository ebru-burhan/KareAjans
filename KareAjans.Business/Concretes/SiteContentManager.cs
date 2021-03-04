using AutoMapper;
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
        private readonly ISiteContentRepository _siteContentRepository;
        private readonly IMapper _mapper;

        public SiteContentManager(ISiteContentRepository siteContentRepository, IMapper mapper)
        {
            _siteContentRepository = siteContentRepository;
            _mapper = mapper;
        }

        public List<SiteContentDTO> GetSiteContents()
        {
            var siteContents = _siteContentRepository.GetAll();
            return _mapper.Map<List<SiteContentDTO>>(siteContents);
        }

        public void AddSiteContent(SiteContentDTO dto)
        {
            _siteContentRepository.Add(_mapper.Map<SiteContent>(dto));
        }

        public void DeleteSiteContent(SiteContentDTO dto)
        {
            _siteContentRepository.Delete(_mapper.Map<SiteContent>(dto));
        }

        public void UpdateSiteContent(SiteContentDTO dto)
        {
            _siteContentRepository.Update(_mapper.Map<SiteContent>(dto));
        }

    }
}
