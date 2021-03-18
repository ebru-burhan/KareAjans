using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KareAjans.Model
{
    public class OrganizationDTO
    {
        public int OrganizationID { get; set; }
        [Required(ErrorMessage = "Alanı doldurunuz.")]
        public string OrganizationName { get; set; }
        [Required(ErrorMessage = "Alanı doldurunuz.")]
        public DateTime StartingDate { get; set; }
        [Required(ErrorMessage = "Alanı doldurunuz.")]
        public DateTime EndingDate { get; set; }
        public bool IsLocal { get; set; }

        public decimal TotalIncome { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<ModelEmployeeOrganizationDTO> ModelEmployeeOrganizations { get; set; }
        public  List<IncomeDTO> Incomes { get; set; }
    }
}
