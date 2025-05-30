namespace OpenKunkor.Domain.ValueObject.Answer
{
    public class AnswerTime
    {
        public DateTime Value { get; set; }
        public AnswerTime(DateTime value)
        {
            this.Value = value;
        }
        public static AnswerTime Of(DateTime value)
        {
            if (value > DateTime.UtcNow)
                throw new ArgumentException("AskTime cannot be in the future.");

            return new AnswerTime(value);
        }

        public bool IsRecent(TimeSpan within) => DateTime.UtcNow - Value < within;

        public override bool Equals(object? obj) =>
            obj is AnswerTime other && Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

    }
}
