using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.ProjectBaseEntity
{
    public class Expense
    {
        public int ID { get; set; }
        public int ExpenseTypeId { get; set; }


        //relations-------
        public virtual ExpenseType ExpenseType { get; set; }
    }
}
