﻿using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IUserService : IService
    {
        List<UserDTO> GetUsers();
        UserDTO AddUser(UserDTO dto);
        void DeleteUser(UserDTO dto);
        void UpdateUser(UserDTO dto);
        UserDTO CheckUser(string email, string password);

        List<UserDTO> GetUsersWithPermission();
        UserDTO GetUserById(int id);

    }
}
