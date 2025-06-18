
using OpenKunkor.Domain.Abstraction;
using OpenKunkor.Domain.Entities;
using OpenKunkor.Domain.Join;

namespace OpenKunkor.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public string ProfileUrl { get; set; } = string.Empty;
        public ICollection<Content> Contents { get; set; }
        public ICollection<Comment> Comments { get ; set ; }
        public ICollection<Question> Questions { get ; set ; }
        public ICollection<Answer> Answers { get ; set ; }
        public ICollection<Message> Messages { get ; set ; }
        public ICollection<UserContentLike> LikedContents { get ; set ; }
        public ICollection<UserChat> Chats { get ; set ; }
        public ICollection<UserFollow> Following { get ; set ; }
        public ICollection<UserFollow> Followers { get ; set ; }
        
    }
}
