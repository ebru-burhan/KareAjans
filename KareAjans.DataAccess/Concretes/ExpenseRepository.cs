using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.DataAccess.Concretes
{
    public class ExpenseRepository : BaseRepository<Expense> , IExpenseRepository
    {
        
        public ExpenseRepository(DbContext _context) : base(_context)
        {
        }
    }
}
