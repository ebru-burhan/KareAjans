using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class PictureDTO
    {
        public int PictureID { get; set; }
        public int ModelEmployeeId { get; set; }
        public string Url { get; set; }


        //relations-------
        public ModelEmployeeDTO ModelEmployee { get; set; }
    }
}
