using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Domain.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x => x.Employee).WithMany(x => x.Products).HasForeignKey(x => x.EmployeeId);
            builder.HasMany(x => x.ProductDetails).WithOne(x => x.Product).HasForeignKey(x => x.ProductId);
        }
    }
}
