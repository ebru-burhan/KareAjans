using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model.ProjectBaseDTO
{
    public class ExpenseTypeDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }


        //relations-------
        public virtual List<ExpenseDTO> ExpenseList { get; set; }
    }
}
