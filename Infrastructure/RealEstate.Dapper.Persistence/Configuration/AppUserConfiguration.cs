using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Persistence.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.UserId);
            builder.HasOne(x => x.AppRole).WithMany(x => x.AppUsers).HasForeignKey(x => x.RoleId);
            builder.HasMany(x => x.SenderMessages).WithOne(x => x.SenderUser).HasForeignKey(x => x.Sender).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.ReceiveMessages).WithOne(x => x.ReceiveUser).HasForeignKey(x => x.Receive).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
