namespace OpenKunkor.Domain.Join;
public class UserContentLike
{
    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public int ContentId { get; set; }
    public Content Content { get; set; } = null!;
}
