using OpenKunkor.Domain.Abstraction;
using OpenKunkor.Domain.ValueObject.Message;

namespace OpenKunkor.Domain.Entities;
public class Message:Entity<Guid>
{

    public MessageContent Content { get; set; } = null!;
    public string Username { get; set; } = null!;
    public string Role { get; set; } = null!;

    public Guid ChatId { get; set; }
    public Chat Chat { get; set; } = null!;

    public Guid UserId { get; set; }
    
}
