using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class UserDTO
    {
        public int ID { get; set; }
        public int PermissonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //relations-------
        public PermissionDTO Permission { get; set; }
    }
}
