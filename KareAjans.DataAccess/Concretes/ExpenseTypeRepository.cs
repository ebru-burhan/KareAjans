using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.DataAccess.Concretes
{
    public class ExpenseTypeRepository : BaseRepository<ExpenseType> ,IExpenseTypeRepository
    {
        public ExpenseTypeRepository(DataContext _context) : base(_context)
        {
        }

        public override ExpenseType Add(ExpenseType entity)
        {
            throw new NotImplementedException("Geliştici hatası. ExpenseTypeRepository'de ekleme işlemi yapılamaz.");
        }

        public override void Delete(ExpenseType entity)
        {
            throw new NotImplementedException("Geliştici hatası. ExpenseTypeRepository'de silme işlemi yapılamaz.");
        }
    }
}
