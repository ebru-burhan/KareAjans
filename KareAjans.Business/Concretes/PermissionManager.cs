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
    public class PermissionManager : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;
        public PermissionManager(IPermissionRepository permissionRepository, IMapper mapper)
        {
            _permissionRepository = permissionRepository;
            _mapper = mapper;
        }




        public List<PermissionDTO> GetPermissions()
        {
            var permissions = _permissionRepository.GetAll();
            return _mapper.Map<List<PermissionDTO>>(permissions);
        }

        public void AddPermission(PermissionDTO dto)
        {
            _permissionRepository.Add(_mapper.Map<Permission>(dto));
        }

        public void DeletePermission(PermissionDTO dto)
        {
            _permissionRepository.Delete(_mapper.Map<Permission>(dto));
        }

        public void UpdatePermission(PermissionDTO dto)
        {
            _permissionRepository.Update(_mapper.Map<Permission>(dto));
        }
    }
}
