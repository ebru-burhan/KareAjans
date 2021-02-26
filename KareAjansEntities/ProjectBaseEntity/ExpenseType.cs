using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.ProjectBaseEntity
{
    public class ExpenseType
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }


        //relations-------
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
