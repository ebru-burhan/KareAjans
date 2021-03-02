using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class OrganizationManager : IOrganizationService
    {
        private readonly IOrganizationRepository _organizationRepository;
        public OrganizationManager(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }



        public List<OrganizationDTO> GetOrganizations()
        {
            throw new NotImplementedException();
        }

        public void AddOrganization(OrganizationDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrganization(OrganizationDTO dto)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrganization(OrganizationDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
