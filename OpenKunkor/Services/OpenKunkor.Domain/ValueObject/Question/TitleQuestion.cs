
namespace OpenKunkor.Domain.ValueObject.Question
{
    public class TitleQuestion:IComparable<TitleQuestion>
    {
        public string Value { get; set; }
        public TitleQuestion(string title)
        {
            this.Value = title;
        }
        public static TitleQuestion Of(string title)
        {
            ArgumentException.ThrowIfNullOrEmpty(title);
            return new TitleQuestion(title);
        }

        public int CompareTo(TitleQuestion? other)
        {
            if(other is null)
            {
                throw new ArgumentNullException(nameof(other));
            }
            return string.Compare(this.Value, other.Value, StringComparison.Ordinal);
        }
        public bool Equals(TitleQuestion other)
        {
            if (other is null) throw new ArgumentNullException(nameof(other));
            return other.Value == this.Value;
        }
    }
    
}
