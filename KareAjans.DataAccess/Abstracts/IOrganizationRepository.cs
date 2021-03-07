using KareAjans.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KareAjans.DataAccess.Abstracts
{
    public interface IOrganizationRepository : IRepository<Organization>
    {
        // service de to list ile alıcaz listi
        ///List<Organization> GetOrganizations(Expression<Func<Organization , bool>> filter = null);

    }

    /*
    // x => x.OrganizationID == 1
    public bool FilterOrganizations(Organization x, int id)
    {
        if (x.OrganizationID == id)
        {
            return true;
        }

        return false;
    }
    */
}
