using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class CommentDTO
    {
        public int CommentID { get; set; }
        public int ModelEmployeeId { get; set; }
        public string Message { get; set; }



        //relations-------
        public ModelEmployeeDTO ModelEmployee { get; set; }
    }
}
