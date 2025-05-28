using OpenKunkor.Domain.Abstraction;
using OpenKunkor.Domain.ValueObject.Question;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;

namespace OpenKunkor.Domain.Entities
{
    public class Question:Entity<Guid>
    {
        public TitleQuestion Title { get; set; }
        public ContentQuestion Content { get; set; }
        public AskTime AskTime { get; set; }
        public ViewCount View { get; set; }

        public static Question(string title,string content,DateTime asktime)


    }
}
