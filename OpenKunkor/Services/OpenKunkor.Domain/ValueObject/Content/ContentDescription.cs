using OpenKunkor.Domain.Arguments;

namespace OpenKunkor.Domain.ValueObject.Content
{
    public class ContentDescription
    {
        public string Value { get; set; }
        public static ContentDescription Of(string value)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(value);
            CustomArgumentException.ThrowIfNotInRange(value, 10, 255);
            return new ContentDescription
            {
                Value = value
            };
        }
    }
}
