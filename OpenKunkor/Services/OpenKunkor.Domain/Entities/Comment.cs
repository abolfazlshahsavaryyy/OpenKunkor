namespace OpenKunkor.Domain.Entities;
public class Comment:Entity<Guid>
{
    

    public CommentContent Content { get; set; } = null!;
    public string Username { get; set; } = null!;
    public string Role { get; set; } = null!;

    public Guid UserId { get; set; }
    

    public int ContentId { get; set; }
    public Content ContentItem { get; set; } = null!;

    public int? ParentCommentId { get; set; }
    public Comment? ParentComment { get; set; }
    public ICollection<Comment> Replies { get; set; } = new List<Comment>();
}
