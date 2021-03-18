using KareAjans.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.ViewModels
{
    public class ModelEmployeeAddViewModel
    {
        public ModelEmployeeDTO ModelEmployee { get; set; }
        public List<ProfessionalDegreeDTO> ProfessionelDegrees { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required(ErrorMessage = "Resim yükleyiniz")]
        public IFormFile Picture { get; set; }
    }
}
