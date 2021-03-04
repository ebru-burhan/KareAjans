using KareAjans.Business.Abstract;
using KareAjans.DataAccess;
using KareAjans.DataAccess.Abstracts;
using KareAjans.DataAccess.Concretes;
using KareAjans.Entity;
using KareAjansUI.ViewModels;
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
            /*
            var dtolist =_siteContentService.GetSiteContents();
            HomePageViewModel model = new HomePageViewModel()
            {
                AboutText = dtolist.Where(x => x.Sit)
            }
            */
            return View();
        }
    }
}
