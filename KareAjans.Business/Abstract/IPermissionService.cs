using KareAjans.Model.ProjectBaseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IPermissionService : IService
    {
        List<PermissionDTO> GetComments();
        void AddComment(PermissionDTO dto);
        void DeleteComment(PermissionDTO dto);
        void UpdateComment(PermissionDTO dto);
    }
}
