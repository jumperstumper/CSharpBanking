using CSharpBanking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBanking
{
    public class ApplicationDbContext : DbContext
    {
        private const string connectionString = "Server=LAPTOP-3CV39V3K;Database=c#Banking;Trusted_Connection=True;MultipleActiveResultSets=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Customer>().HasKey(b => b.Id);
            //modelBuilder.Entity<Customer>()
            //    .HasOne(z => z.BankAccount).WithOne(z => z.Customer).HasForeignKey<Customer>("BankAccount_Id");

            modelBuilder.Entity<BankAccount>().HasKey(b => b.Id);
            modelBuilder.Entity<BankAccount>()
                .HasOne(z => z.Customer).WithOne(z => z.BankAccount).HasForeignKey<Customer>("Customer_Id");

        }

        
    }
}
