﻿using KareAjans.Entity;
using KareAjans.Entity.Mappings;
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
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Permission> Permissons { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: diğer config classları silip dataAnnotation kullan ya da buraya ekle diğer mapping classalrı
            modelBuilder.ApplyConfiguration(new ModelEmployeeOrganizationMapping());
            modelBuilder.ApplyConfiguration(new CommentMapping());
            modelBuilder.ApplyConfiguration(new ExpenseTypeMapping());
            modelBuilder.ApplyConfiguration(new ModelEmployeeMapping());
            modelBuilder.ApplyConfiguration(new OrganizationMapping());
            modelBuilder.ApplyConfiguration(new PermissionMapping());
            modelBuilder.ApplyConfiguration(new PictureMapping());
            modelBuilder.ApplyConfiguration(new ProfessionalDegreeMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
        }
    }
}