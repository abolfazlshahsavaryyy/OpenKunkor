using OpenKunkor.Domain.Arguments;

namespace OpenKunkor.Domain.ValueObject.Chat
{
    public class ChatName
    {
        public string Valeu { get; set; } = string.Empty;
        public static ChatName Of(string value)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(value);
            CustomArgumentException.ThrowIfNotInRange(value, 5, 50);
            return new ChatName
            {
                Valeu = value
            };
        }
    }
}
