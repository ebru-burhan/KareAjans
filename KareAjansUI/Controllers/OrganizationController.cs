using KareAjans.Business.Abstract;
using KareAjans.Model;
using KareAjans.UI.ExtensionMethods;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.Controllers
{
    public class OrganizationController : Controller
    {
        private readonly IOrganizationService _organizationService;
        public OrganizationController(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var dtoList = _organizationService.GetOrganizations();

            return View(dtoList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(OrganizationDTO dto)
        {
            _organizationService.AddOrganization(dto);

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var dto = _organizationService.GetOrganizationById(id);

            return View(dto);
        }

        [HttpPost]
        public IActionResult Update(OrganizationDTO dto)
        {
            _organizationService.UpdateOrganization(dto);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            OrganizationDTO dto =_organizationService.GetOrganizationById(id);
            _organizationService.DeleteOrganization(dto);

            return RedirectToAction(nameof(Index));
        }
    }
}
