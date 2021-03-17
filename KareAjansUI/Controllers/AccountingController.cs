using KareAjans.Business.Abstract;
using KareAjans.Entity.Enums;
using KareAjans.UI.Attributes.AuthorizeAttributes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.Controllers
{
    [UserTypeBasedAuthorize(UserType.Administrator)]
    [UserTypeBasedAuthorize(UserType.Accountant)]
    public class AccountingController : Controller
    {
        private readonly IAccountingService _accountingService;
        private readonly IOrganizationService _organizationService;
        public AccountingController(IAccountingService accountingService, IOrganizationService organizationService)
        {
            _accountingService = accountingService;
            _organizationService = organizationService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var organizationDto = _organizationService.GetOrganizationsWithIncomes();
            return View(organizationDto);
          
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var accountingDto = _accountingService.GetAccountingByOrganization(id);
            return View(accountingDto);
        }
    }
}
