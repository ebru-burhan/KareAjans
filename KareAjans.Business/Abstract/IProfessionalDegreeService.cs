using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IProfessionalDegreeService : IService
    {
        List<ProfessionalDegreeDTO> GetProfessionalDegrees();
        void AddProfessionalDegree(ProfessionalDegreeDTO dto);
        void DeleteProfessionalDegree(ProfessionalDegreeDTO dto);
        void UpdateProfessionalDegree(ProfessionalDegreeDTO dto);
    }
}
