using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class ProfessionalDegreeManager : IProfessionalDegreeService
    {
        private readonly IProfessionalDegreeRepository _professionalDegreeRepository;
        public ProfessionalDegreeManager(IProfessionalDegreeRepository professionalDegreeRepository)
        {
            _professionalDegreeRepository = professionalDegreeRepository;
        }



        public List<ProfessionalDegreeDTO> GetProfessionalDegrees()
        {
            throw new NotImplementedException();
        }

        public void AddProfessionalDegree(ProfessionalDegreeDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteProfessionalDegree(ProfessionalDegreeDTO dto)
        {
            throw new NotImplementedException();
        }

        public void UpdateProfessionalDegree(ProfessionalDegreeDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
