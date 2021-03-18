using KareAjans.Entity.Enums;
using KareAjans.Model;
using KareAjans.UI.Attributes.AuthorizeAttributes;
using KareAjans.UI.ExtensionMethods;
using KareAjans.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.Controllers
{
    public class AdminController : Controller
    {
        [UserTypeBasedAuthorize(UserType.Accountant)]
        public IActionResult Index()
        {
            UserDTO userDto = HttpContext.Session.GetObject<UserDTO>("user");

            if (userDto != null)
            {
                AdminHomeViewModel model = new AdminHomeViewModel
                {
                    FullName = userDto.FirstName + " " + userDto.LastName
                };

                return View(model);
            }

            return View();
        }
    }
}
