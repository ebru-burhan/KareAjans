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
    public class ProfessionalDegreeManager : IProfessionalDegreeService
    {
        private readonly IProfessionalDegreeRepository _professionalDegreeRepository;
        private readonly IMapper _mapper;
        public ProfessionalDegreeManager(IProfessionalDegreeRepository professionalDegreeRepository, IMapper mapper)
        {
            _professionalDegreeRepository = professionalDegreeRepository;
            _mapper = mapper;
        }



        public List<ProfessionalDegreeDTO> GetProfessionalDegrees()
        {
            var professionalDegrees = _professionalDegreeRepository.GetAll();
            return _mapper.Map<List<ProfessionalDegreeDTO>>(professionalDegrees);
        }

        public void AddProfessionalDegree(ProfessionalDegreeDTO dto)
        {
            _professionalDegreeRepository.Add(_mapper.Map<ProfessionalDegree>(dto));
        }

        public void DeleteProfessionalDegree(ProfessionalDegreeDTO dto)
        {
            _professionalDegreeRepository.Delete(_mapper.Map<ProfessionalDegree>(dto));
        }

        public void UpdateProfessionalDegree(ProfessionalDegreeDTO dto)
        {
            _professionalDegreeRepository.Update(_mapper.Map<ProfessionalDegree>(dto));
        }
    }
}
