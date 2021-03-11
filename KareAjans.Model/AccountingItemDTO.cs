using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class AccountingItemDTO
    {
        public string ModelEmployeeName { get; set; }
        public string ProfessionalDegreeTitle { get; set; }
        public int NumberOfDays { get; set; }
        public bool IsLocal { get; set; }
        public decimal Salary { get; set; }
        public decimal FoodExpense { get; set; }
        public decimal AccommodationExpense { get; set; }
        public decimal ExpenseTotal { get; set; }
    }
}
