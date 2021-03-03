using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class ExpenseTypeDTO
    {
        public int ExpenseTypeID { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }


        //relations-------
        public List<ExpenseDTO> Expenses { get; set; }
    }
}
