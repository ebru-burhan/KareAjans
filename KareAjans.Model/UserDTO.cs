using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KareAjans.Model
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public int PermissionId { get; set; }
        [Required(ErrorMessage = "Alanı doldurunuz.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Alanı doldurunuz.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Alanı doldurunuz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Alanı doldurunuz.")]
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        //relations-------
        public PermissionDTO Permission { get; set; }
    }
}
