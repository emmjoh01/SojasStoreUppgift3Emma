using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<DepartmentProduct> DepartmentProducts { get; set; }
        public DbSet<ProductIngredient> ProductIngredients { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SojasStoreUppgift3Emma;Integrated Security=True;";
            dbContextOptionsBuilder
                .UseSqlServer(connectionString)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<DepartmentProduct>()
                .HasKey(dp => new { dp.DepartmentId, dp.ProductId });

            modelBuilder.Entity<DepartmentProduct>()
                .HasOne(dp => dp.Department)
                .WithMany(d => d.DepartmentProduct)
                .HasForeignKey(dp => dp.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DepartmentProduct>()
                .HasOne(dp => dp.Product)
                .WithMany(p => p.DepartmentProduct)
                .HasForeignKey(dp => dp.ProductId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<ProductIngredient>()
                .HasKey(pn => new { pn.ProductId, pn.IngredientId });

            modelBuilder.Entity<ProductIngredient>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductIngredients)
                .HasForeignKey(pi => pi.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductIngredient>()
                .HasOne(pi => pi.Ingredient)
                .WithMany(i => i.ProductIngredients)
                .HasForeignKey(pi => pi.IngredientId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Campaign>()
                .HasKey(c => c.CampaignId);

            modelBuilder.Entity<Employee>()
                .HasIndex(p => p.SSN)
                .IsUnique();

            modelBuilder.Entity<Email>()
                .HasKey(e => new { e.EmployeeEmail, e.EmployeeId });

            modelBuilder.Entity<PhoneNumber>()
                .HasKey(p => new { p.EmployeePhoneNumber, p.EmployeeId });


            modelBuilder
                .Seed();
        }
    }
}
