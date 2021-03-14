using AutoMapper;
using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserManager(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }



        public List<UserDTO> GetUsers()
        {
            var users = _userRepository.GetAll();
            return _mapper.Map<List<UserDTO>>(users);
        }

        public UserDTO AddUser(UserDTO dto)
        {
            User addedUser = _userRepository.Add(_mapper.Map<User>(dto));
            return _mapper.Map<UserDTO>(addedUser);
        }

        public void DeleteUser(UserDTO dto)
        {
            _userRepository.Delete(_mapper.Map<User>(dto));
        }

        public void UpdateUser(UserDTO dto)
        {
            _userRepository.Update(_mapper.Map<User>(dto));
        }


        public UserDTO CheckUser(string email, string password)
        {
            var user = _userRepository.Get(x => x.Email == email && x.Password == password).FirstOrDefault();
            if (user != null)
            {
                return _mapper.Map<UserDTO>(user);
            }
            return null;

        }


        public List<UserDTO> GetUsersWithPermission()
        {
            var users = _userRepository.GetIncluded(x => x.Permission);
            return _mapper.Map<List<UserDTO>>(users);
        }

        public UserDTO GetUserById(int id)
        {
            var user = _userRepository.Get(x => x.UserID == id).FirstOrDefault();

            return _mapper.Map<UserDTO>(user);
        }
    }
}
