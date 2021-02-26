using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.ProjectBaseEntity
{
    public class ProfessionalDegree
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal DailyWage { get; set; }



        //relations-------
        public virtual ICollection<ModelEmployee> ModelEmployees { get; set; }
    }
}
