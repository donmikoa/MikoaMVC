using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MikoaMVC.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MikoaMVC.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(): base("MyDbContext")
        {

        }
        public DbSet<Customer> Customers { get; set; } // My domain models
        public DbSet<Movie> Movies { get; set; }// My domain models
        public DbSet<MembershipType> MembershipTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
