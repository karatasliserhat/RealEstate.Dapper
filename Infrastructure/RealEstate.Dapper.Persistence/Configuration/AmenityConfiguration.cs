using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Persistence.Configuration
{
    public class AmenityConfiguration : IEntityTypeConfiguration<Amenity>
    {
        public void Configure(EntityTypeBuilder<Amenity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.PropertyAmenities).WithOne(x => x.Amenity).HasForeignKey(x => x.AmenityId);
        }
    }
}
