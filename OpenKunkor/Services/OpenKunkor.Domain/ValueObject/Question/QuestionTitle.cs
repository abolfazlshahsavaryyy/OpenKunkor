using OpenKunkor.Domain.Arguments;

namespace OpenKunkor.Domain.ValueObject.Question
{
    public class QuestionTitle
    {
        public string Value { get; set; }
        public static QuestionTitle Of(string value)
        {
            ArgumentException.ThrowIfNullOrEmpty(value);
            CustomArgumentException.ThrowIfNotInRange(value, 5, 100);
            return new QuestionTitle
            {
                    Value = value
            };
        }
    }
}
