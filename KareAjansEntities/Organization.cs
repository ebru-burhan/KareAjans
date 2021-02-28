using KareAjans.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity
{
    public class Organization : BaseEntity
    {
        public int OrganizationID { get; set; }
        public string OrganizationName { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public bool IsLocal { get; set; }

        // relations---------
        public virtual ICollection<ModelEmployeeOrganization> ModelEmployeeOrganizations { get; set; }
    }
}
