using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class AccountingDTO
    {

        public decimal IncomeTotal { get; set; }
        public decimal Profit { get; set; } //kar
        public decimal GeneralExpensesTotal { get; set; } //2900 genel toplam
        public decimal SalariesTotal { get; set; }  //2700
        public decimal ExpensesTotal { get; set; } //200 
        public List<AccountingItemDTO> Items { get; set; }
    }
}
