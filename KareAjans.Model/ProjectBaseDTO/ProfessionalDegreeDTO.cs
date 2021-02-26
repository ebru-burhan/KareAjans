using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model.ProjectBaseDTO
{
    public class ProfessionalDegreeDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal DailyWage { get; set; }



        //relations-------
        public virtual List<ModelEmployeeDTO> ModelEmployeeList { get; set; }
    }
}
