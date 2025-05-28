public sealed class AskTime
{
    public DateTime Value { get; }

    private AskTime(DateTime value)
    {
        Value = value;
    }

    public static AskTime Of(DateTime value)
    {
        if (value > DateTime.UtcNow)
            throw new ArgumentException("AskTime cannot be in the future.");

        return new AskTime(value);
    }

    public bool IsRecent(TimeSpan within) => DateTime.UtcNow - Value < within;

    public override bool Equals(object? obj) =>
        obj is AskTime other && Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();
}
