using KareAjans.Model.ProjectBaseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IUserService : IService
    {
        List<UserDTO> GetComments();
        void AddComment(UserDTO dto);
        void DeleteComment(UserDTO dto);
        void UpdateComment(UserDTO dto);
    }
}
