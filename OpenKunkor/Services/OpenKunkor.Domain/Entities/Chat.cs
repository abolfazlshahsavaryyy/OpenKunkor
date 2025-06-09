using OpenKunkor.Domain.Abstraction;

public class Chat:AggregateRoot<Guid>
{
    

    public string ChatName { get; set; } = null!;

    public ICollection<Message> Messages { get; set; } = new List<Message>();
    public ICollection<UserChat> Users { get; set; } = new List<UserChat>();
}
