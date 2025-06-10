using OpenKunkor.Domain.Arguments;

namespace OpenKunkor.Domain.ValueObject.Comment
{
    public class CommentContent
    {
        public string Value { get; set; } = string.Empty;
        public static CommentContent Of(string value)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(value);
            CustomArgumentException.ThrowIfNotInRange(value, 5, 50);
            return new CommentContent
            {
                Value = value
            };

        }
        
    }
}
