using OpenKunkor.Domain.Abstraction;
using System.Xml.Linq;
namespace OpenKunkor.Domain.Entities;
public class Content:AggregateRoot<Guid>
{

    public string Title { get; set; } = null!;
    public string PhotoUrl { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int LikeCount { get; set; }

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<UserContentLike> LikedByUsers { get; set; } = new List<UserContentLike>();
}
