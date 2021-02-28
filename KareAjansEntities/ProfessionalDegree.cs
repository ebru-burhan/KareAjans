using KareAjans.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity
{
    public class ProfessionalDegree : BaseEntity
    {
        public int ProfessionalDegreeID { get; set; }
        public string Title { get; set; }
        public decimal DailyWage { get; set; }
        public byte DailyPercentage { get; set; }



        //relations-------
        public virtual ICollection<ModelEmployee> ModelEmployees { get; set; }
    }
}
