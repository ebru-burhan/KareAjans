using KareAjans.Entity.Abstracts;
using KareAjans.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity
{
    public class Permission : BaseEntity
    {
        public int PermissionID { get; set; }
        public UserType UserType { get; set; }


        //relations-------
        public ICollection<User> Users { get; set; }
    }
}
