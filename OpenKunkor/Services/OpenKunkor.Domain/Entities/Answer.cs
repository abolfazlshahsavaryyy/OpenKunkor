using OpenKunkor.Domain.Abstraction;

namespace OpenKunkor.Domain.Entities;
public class Answer:Entity<Guid>
{

    public AnswerContent Content { get; set; } = null!;
    public string Username { get; set; } = null!;
    public string Role { get; set; } = null!;

    public Guid QuestionId { get; set; }
    public Question Question { get; set; } = null!;

    public Guid UserId { get; set; }
    
}
