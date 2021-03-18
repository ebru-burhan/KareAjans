using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KareAjans.Entity.Enums
{
    public enum Gender
    {
        [Display(Name = "Erkek")]
        Male,
        [Display(Name = "Kadın")]
        Female      
    }
}
