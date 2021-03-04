using KareAjans.Business.Abstract;
using KareAjans.DataAccess;
using KareAjans.DataAccess.Abstracts;
using KareAjans.DataAccess.Concretes;
using KareAjans.Entity;
using KareAjans.Entity.Enums;
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
        //private IRepository<ModelEmployee> repository;
        private readonly ISiteContentService _siteContentService;
        private readonly IModelEmployeeService _modelEmployeeService;
        /*
        private readonly ICommentService _commentService;
        private readonly IExpenseService _expenseService;
        private readonly IExpenseTypeService _expenseTypeService;
        private readonly IIncomeService _incomeService;
        
        private readonly IOrganizationService _organizationService;
        private readonly IPermissionService _permissionService;
        private readonly IPictureService _pictureService;
        private readonly IProfessionalDegreeService _professionalDegreeService;
        private readonly IUserService _userService;
        */

        public HomeController(ISiteContentService siteContentService, IModelEmployeeService modelEmployeeService/*
            ICommentService commentService, IExpenseService expenseService , IExpenseTypeService expenseTypeService, IIncomeService incomeService,  IOrganizationService organizationService, IPermissionService permissionService, 
            IPictureService pictureService, IProfessionalDegreeService professionalDegreeService, IUserService userService*/)
        {
            _siteContentService = siteContentService;
            _modelEmployeeService = modelEmployeeService;
            /*
            _commentService = commentService;
            _expenseService = expenseService;
            _expenseTypeService = expenseTypeService;
            _incomeService = incomeService;
            
            _organizationService = organizationService;
            _permissionService = permissionService;
            _pictureService = pictureService;
            _professionalDegreeService = professionalDegreeService;
            _userService = userService;
            */
        }

        public IActionResult Index()
        {

            HomePageViewModel model = new HomePageViewModel()
            {
                AboutText = _siteContentService.GetSiteContentByType(SiteContentType.About).Text,
                ReferencesText = _siteContentService.GetSiteContentByType(SiteContentType.References).Text
            };

            return View(model);
        }
    }
}

