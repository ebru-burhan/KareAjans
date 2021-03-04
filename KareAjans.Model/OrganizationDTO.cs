using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class OrganizationDTO
    {
        public int OrganizationID { get; set; }
        public string OrganizationName { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public bool IsLocal { get; set; }

        public List<ModelEmployeeOrganizationDTO> ModelEmployeeOrganizations { get; set; }
        public  List<IncomeDTO> Incomes { get; set; }
    }
}
