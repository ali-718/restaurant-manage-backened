using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant_Manage_Backened.Models;

namespace Restaurant_Manage_Backened.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Other configuration...

            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roles>().HasData(
             new Roles { Id = 1, Name = "Other" },
             new Roles { Id = 2, Name = "Admin" },
             new Roles { Id = 3, Name = "Kitchen" },
             new Roles { Id = 4, Name = "Owner" }
            );

            modelBuilder.Entity<Designation>().HasData(
             new Designation { Id = 1, Name = "Administration" },
             new Designation { Id = 2, Name = "Chef" },
             new Designation { Id = 3, Name = "Waitstaff" },
             new Designation { Id = 4, Name = "Janitor" },
             new Designation { Id = 5, Name = "Dishwasher" },
             new Designation { Id = 6, Name = "Manager" },
             new Designation { Id = 7, Name = "Kitchenhand" }
            );
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Bank> Banks => Set<Bank>();
        public DbSet<Super> Supers => Set<Super>();
        public DbSet<Designation> Designations => Set<Designation>();
        public DbSet<Roles> Roles => Set<Roles>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Ingredients> Ingredients => Set<Ingredients>();
        public DbSet<Inventory> Inventories => Set<Inventory>();
        public DbSet<Menu> Menus => Set<Menu>();
        public DbSet<Orders> Orders => Set<Orders>();
        public DbSet<Shifts> Shifts => Set<Shifts>();
        public DbSet<Tables> Tables => Set<Tables>();
        public DbSet<Reservations> Reservations => Set<Reservations>();
    }
}