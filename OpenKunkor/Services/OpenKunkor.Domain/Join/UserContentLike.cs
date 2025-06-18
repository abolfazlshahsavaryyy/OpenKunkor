namespace OpenKunkor.Domain.Join;
public class UserContentLike
{
    public Guid UserId { get; set; }
    

    public int ContentId { get; set; }
    public Content Content { get; set; } = null!;
}
