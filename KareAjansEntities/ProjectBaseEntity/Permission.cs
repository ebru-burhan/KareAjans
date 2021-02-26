using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.ProjectBaseEntity
{
    public class Permission
    {
        public int ID { get; set; }
        public UserType UserType { get; set; }


        //relations-------
        //generic için Icollection
        public virtual ICollection<User> Users { get; set; }
    }
}
