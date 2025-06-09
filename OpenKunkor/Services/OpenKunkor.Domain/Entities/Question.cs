using OpenKunkor.Domain.Abstraction;

public class Question:AggregateRoot<Guid>
{
    

    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public string Username { get; set; } = null!;

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public ICollection<Answer> Answers { get; set; } = new List<Answer>();
}
