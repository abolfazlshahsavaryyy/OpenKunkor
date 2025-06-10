

public class Question:AggregateRoot<Guid>
{
    

    public QuestionTitle Title { get; set; } = null!;
    public QuestionContent Content { get; set; } = null!;
    public string Username { get; set; } = null!;

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public ICollection<Answer> Answers { get; set; } = new List<Answer>();
}
