using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiCoreCustomerProject.Models {

    public class CustDbContext : DbContext {

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        public CustDbContext(DbContextOptions<CustDbContext> context) : base(context) { } //angle brackets is class type. delegating to db context constructor


        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Employee>(entity => {

                entity.HasIndex(e => e.Username)
                        .HasName("IDX_Username")
                        .IsUnique();

            });

        }
    }
}
