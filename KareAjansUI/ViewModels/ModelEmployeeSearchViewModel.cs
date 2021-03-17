using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.ViewModels
{
    public class ModelEmployeeSearchViewModel
    {
        public List<ProfessionalDegreeDTO> ProfessionalDegrees { get; set; }
        public List<ModelEmployeeDetailViewModel> SearchResults { get; set; }

        public List<OrganizationDTO> Organizations { get; set; }

    }
}
