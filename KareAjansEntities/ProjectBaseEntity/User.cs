using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.ProjectBaseEntity
{
    public class User
    {
        public int ID { get; set; }
        public int PermissonId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //relations-------
        public virtual Permission Permission { get; set; }
    }
}
