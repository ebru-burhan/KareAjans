using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.ProjectBaseEntity
{
    public class Picture
    {
        public int ID { get; set; }
        public int ModelEmployeeId { get; set; }
        public string Url { get; set; }


        //relations-------
        public virtual ModelEmployee ModelEmployee { get; set; }

    }
}
