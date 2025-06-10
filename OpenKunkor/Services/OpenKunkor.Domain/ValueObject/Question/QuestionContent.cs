using OpenKunkor.Domain.Arguments;

namespace OpenKunkor.Domain.ValueObject.Question
{
    public class QuestionContent
    {
        public string Value { get; set; }
        public static QuestionContent Of(string value)
        {
            ArgumentException.ThrowIfNullOrEmpty(value);
            CustomArgumentException.ThrowIfNotInRange(value, 10, 255);
            return new QuestionContent
            {
                Value = value
            };
        }
    }
}
