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
    public class OrganizationManager : IOrganizationService
    {
        private readonly IOrganizationRepository _organizationRepository;
        private readonly IMapper _mapper;
        public OrganizationManager(IOrganizationRepository organizationRepository, IMapper mapper)
        {
            _organizationRepository = organizationRepository;
            _mapper = mapper;
        }



        public List<OrganizationDTO> GetOrganizations()
        {
            var organizations = _organizationRepository.GetAll();
            return _mapper.Map<List<OrganizationDTO>>(organizations);
        }

        public void AddOrganization(OrganizationDTO dto)
        {
            _organizationRepository.Add(_mapper.Map<Organization>(dto));
        }

        public void DeleteOrganization(OrganizationDTO dto)
        {
            _organizationRepository.Delete(_mapper.Map<Organization>(dto));
        }

        public void UpdateOrganization(OrganizationDTO dto)
        {
            _organizationRepository.Update(_mapper.Map<Organization>(dto));
        }
    }
}
