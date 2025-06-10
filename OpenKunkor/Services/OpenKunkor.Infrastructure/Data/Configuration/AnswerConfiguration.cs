using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenKunkor.Domain.Entities;

namespace OpenKunkor.Infrastructure.Data.Configuration
{
    class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(a => a.Id);
            builder.OwnsOne(a => a.Content, content =>
            {
                content.Property(c => c.Value)
                .HasColumnName("Content")
                .HasMaxLength(255)
                .IsRequired();
            });
            builder.Property(a => a.Username)
               .IsRequired()
               .HasMaxLength(100);

            builder.Property(a => a.Role)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasOne(a => a.Question)
               .WithMany(q => q.Answers)
               .HasForeignKey(a => a.QuestionId)
               .OnDelete(DeleteBehavior.Cascade); // or Restrict if needed

            builder.HasOne(a => a.User)
                   .WithMany(u => u.Answers)
                   .HasForeignKey(a => a.UserId)
                   .OnDelete(DeleteBehavior.Cascade); // or Cascade
        }
    }
}
