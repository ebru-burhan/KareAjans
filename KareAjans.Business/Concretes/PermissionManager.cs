using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class PermissionManager : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;
        public PermissionManager(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }




        public List<PermissionDTO> GetPermissions()
        {
            throw new NotImplementedException();
        }

        public void AddPermission(PermissionDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeletePermission(PermissionDTO dto)
        {
            throw new NotImplementedException();
        }

        public void UpdatePermission(PermissionDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
