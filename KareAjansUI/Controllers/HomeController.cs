using KareAjans.DataAccess;
using KareAjans.DataAccess.Abstracts;
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
        private IRepository<ModelEmployee> repository;

        public IActionResult Index()
        {
            repository = new BaseRepository<ModelEmployee>(new DataContext());

            repository.GetAll();

            return View();
        }
    }
}
