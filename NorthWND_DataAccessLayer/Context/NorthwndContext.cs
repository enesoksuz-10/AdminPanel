
using Microsoft.EntityFrameworkCore;
using NorthWND_Models.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWND_DataAccessLayer.Context
{
    public class NorthwndContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connection String:
            optionsBuilder.UseSqlServer($"Server =Enes;Database=NORTHWND;Trusted_Connection=True;");
        }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Supplier> Suppliers{ get; set; }
        public DbSet<Sehir> Sehirler{ get; set; }
        public DbSet<Ilce> Ilceler { get; set; }
    


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(x => x.Manager)
                .WithMany(k => k.SubEmployees)
                .HasForeignKey(x => x.ReportsTo);
        }
    }


}
