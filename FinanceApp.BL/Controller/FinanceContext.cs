using FinanceApp.BL.Model;
using System;
using System.Data.Entity;

namespace FinanceApp.BL.Controller
{
    public class FinanceContext : DbContext
    {
        public FinanceContext() : base("FinDB")
        {

        }

        public DbSet<Article> Articles { get; set; }
    }
}
