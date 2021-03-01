using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace KareAjans.DataAccess.Concretes
{
    public class OrganizationRepository : BaseRepository<Organization>, IOrganizationRepository
    {
        //base e contexti geçtik
        private readonly DbContext context;

        public OrganizationRepository(DbContext _context) : base(_context)
        {
            context = _context;
        }


        public List<Organization> GetOrganizations(Expression<Func<Organization, bool>> filter = null)
        {
            return filter == null ?
                context.Set<Organization>().ToList() :
                context.Set<Organization>().Where(filter).ToList();

        }
    }
}