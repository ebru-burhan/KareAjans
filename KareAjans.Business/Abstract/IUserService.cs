using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IUserService : IService
    {
        List<UserDTO> GetUsers();
        void AddUser(UserDTO dto);
        void DeleteUser(UserDTO dto);
        void UpdateUser(UserDTO dto);
    }
}
