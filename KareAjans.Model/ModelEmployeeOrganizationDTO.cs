using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model
{
    public class ModelEmployeeOrganizationDTO
    {
        public int ModelEmployeeId { get; set; }
        public int OrganizationId { get; set; }

        //relations-------
        public ModelEmployeeDTO ModelEmployee { get; set; }
        public OrganizationDTO Organization { get; set; }
        public List<ExpenseDTO> Expenses { get; set; }
    }
}
