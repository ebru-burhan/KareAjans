using KareAjans.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity
{
    public class ModelEmployeeOrganization : BaseEntity
    {
        public int ModelEmployeeId { get; set; }
        public int OrganizationId { get; set; }

        //relations-------
        public virtual ModelEmployee ModelEmployee { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
