using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenKunkor.Domain.Entities;

namespace OpenKunkor.Infrastructure.Persistence.Configurations;

public class MessageConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.HasKey(m => m.Id);

        // Value Object: MessageContent
        builder.OwnsOne(m => m.Content, content =>
        {
            content.Property(c => c.Value)
                .HasColumnName("Content")
                .IsRequired()
                .HasMaxLength(1000); // adjust length as needed
        });

        builder.Property(m => m.Username)
            .IsRequired()
            .HasMaxLength(100); // Optional max length

        builder.Property(m => m.Role)
            .IsRequired()
            .HasMaxLength(50); // Optional max length

        // Relationship: Message → Chat (many messages per chat)
        builder.HasOne(m => m.Chat)
            .WithMany(c => c.Messages)
            .HasForeignKey(m => m.ChatId)
            .OnDelete(DeleteBehavior.Cascade);

        // Relationship: Message → User (many messages per user)
        builder.HasOne(m => m.User)
            .WithMany(u => u.Messages)
            .HasForeignKey(m => m.UserId)
            .OnDelete(DeleteBehavior.Restrict); // Avoid cascade delete on user
    }
}
