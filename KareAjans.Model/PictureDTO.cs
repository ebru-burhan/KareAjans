﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model.ProjectBaseDTO
{
    public class PictureDTO
    {
        public int ID { get; set; }
        public int ModelEmployeeId { get; set; }
        public string Url { get; set; }


        //relations-------
        public virtual ModelEmployeeDTO ModelEmployee { get; set; }
    }
}