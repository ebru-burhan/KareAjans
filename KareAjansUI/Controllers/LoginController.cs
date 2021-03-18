using KareAjans.Business.Abstract;
using KareAjans.Entity.Enums;
using KareAjans.Model;
using KareAjans.UI.ExtensionMethods;
using KareAjans.UI.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KareAjans.UI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        //[HttpPost]
        //public IActionResult Login(LoginViewModel model)
        //{
        //    var userDto = _userService.CheckUser(model.Email, model.Password);

        //    if (userDto != null)
        //    {
        //        //user ı sessiona koyduk profile a aktarcaz
        //        HttpContext.Session.SetObject("user", userDto);
        //    }
        //    else
        //    {
        //        // Sayfaya hata göstert
        //    }
       
        //    return RedirectToAction("Index", "Profile");
        //}




        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var userDto = _userService.CheckUser(model.Email, model.Password);


            if (userDto != null)
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,userDto.UserID.ToString()),
                    new Claim(ClaimTypes.Role,userDto.Permission.UserType.ToString())
                };

                if (userDto.Permission.UserType == UserType.Administrator)
                {//muhasebeci haklarını da verdik admine 
                    claims.Add(new Claim(ClaimTypes.Role, UserType.Accountant.ToString()));
                }

                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaims(claims);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(principal);

                userDto.Permission.Users = null;
                HttpContext.Session.SetObject("user", userDto);

                // SetString using ile geldi, kullanma sebebimiz Razordan GetStringe erişiliyo
                HttpContext.Session.SetString("userType", userDto.Permission.UserType.ToString());

                if (userDto.Permission.UserType == Entity.Enums.UserType.ModelEmployee)
                {
                    return RedirectToAction("Index", "Profile");
                }
                else 
                {
                    return RedirectToAction("Index", "Admin");
                }

            }

            ModelState.AddModelError("", "Kullanici adi veya sifre yanlistir");

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.Remove("user");

            return View("Login");
        }


    }
}
