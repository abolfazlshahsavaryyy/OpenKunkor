using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenKunkor.Domain.Entities;

namespace OpenKunkor.Infrastructure.Persistence.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(q => q.Id);

            // Value Object: Title
            builder.OwnsOne(q => q.Title, title =>
            {
                title.Property(t => t.Value)
                     .HasColumnName("Title")
                     .IsRequired()
                     .HasMaxLength(300); // adjust as needed
            });

            // Value Object: Content
            builder.OwnsOne(q => q.Content, content =>
            {
                content.Property(c => c.Value)
                       .HasColumnName("Content")
                       .IsRequired()
                       .HasMaxLength(3000); // adjust as needed
            });

            builder.Property(q => q.Username)
                   .IsRequired()
                   .HasMaxLength(100);

            // Relationship: Question → User
            builder.HasOne(q => q.User)
                   .WithMany() // assuming IUser does not have a Questions nav property
                   .HasForeignKey(q => q.UserId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Relationship: Question → Answers
            builder.HasMany(q => q.Answers)
                   .WithOne(a => a.Question)
                   .HasForeignKey(a => a.QuestionId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
