using KareAjans.Entity.ProjectBaseEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.DataAccess
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0H5CDO1\\SQLEXPRESS;Database=KareAjans;Integrated Security=true");
        }

        public virtual DbSet<ModelEmployee> ModelEmployees { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<ProfessionalDegree> ProfessionalDegrees { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }  
        public virtual DbSet<ExpenseType> ExpenseTypes { get; set; }

        //-------------
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Permission> Permissons { get; set; }

    }
}
