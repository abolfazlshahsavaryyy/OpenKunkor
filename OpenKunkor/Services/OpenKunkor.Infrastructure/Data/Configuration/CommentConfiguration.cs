using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenKunkor.Domain.Entities;

namespace OpenKunkor.Infrastructure.Persistence.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(c => c.Id);

        // Configure value object: CommentContent (assumes it has a Value string property)
        builder.OwnsOne(c => c.Content, cc =>
        {
            cc.Property(c => c.Value)
                .HasColumnName("Content")
                .IsRequired()
                .HasMaxLength(1000); // You can adjust this limit as needed
        });

        builder.Property(c => c.Username)
            .IsRequired()
            .HasMaxLength(100); // Optional limit

        builder.Property(c => c.Role)
            .IsRequired()
            .HasMaxLength(50); // Optional limit

        // Relationships

        builder.HasOne(c => c.User)
            .WithMany() // Assuming IUser does not have a Comments collection
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.ContentItem)
            .WithMany() // Assuming Content does not have a Comments collection
            .HasForeignKey(c => c.ContentId)
            .OnDelete(DeleteBehavior.Cascade);

        // Self-referencing: ParentComment → Replies
        builder.HasOne(c => c.ParentComment)
            .WithMany(c => c.Replies)
            .HasForeignKey(c => c.ParentCommentId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete loops
    }
}
