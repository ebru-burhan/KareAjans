﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class ExpenseDTO
    {
        public int ID { get; set; }
        public int ExpenseTypeId { get; set; }


        //relations-------
        public ExpenseTypeDTO ExpenseType { get; set; }
    }
}
