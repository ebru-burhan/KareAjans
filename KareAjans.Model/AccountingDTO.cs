using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class AccountingDTO
    {
        public decimal Profit { get; set; }
        public decimal PayableFinalTotal { get; set; }
        public decimal WageTotal { get; set; }
        public decimal SpentTotal { get; set; }
        public List<AccountingItemDTO> Items { get; set; }
    }
}
