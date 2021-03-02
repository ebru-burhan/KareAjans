using KareAjans.Model.ProjectBaseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IProfessionalDegree : IService
    {
        List<ProfessionalDegreeDTO> GetComments();
        void AddComment(ProfessionalDegreeDTO dto);
        void DeleteComment(ProfessionalDegreeDTO dto);
        void UpdateComment(ProfessionalDegreeDTO dto);
    }
}
