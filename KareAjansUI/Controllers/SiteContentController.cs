using KareAjans.Business.Abstract;
using KareAjans.Model;
using KareAjans.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.Controllers
{
    public class SiteContentController : Controller
    {
        private readonly ISiteContentService _siteContentService;
        public SiteContentController(ISiteContentService siteContentService)
        {
            _siteContentService = siteContentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var dtoList = _siteContentService.GetSiteContents();
            return View(dtoList);
        }

        [HttpGet]
        public IActionResult Update()
        {
            SiteContentViewModel model = new SiteContentViewModel()
            {
                AboutText = _siteContentService.GetSiteContentByType(Entity.Enums.SiteContentType.About).Text,
                ReferencesText = _siteContentService.GetSiteContentByType(Entity.Enums.SiteContentType.References).Text
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(SiteContentViewModel model)
        {
            var aboutDto = _siteContentService.GetSiteContentByType(Entity.Enums.SiteContentType.About);

            var referencesDto = _siteContentService.GetSiteContentByType(Entity.Enums.SiteContentType.References);

            aboutDto.Text = model.AboutText;
            referencesDto.Text = model.ReferencesText;

            _siteContentService.UpdateSiteContent(aboutDto);
            _siteContentService.UpdateSiteContent(referencesDto);

            return View();
        }

    
    }
}
