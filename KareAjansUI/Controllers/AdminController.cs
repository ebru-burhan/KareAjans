using KareAjans.Entity.Enums;
using KareAjans.UI.Attributes.AuthorizeAttributes;
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
            return View();
        }
    }
}
