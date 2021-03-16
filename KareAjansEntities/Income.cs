using KareAjans.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity
{
    public class Income : BaseEntity
    {
        public int IncomeID { get; set; }
        public int OrganizationId { get; set; }
        public decimal Amount { get; set; }

        //relations------------
        public Organization Organization { get; set; }

    }
}
