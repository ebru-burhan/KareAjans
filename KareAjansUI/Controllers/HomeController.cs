using KareAjans.Business.Abstract;
using KareAjans.DataAccess;
using KareAjans.DataAccess.Abstracts;
using KareAjans.DataAccess.Concretes;
using KareAjans.Entity;
using KareAjans.Entity.Enums;
using KareAjans.Model;
using KareAjans.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.Controllers
{
    public class HomeController : Controller
    {

        private readonly ISiteContentService _siteContentService;
        private readonly IModelEmployeeService _modelEmployeeService;


        public HomeController(ISiteContentService siteContentService, IModelEmployeeService modelEmployeeService)
        {
            _siteContentService = siteContentService;
            _modelEmployeeService = modelEmployeeService;

        }

        public IActionResult Index()
        {
            var modelEmployeeDTOList = _modelEmployeeService.GetModelEmployees();

            List<ModelEmployeeViewModel> modelList = new List<ModelEmployeeViewModel>();
            foreach (var item in modelEmployeeDTOList)
            {
                var picture = item.Pictures.FirstOrDefault() == null ? "" : item.Pictures.FirstOrDefault().Url;

                int age = DateTime.Today.Year - item.DateOfBirth.Year;

                ModelEmployeeViewModel model = new ModelEmployeeViewModel()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    DateOfBirth = item.DateOfBirth,
                    PictureUrl = picture,
                    Age = age
                };

                modelList.Add(model);
            }


            HomePageViewModel HomePageModel = new HomePageViewModel()
            {
                AboutText = _siteContentService.GetSiteContentByType(SiteContentType.About).Text,
                ReferencesText = _siteContentService.GetSiteContentByType(SiteContentType.References).Text,
                ModelEmployees = modelList
            };

            return View(HomePageModel);
        }
    }
}

