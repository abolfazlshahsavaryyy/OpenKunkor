using OpenKunkor.Domain.Abstraction;
using OpenKunkor.Domain.ValueObject.Question;
using OpenKunkor.Domain.Arguments;
namespace OpenKunkor.Domain.Entities
{
    public class Question:Entity<QuestionId>
    {
        public TitleQuestion Title { get; private set; }
        public ContentQuestion Content { get; private set; }
        public AskTime AskTime { get; private set; }
        public ViewCount View { get; private set; }

        public static Question Create(TitleQuestion title,ContentQuestion content)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(title.Value);
            ArgumentException.ThrowIfNullOrWhiteSpace(content.Value);
            CustomArgumentException.ThrowIfNotInRange(content.Value, 0, 255);
            CustomArgumentException.ThrowIfNotInRange(title.Value, 0, 50);
            var newQuestion = new Question
            {
                Title = title,
                Content =content,
                AskTime = AskTime.Of(DateTime.UtcNow),
                View = ViewCount.Of(0)
            };
            return newQuestion;
        }
        public void Update(TitleQuestion newTitle,ContentQuestion newContent)
        {
            
            ArgumentException.ThrowIfNullOrWhiteSpace(newTitle.Value);
            ArgumentException.ThrowIfNullOrWhiteSpace(newContent.Value);
            this.Title = newTitle;
            this.Content = newContent;
            
            

        }


    }
}
