using Microsoft.EntityFrameworkCore;
using NeoSoft.Infrastructure.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoSoft.Infrastructure.EF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<EmployeeMaster> EmployeeMaster { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<City> City { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeMaster>()
            .Property(e => e.EmployeeCode)
            .HasComputedColumnSql("RIGHT('00' + CAST(Row_Id AS VARCHAR(8)), 8)");
        }
    }
}
