﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.ProjectBaseEntity
{
    public class Comment
    {
        public int ID { get; set; }
        public int ModelEmployeeId { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }



        //relations-------
        public virtual ModelEmployee ModelEmployee { get; set; }
    }
}
