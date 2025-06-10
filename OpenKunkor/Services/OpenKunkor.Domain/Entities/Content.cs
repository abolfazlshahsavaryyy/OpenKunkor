
namespace OpenKunkor.Domain.Entities;
public class Content:AggregateRoot<Guid>
{

    public ContentTitle Title { get; set; } = null!;
    public ContentPhoto Photo { get; set; } = null!;
    public ContentDescription Description { get; set; } = null!;
    public int LikeCount { get; set; }

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<UserContentLike> LikedByUsers { get; set; } = new List<UserContentLike>();
}
