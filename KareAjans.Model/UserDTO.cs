﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model.ProjectBaseDTO
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
        public virtual PermissionDTO Permission { get; set; }
    }
}