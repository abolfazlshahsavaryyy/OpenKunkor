namespace OpenKunkor.Domain.ValueObject.Question
{
    public class ContentQuestion
    {
        public string Value { get; set; }
        public ContentQuestion(string content)
        {
            this.Value = content;
        }
        public static ContentQuestion Of(string content)
        {
            ArgumentException.ThrowIfNullOrEmpty(content);
            return new ContentQuestion(content);
        }

        public int CompareTo(ContentQuestion? other)
        {
            if (other is null)
            {
                throw new ArgumentNullException(nameof(other));
            }
            return string.Compare(this.Value, other.Value, StringComparison.Ordinal);
        }
        public bool Equals(ContentQuestion other)
        {
            if (other is null) throw new ArgumentNullException(nameof(other));
            return other.Value == this.Value;
        }
    }
}
