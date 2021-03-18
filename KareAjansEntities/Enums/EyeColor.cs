using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KareAjans.Entity.Enums
{
    public enum EyeColor
    {
        [Display(Name = "Siyah")]
        Black,
        [Display(Name = "Kahverengi")]
        Brown,
        [Display(Name = "Yeşil")]
        Green,
        [Display(Name = "Mavi")]
        Blue,
        [Display(Name = "Ela")]
        Hazel,
        [Display(Name = "Diğer")]
        Other

    }
}
