using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class ExpenseDTO
    {
        public int ExpenseID { get; set; }
        public int ExpenseTypeId { get; set; }
        public decimal Amount { get; set; }


        //relations-------
        public ExpenseTypeDTO ExpenseType { get; set; }
        public ModelEmployeeOrganizationDTO ModelEmployeeOrganization { get; set; }
    }
}
