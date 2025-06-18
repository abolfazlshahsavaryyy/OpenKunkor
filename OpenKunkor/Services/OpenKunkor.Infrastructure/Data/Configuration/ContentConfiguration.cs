using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenKunkor.Domain.Entities;

namespace OpenKunkor.Infrastructure.Persistence.Configurations;

public class ContentConfiguration : IEntityTypeConfiguration<Content>
{
    public void Configure(EntityTypeBuilder<Content> builder)
    {
        builder.HasKey(c => c.Id);

        // Value Object: ContentTitle
        builder.OwnsOne(c => c.Title, title =>
        {
            title.Property(t => t.Value)
                .HasColumnName("Title")
                .IsRequired()
                .HasMaxLength(200);
        });

        // Value Object: ContentDescription
        builder.OwnsOne(c => c.Description, desc =>
        {
            desc.Property(d => d.Value)
                .HasColumnName("Description")
                .IsRequired()
                .HasMaxLength(2000);
        });

        // Value Object: ContentPhoto
        builder.OwnsOne(c => c.Photo, photo =>
        {
            photo.Property(p => p.PhotoUrl)
                .HasColumnName("PhotoUrl")
                .IsRequired()
                .HasMaxLength(500);

            photo.Property(p => p.PhotoSize)
                .HasColumnName("PhotoSize")
                .IsRequired();
        });

        // LikeCount
        builder.Property(c => c.LikeCount)
            .IsRequired();

        // Relationship: Content → User
        builder.HasOne<ApplicationUser>()
            .WithMany(u=>u.Contents) // Assuming IUser does not have a navigation property
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.SetNull);

        // Relationship: Content → Comments
        builder.HasMany(c => c.Comments)
            .WithOne(c => c.ContentItem)
            .HasForeignKey(c => c.ContentId)
            .OnDelete(DeleteBehavior.Cascade);

        
    }
}
