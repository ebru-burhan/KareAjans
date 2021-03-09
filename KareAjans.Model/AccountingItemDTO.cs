using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class AccountingItemDTO
    {
        public string ModelEmployeeName { get; set; }
        public string ProfessionalDegreeTitle { get; set; }
        public byte NumberOfDays { get; set; }
        public bool IsLocal { get; set; }
        public decimal Wage { get; set; }
        public decimal Spent { get; set; }
    }
}
