using BcProje.Entities;
using BcProje.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.DataAccess
{
    public class BcProjeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-AK0MLSE8; Database=BcProjeDatabase; integrated security=True; MultipleActiveResultSets=True;");
        }

        public DbSet<AnotherCompanyProduct>? AnotherCompanyProducts { get; set; }

        public DbSet<Customer>? Customers { get; set; }

        public DbSet<Employee>? Employees { get; set; }

        public DbSet<Product>? Products { get; set; }

        public DbSet<Sale>? Sales { get; set; }

        public DbSet<CustomerProduct>? CustomerProducts { get; set; }

        public DbSet<SaleProduct>? SaleProducts { get; set; }

        public DbSet<EmployeeCustomer>? EmployeeCustomers { get; set; }

        public DbSet<Visit>? Visits { get; set; }

        public DbSet<Report>? Reports { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region ManyToManyRelations
            modelBuilder.Entity<CustomerProduct>().HasKey(cp => new {cp.CustomerId, cp.ProductId});

            modelBuilder.Entity<SaleProduct>().HasKey(sp => new {sp.SaleId, sp.ProductId});

            modelBuilder.Entity<EmployeeCustomer>().HasKey(ec => new { ec.EmployeeId, ec.CustomerId });


            #endregion


            //EagerLoading Codes

            modelBuilder.Entity<Visit>().Navigation(x => x.Customer).AutoInclude();

        }
    }
}
