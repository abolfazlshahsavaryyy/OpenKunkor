using OpenKunkor.Domain.Abstraction;
using System.Xml.Linq;
namespace OpenKunkor.Domain.Entities;
public interface IUser
{
    

    public string FirstName { get; set; } 
    public string LastName { get; set; } 
        
    public string Bio { get; set; } 
    public string ProfileUrl { get; set; }

    public ICollection<Content> Contents { get; set; } 
    public ICollection<Comment> Comments { get; set; } 
    public ICollection<Question> Questions { get; set;}
    public ICollection<Answer> Answers { get; set; } 
    public ICollection<Message> Messages { get; set; } 
    public ICollection<UserContentLike> LikedContents { get; set; }
    public ICollection<UserChat> Chats { get; set; } 
    public ICollection<UserFollow> Following { get; set; }
    public ICollection<UserFollow> Followers { get; set; }
}
