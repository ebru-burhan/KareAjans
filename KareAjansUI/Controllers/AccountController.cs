﻿using KareAjans.Business.Abstract;
using KareAjans.Model;
using KareAjans.UI.ExtensionMethods;
using KareAjans.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            var userDto = _userService.CheckUser(model.Email, model.Password);

            if (userDto != null)
            {
                HttpContext.Session.SetObject("user", userDto);
            }
            else
            {
                // Sayfaya hata göstert
            }
       
            return View();
        }

     
    }
}
