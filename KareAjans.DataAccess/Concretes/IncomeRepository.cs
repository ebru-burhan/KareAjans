﻿using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.DataAccess.Concretes
{
    public class IncomeRepository : BaseRepository<Income>, IIncomeRepository
    {
        public IncomeRepository(DataContext _context) : base(_context)
        {
        }
    }
}
