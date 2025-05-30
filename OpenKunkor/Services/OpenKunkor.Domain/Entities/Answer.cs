using OpenKunkor.Domain.Abstraction;
using OpenKunkor.Domain.Arguments;
using OpenKunkor.Domain.ValueObject.Answer;

namespace OpenKunkor.Domain.Entities
{
    public class Answer:Entity<Guid>
    {
        public ContentAnswer content { get; set; }
        public AnswerTime AnswerTime { get; set; }
        public ViewCount View { get; set; }
        public static Answer Create(ContentAnswer content)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(content.Value);
            CustomArgumentException.ThrowIfNotInRange(content.Value, 0, 255);
            return new Answer
            {
                content = content,
                AnswerTime = AnswerTime.Of(DateTime.UtcNow),
                View = ViewCount.Of(0)
            };
        }
        public void Update(ContentAnswer content)
        {
            this.content = content;
        }

    }
}
