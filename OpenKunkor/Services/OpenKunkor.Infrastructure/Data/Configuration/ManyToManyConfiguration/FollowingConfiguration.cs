using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenKunkor.Domain.Join;

namespace OpenKunkor.Infrastructure.Data.Configuration.ManyToManyConfiguration
{
    public class FollowingConfiguration : IEntityTypeConfiguration<UserFollow>
    {
        public void Configure(EntityTypeBuilder<UserFollow> builder)
        {
            builder.HasKey(f => new { f.FollowingId, f.FollowerId });

            builder.HasOne<ApplicationUser>()
                .WithMany(u => u.Followers)
                .HasForeignKey(f => f.FollowerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<ApplicationUser>()
                .WithMany(u => u.Following)
                .HasForeignKey(f => f.FollowingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
