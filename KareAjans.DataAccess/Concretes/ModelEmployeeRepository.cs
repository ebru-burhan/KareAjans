using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.DataAccess.Concretes
{
    public class ModelEmployeeRepository : BaseRepository<ModelEmployee>, IModelEmployeeRepository
    {
        public ModelEmployeeRepository(DbContext _context) : base(_context)
        {
        }
    }
}
