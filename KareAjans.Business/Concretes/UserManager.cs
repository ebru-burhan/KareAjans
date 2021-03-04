using AutoMapper;
using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using KareAjans.Model;
using System;
using System.Collections.Generic;
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

        public void AddUser(UserDTO dto)
        {
            _userRepository.Add(_mapper.Map<User>(dto));
        }

        public void DeleteUser(UserDTO dto)
        {
            _userRepository.Delete(_mapper.Map<User>(dto));
        }

        public void UpdateUser(UserDTO dto)
        {
            _userRepository.Update(_mapper.Map<User>(dto));
        }
    }
}
