namespace OpenKunkor.Domain.Join;
public class UserChat
{
    public Guid UserId { get; set; }
    

    public int ChatId { get; set; }
    public Chat Chat { get; set; } = null!;
}
