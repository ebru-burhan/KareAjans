using KareAjans.Business.Abstract;
using KareAjans.Entity.Enums;
using KareAjans.Model;
using KareAjans.UI.Attributes.AuthorizeAttributes;
using KareAjans.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.Controllers
{
    [UserTypeBasedAuthorize(UserType.Accountant)]
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
            IncomeAddViewModel model = new IncomeAddViewModel()
            {
                Income = new IncomeDTO(),
                Organizations = _organizationService.GetOrganizations()
            };
            return View(model);
        }


        [HttpPost]
        public IActionResult Add(IncomeAddViewModel model)
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


        [HttpGet]
        public IActionResult Update(int id)
        {
            var incomeDto = _incomeService.GetIncomeById(id, true);
            return View(incomeDto);
        }

        [HttpPost]
        public IActionResult Update(IncomeDTO dto)
        {

            _incomeService.UpdateIncome(dto);

            return RedirectToAction(nameof(Detail), new { id = dto.OrganizationId });
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var dto = _incomeService.GetIncomeById(id);
            _incomeService.DeleteIncome(dto);

            //sildikten sonra dtonun idsine erişebildik çünkü silinen entity dto değil
            return RedirectToAction(nameof(Detail), new { id = dto.OrganizationId });
        }
    }
}
