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
        public SiteContentRepository(DataContext _context) : base(_context)
        {
        }

        public override SiteContent Add(SiteContent entity)
        {
            throw new NotImplementedException("Geliştirici hatası. SiteContentRepository'de ekleme işlemi yapılamaz.");
        }

        public override void Delete(SiteContent entity)
        {
            throw new NotImplementedException("Geliştirici hatası. SiteContentRepository'de silme işlemi yapılamaz.");
        }      
    }
}
