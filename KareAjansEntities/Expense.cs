using KareAjans.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity
{
    public class Expense : BaseEntity
    {
        public int ExpenseTypeId { get; set; }
        public int ModelEmployeeOrganizationId { get; set; }


        //relations-------
        public virtual ExpenseType ExpenseType { get; set; }
        public ModelEmployeeOrganization ModelEmployeeOrganization { get; set; }
    }
}
