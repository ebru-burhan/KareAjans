using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class ProfessionalDegreeDTO
    {
        public int ProfessionalDegreeID { get; set; }
        public string Title { get; set; }
        public decimal DailyWage { get; set; }
        public byte DailyPercentage { get; set; }



        //relations-------
        public List<ModelEmployeeDTO> ModelEmployees { get; set; }
    }
}
