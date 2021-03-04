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
        private readonly ICommentService _commentService;
        private readonly IExpenseService _expenseService;
        private readonly IExpenseTypeService _expenseTypeService;
        private readonly IIncomeService _incomeService;
        private readonly IModelEmployeeService _modelEmployeeService;
        private readonly IOrganizationService _organizationService;
        private readonly IPermissionService _permissionService;
        private readonly IPictureService _pictureService;
        private readonly IProfessionalDegreeService _professionalDegreeService;
        private readonly IUserService _userService;

        public HomeController(ISiteContentService siteContentService, ICommentService commentService, IExpenseService expenseService , IExpenseTypeService expenseTypeService, IIncomeService incomeService, IModelEmployeeService modelEmployeeService, IOrganizationService organizationService, IPermissionService permissionService, 
            IPictureService pictureService, IProfessionalDegreeService professionalDegreeService, IUserService userService)
        {
            _siteContentService = siteContentService;
            _commentService = commentService;
            _expenseService = expenseService;
            _expenseTypeService = expenseTypeService;
            _incomeService = incomeService;
            _modelEmployeeService = modelEmployeeService;
            _organizationService = organizationService;
            _permissionService = permissionService;
            _pictureService = pictureService;
            _professionalDegreeService = professionalDegreeService;
            _userService = userService;
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

            var list1 = _siteContentService.GetSiteContents();
            var list2 = _commentService.GetComments();
            var list3 = _expenseService.GetExpenses();
            var list4 = _expenseTypeService.GetExpenseTypes();
            var list5 = _incomeService.GetIncomes();
            var list6 = _modelEmployeeService.GetModelEmployees();
            var list7 = _organizationService.GetOrganizations();
            var list8 = _permissionService.GetPermissions();
            var list9 = _pictureService.GetPictures();
            var list10 = _professionalDegreeService.GetProfessionalDegrees();
            var list11 = _userService.GetUsers();

            return View();
        }
    }
}
