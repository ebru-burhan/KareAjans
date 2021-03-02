using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }



        public List<UserDTO> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void AddUser(UserDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(UserDTO dto)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
