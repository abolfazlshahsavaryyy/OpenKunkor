using OpenKunkor.Domain.Arguments;

namespace OpenKunkor.Domain.ValueObject.Content
{
    public class ContentTitle
    {
        public string Value { get; set; }
        public static ContentTitle Of(string value)
        {
            ArgumentException.ThrowIfNullOrEmpty(value);
            CustomArgumentException.ThrowIfNotInRange(value, 5, 100);
            return new ContentTitle
            {
                Value = value
            };
        }
    }
}
