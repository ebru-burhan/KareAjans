using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.DataAccess.Concretes
{
    public class PermissionRepository : BaseRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(DataContext _context) : base(_context)
        {
        }


        public override Permission Add(Permission entity)
        {
            throw new NotImplementedException("Geliştirici hatası. PermissionRepository'de ekleme işlemi yapılamaz.");
        }

        public override void Update(Permission entity)
        {
            throw new NotImplementedException("Geliştirici hatası. PermissionRepository'de güncelleme işlemi yapılamaz.");
        }

        public override void Delete(Permission entity)
        {
            throw new NotImplementedException("Geliştirici hatası. PermissionRepository'de silme işlemi yapılamaz.");
        }
    }
}
