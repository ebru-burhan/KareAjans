using KareAjans.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KareAjans.Entity
{
    public class User : BaseEntity
    {
        public int PermissonId { get; set; }

        [MaxLength(40, ErrorMessage ="Kullanıcının adı 40 karakterden fazla olamaz")]
        [MinLength(2, ErrorMessage ="Kullanıcının adı 2 karakterden az olamaz")]
        public string FirstName { get; set; }

        [MaxLength(40, ErrorMessage = "Kullanıcının soyadı 40 karakterden fazla olamaz")]
        [MinLength(2, ErrorMessage = "Kullanıcının soyadı 2 karakterden az olamaz")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //relations-------
        public virtual Permission Permission { get; set; }
    }
}
