using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KareAjans.Model
{
    public class CommentDTO
    {
        public int CommentID { get; set; }
        public int ModelEmployeeId { get; set; }

        [Required]
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }



        //relations-------
        public ModelEmployeeDTO ModelEmployee { get; set; }
    }
}
