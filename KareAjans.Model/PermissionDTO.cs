using KareAjans.Entity;
using KareAjans.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class PermissionDTO
    {
        public int PermissionID { get; set; }
        public UserType UserType { get; set; }


        //relations-------
        public List<UserDTO> Users { get; set; }
    }
}
