using KareAjans.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity
{
    public class Comment : BaseEntity
    {
        public int CommentID { get; set; }
        public int ModelEmployeeId { get; set; }
        public string Message { get; set; }



        //relations-------
        public virtual ModelEmployee ModelEmployee { get; set; }
    }
}
