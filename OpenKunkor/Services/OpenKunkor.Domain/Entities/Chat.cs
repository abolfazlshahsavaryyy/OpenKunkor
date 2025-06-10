
public class Chat:AggregateRoot<Guid>
{
    

    public ChatName ChatName { get; set; } = null!;

    public ICollection<Message> Messages { get; set; } = new List<Message>();
    public ICollection<UserChat> Users { get; set; } = new List<UserChat>();
}
