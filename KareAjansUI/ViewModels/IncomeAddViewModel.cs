using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.ViewModels
{
    public class IncomeAddViewModel
    {
        public IncomeDTO Income { get; set; }
        public List<OrganizationDTO> Organizations { get; set; }
    }
}
