using OpenKunkor.Domain.Abstraction;
using System.Xml.Linq;
namespace OpenKunkor.Domain.Entities;
public class User:AggregateRoot<Guid>
{
    

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Username { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Bio { get; set; } = null!;
    public string ProfileUrl { get; set; } = null!;

    public ICollection<Content> Contents { get; set; } = new List<Content>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<Question> Questions { get; set; } = new List<Question>();
    public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    public ICollection<Message> Messages { get; set; } = new List<Message>();
    public ICollection<UserContentLike> LikedContents { get; set; } = new List<UserContentLike>();
    public ICollection<UserChat> Chats { get; set; } = new List<UserChat>();
    public ICollection<UserFollow> Following { get; set; } = new List<UserFollow>();
    public ICollection<UserFollow> Followers { get; set; } = new List<UserFollow>();
}
