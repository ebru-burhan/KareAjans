using KareAjans.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity
{
    public class Expense : BaseEntity
    {
        public int ExpenseID { get; set; }
        public int ExpenseTypeId { get; set; }
        //public int ModelEmployeeOrganizationId { get; set; }

        public decimal Amount { get; set; }
        //relations-------
        public virtual ExpenseType ExpenseType { get; set; }
        public virtual ModelEmployeeOrganization ModelEmployeeOrganization { get; set; }
    }
}
