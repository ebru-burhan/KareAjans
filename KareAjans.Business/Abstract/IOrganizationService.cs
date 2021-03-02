using KareAjans.Model.ProjectBaseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IOrganizationService : IService
    {
        List<OrganizationDTO> GetComments();
        void AddComment(OrganizationDTO dto);
        void DeleteComment(OrganizationDTO dto);
        void UpdateComment(OrganizationDTO dto);
    }
}
