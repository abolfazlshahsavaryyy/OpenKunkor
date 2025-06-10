using OpenKunkor.Domain.Arguments;

namespace OpenKunkor.Domain.ValueObject.Message
{
    public class MessageContent
    {
        public string Value { get; set; }
        public static MessageContent Of(string value)
        {
            ArgumentException.ThrowIfNullOrEmpty(value);
            CustomArgumentException.ThrowIfNotInRange(value, 0, 255);
            return new MessageContent
            {
                Value = value
            };
        }
    }
}
