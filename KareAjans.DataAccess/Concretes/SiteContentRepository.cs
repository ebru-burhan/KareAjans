using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.DataAccess.Concretes
{
    public class SiteContentRepository : BaseRepository<SiteContent>, ISiteContentRepository
    {
        public SiteContentRepository(DbContext _context) : base(_context)
        {
        }
    }
}
