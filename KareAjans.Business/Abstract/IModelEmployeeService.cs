using KareAjans.Model.ProjectBaseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IModelEmployeeService : IService
    {

        List<ModelEmployeeDTO> GetComments();
        void AddComment(ModelEmployeeDTO dto);
        void DeleteComment(ModelEmployeeDTO dto);
        void UpdateComment(ModelEmployeeDTO dto);
    }
}
