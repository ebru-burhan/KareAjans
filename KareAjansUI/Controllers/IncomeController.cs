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
    public class IncomeController : Controller
    {
        private readonly IIncomeService _incomeService;
        private readonly IOrganizationService _organizationService;

        public IncomeController(IIncomeService incomeService, IOrganizationService organizationService)
        {
            _incomeService = incomeService;
            _organizationService = organizationService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var dtolist = _organizationService.GetOrganizationsWithIncomes();
            return View(dtolist);
        }

        [HttpGet]
        public IActionResult Add()
        {
            IncomeViewModel model = new IncomeViewModel()
            {
                Income = new IncomeDTO(),
                Organizations = _organizationService.GetOrganizations()
            };
            return View(model);
        }


        [HttpPost]
        public IActionResult Add(IncomeViewModel model)
        {
            _incomeService.AddIncome(model.Income);
            

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Detail(int id)
        {
           var organizationDto = _organizationService.GetOrganizationById(id,true);
           List<IncomeDTO> incomeDtoList = organizationDto.Incomes;
            return View(incomeDtoList);
        }
    }
}
