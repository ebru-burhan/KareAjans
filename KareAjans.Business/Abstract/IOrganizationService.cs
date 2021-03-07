using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IOrganizationService : IService
    {
        List<OrganizationDTO> GetOrganizations();
        void AddOrganization(OrganizationDTO dto);
        void DeleteOrganization(OrganizationDTO dto);
        void UpdateOrganization(OrganizationDTO dto);

        OrganizationDTO GetOrganizationById(int id);

        List<OrganizationDTO> GetOrganizationsWithIncomes();

    }
}
