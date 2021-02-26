using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model.ProjectBaseDTO
{
    public class PermissionDTO
    {
        public int ID { get; set; }
        //public UserType UserType { get; set; }


        //relations-------
        public virtual List<UserDTO> UserList { get; set; }
    }
}
