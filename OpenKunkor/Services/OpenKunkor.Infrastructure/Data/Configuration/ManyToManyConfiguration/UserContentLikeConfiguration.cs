using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenKunkor.Domain.Join;

namespace OpenKunkor.Infrastructure.Data.Configuration.ManyToManyConfiguration
{
    public class UserContentLikeConfiguration : IEntityTypeConfiguration<UserContentLike>
    {
        public void Configure(EntityTypeBuilder<UserContentLike> builder)
        {
            builder.HasKey(ucl => new { ucl.UserId, ucl.ContentId });

            builder.HasOne<ApplicationUser>()
                .WithMany(u => u.LikedContents)
                .HasForeignKey(lc => lc.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ucl => ucl.Content)
                .WithMany(c => c.LikedByUsers)
                .HasForeignKey(ucl => ucl.ContentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
