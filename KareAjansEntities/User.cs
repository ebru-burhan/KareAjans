using KareAjans.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KareAjans.Entity
{
    public class User : BaseEntity
    {
        public int UserID { get; set; }
        public int PermissionId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //relations-------
        public Permission Permission { get; set; }
    }
}
