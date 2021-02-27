using KareAjans.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity
{
    public class Picture : BaseEntity
    {
        public int ModelEmployeeId { get; set; }
        public string Url { get; set; }


        //relations-------
        public virtual ModelEmployee ModelEmployee { get; set; }

    }
}
