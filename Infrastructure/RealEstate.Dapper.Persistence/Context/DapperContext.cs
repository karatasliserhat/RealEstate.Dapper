using Microsoft.EntityFrameworkCore;
using RealEstate.Dapper.Domain.Entities;
using System.Reflection;

namespace RealEstate.Dapper.Persistence.Context
{
    public class DapperContext:DbContext
    {
        public DapperContext(DbContextOptions<DapperContext> options):base(options)
        {
           
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
