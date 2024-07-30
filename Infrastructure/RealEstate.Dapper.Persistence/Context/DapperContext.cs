using Microsoft.EntityFrameworkCore;
using RealEstate.Dapper.Domain.Entities;
using System.Reflection;

namespace RealEstate.Dapper.Persistence.Context
{
    public class DapperContext : DbContext
    {
        public DapperContext(DbContextOptions<DapperContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<AboutDetail> AboutDetails { get; set; }
        public DbSet<AboutService> AboutServices { get; set; }
        public DbSet<StepsGrid> StepsGrids { get; set; }
        public DbSet<PopulerLocation> PopulerLocations { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<SubFeature> SubFeatures { get; set; }
        public DbSet<MailSubscribe> mailSubscribes { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
