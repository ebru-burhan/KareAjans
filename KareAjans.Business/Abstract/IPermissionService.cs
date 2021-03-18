using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IPermissionService : IService
    {
        List<PermissionDTO> GetPermissions();
    }
}
