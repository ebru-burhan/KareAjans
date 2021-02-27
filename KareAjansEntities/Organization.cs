using KareAjans.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity
{
    public class Organization : BaseEntity
    {
        public string OrganizationName { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }

        // relations---------
        public virtual ICollection<ModelEmployeeOrganization> ModelEmployeeOrganizations { get; set; }
    }
}
