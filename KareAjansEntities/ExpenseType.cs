using KareAjans.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity
{
    public class ExpenseType : BaseEntity
    {
        public int ExpenseTypeID { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }


        //relations-------
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
