using KareAjans.Business.Abstract;
using KareAjans.Model;
using KareAjans.UI.ExtensionMethods;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IModelEmployeeService _modelEmployeeService;
        public ProfileController(IModelEmployeeService modelEmployeeService)
        {
            _modelEmployeeService = modelEmployeeService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            // Session'dan User'ı almaya çalıştık
            UserDTO userDto = HttpContext.Session.GetObject<UserDTO>("user");

            // Eğer Session'da user varsa
            if (userDto != null)
            {
                ModelEmployeeDTO modelEmployeeDto = _modelEmployeeService.GetModelEmployeeByUser(userDto);
                return View(modelEmployeeDto);
            }
            else
            {
                // Hata gönder ve bi yere yönlendir
            }

            return View();
        }


    }
}
