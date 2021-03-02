using KareAjans.Business.Abstract;
using KareAjans.DataAccess;
using KareAjans.DataAccess.Abstracts;
using KareAjans.DataAccess.Concretes;
using KareAjans.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjansUI.Controllers
{
    public class HomeController : Controller
    {
        //private IRepository<ModelEmployee> repository;
        private readonly ISiteContentService _siteContentService;

        public HomeController(ISiteContentService siteContentService)
        {
            _siteContentService = siteContentService;
        }

        public IActionResult Index()
        {
            ////repository = new BaseRepository<ModelEmployee>(new DataContext());

            //repository.GetAll();,

            // repo = new SiteContentRepository(new DataContext());
            //var list =   repo.GetAll();

            //var getById = repo.Get();
            /*
           SiteContent entity = new SiteContent()
            {
                CreatedDate = DateTime.Now,
                SiteContentType = KareAjans.Entity.Enums.SiteContentType.About,
                Text = "first added entity"
            };
            */
            //repo.Add(entity);

            //var updatelencekEntity = repo.Get(x => x.SiteContentID == 3).FirstOrDefault();
            //updatelencekEntity.Text = "first updated entity";
            // repo.Update(updatelencekEntity);

            //var silinecekEntity = repo.Get(x => x.SiteContentID == 3).FirstOrDefault();
            //repo.Delete(silinecekEntity);


            //var list = repo.GetAll();

            var list = _siteContentService.GetSiteContents();

            return View();
        }
    }
}
