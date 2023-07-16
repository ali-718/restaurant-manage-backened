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

        public DbSet<User> Users => Set<User>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Bank> Banks => Set<Bank>();
        public DbSet<Super> Supers => Set<Super>();
        public DbSet<Designation> Designations => Set<Designation>();
        public DbSet<Roles> Roles => Set<Roles>();
    }
}