﻿using KareAjans.Business.Abstract;
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
    [UserTypeBasedAuthorize(UserType.Administrator)]

    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IPermissionService _permissionService;
        public UserController(IUserService userService , IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var dtoList = _userService.GetUsersWithPermission();
            return View(dtoList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            // TODO: modelEMployee eklenirken user ı otomatik oluşturduk permission da modelemployee yi kullanıcıya gösterme sonra bak  listeden kaldırmam lazm!! en son bak
            UserPermissionsViewModel model = new UserPermissionsViewModel()
            {
                User = new UserDTO(),
                Permissions = _permissionService.GetPermissions()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(UserPermissionsViewModel model)
        {


            _userService.AddUser(model.User);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
           var dto = _userService.GetUserById(id);
            UserPermissionsViewModel model = new UserPermissionsViewModel()
            {
                User = dto,
                Permissions = _permissionService.GetPermissions()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(UserPermissionsViewModel model)
        {
            
            _userService.UpdateUser(model.User);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            // TODO: servisten alıp tekrrr veriyoz business işi yapıyoz yarın ilk iş parametreyi değiştir
            UserDTO dto = _userService.GetUserById(id);
            _userService.DeleteUser(dto);
            return RedirectToAction(nameof(Index));
        }
    }
}
