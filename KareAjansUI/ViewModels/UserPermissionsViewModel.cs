using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.ViewModels
{
    public class UserPermissionsViewModel
    {
        public UserDTO User { get; set; }
        public List<PermissionDTO> Permissions { get; set; }
    }
}
