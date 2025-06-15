using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenKunkor.Domain.Entities;
using OpenKunkor.Domain.ValueObject.Chat;

public class ChatConfiguration : IEntityTypeConfiguration<Chat>
{
    public void Configure(EntityTypeBuilder<Chat> builder)
    {
        builder.HasKey(c => c.Id);

        // Configure ChatName as a Value Object (Owned Type)
        builder.OwnsOne(c => c.ChatName, chatName =>
        {
            chatName.Property(cn => cn.Value)
                .HasColumnName("ChatName")
                .IsRequired()
                .HasMaxLength(200); // adjust max length as needed

            // optional: configure backing field if using private set or field
            // chatName.WithOwner();
        });

        // Configure Messages navigation (assumed 1-to-many)
        builder.HasMany(c => c.Messages)
            .WithOne() // You can specify navigation if Message has Chat
            .HasForeignKey("ChatId") // or use explicit FK if Message has ChatId
            .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("Chats");
    }
}
