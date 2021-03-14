using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.ViewModels
{
    public class ModelEmployeeAddViewModel
    {
        public ModelEmployeeDTO ModelEmployee { get; set; }
        public List<ProfessionalDegreeDTO> ProfessionelDegrees { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
