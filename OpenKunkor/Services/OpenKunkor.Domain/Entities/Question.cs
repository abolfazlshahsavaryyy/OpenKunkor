

public class Question:AggregateRoot<Guid>
{
    

    public QuestionTitle Title { get; set; } = null!;
    public QuestionContent Content { get; set; } = null!;
    public string Username { get; set; } = null!;

    public Guid UserId { get; set; }
    

    public ICollection<Answer> Answers { get; set; } = new List<Answer>();
}
