using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenKunkor.Domain.Join;

namespace OpenKunkor.Infrastructure.Data.Configuration.ManyToManyConfiguration
{
    class UserChatConfiguration : IEntityTypeConfiguration<UserChat>
    {
        public void Configure(EntityTypeBuilder<UserChat> builder)
        {
            
                builder.HasKey(x => new { x.UserId, x.ChatId });

                // Map to ApplicationUser from Infrastructure
                builder.HasOne<ApplicationUser>() // No nav property in domain
                  .WithMany(a=>a.Chats)
                  .HasForeignKey(uc => uc.UserId)
                  .OnDelete(DeleteBehavior.Cascade);

                builder.HasOne(uc => uc.Chat)
                  .WithMany(c => c.Users)
                  .HasForeignKey(uc => uc.ChatId)
                  .OnDelete(DeleteBehavior.Cascade);
            

        }
    }
}
