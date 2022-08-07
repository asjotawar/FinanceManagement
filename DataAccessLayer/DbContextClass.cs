using System;
using FinanceManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceManagement.DataLayer
{
    public class DbContextClass : DbContext
    {
        public DbSet<Families_DBO> Families { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=/Users/adityasj/Documents/Repos/FinanceManagement/FinanceManagement/DataLayer/FinanceManagement.db");
    }
}