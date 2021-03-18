using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KareAjans.Entity.Enums
{
    public enum HairColor
    {
        [Display(Name = "Siyah")]
        Black,
        [Display(Name = "Kahverengi")]
        Brown,
        [Display(Name = "Sarı")]
        Blond,
        [Display(Name = "Kumral")]
        Auburn,
        [Display(Name = "Kızıl")]
        Red,
        [Display(Name = "Gri")]
        Gray,
        [Display(Name = "Beyaz")]
        White,
        [Display(Name = "Diğer")]
        Other
    }
}
