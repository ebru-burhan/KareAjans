using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class IncomeDTO
    {
        public int ID { get; set; }
        public int OrganizationId { get; set; }
        public decimal Amount { get; set; }

        public OrganizationDTO Organization { get; set; }
    }
}
