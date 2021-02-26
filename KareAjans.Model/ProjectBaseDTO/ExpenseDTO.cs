using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model.ProjectBaseDTO
{
    public class ExpenseDTO
    {
        public int ID { get; set; }
        public int ExpenseTypeId { get; set; }


        //relations-------
        public virtual ExpenseTypeDTO ExpenseType { get; set; }
    }
}
