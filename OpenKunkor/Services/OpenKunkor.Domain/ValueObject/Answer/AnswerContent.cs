namespace OpenKunkor.Domain.ValueObject.Answer;

public class AnswerContent
{
    public string Value { get; set; }
    public static AnswerContent Of(string value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);
        return new AnswerContent
        {
            Value = value
        };
    }
    public bool IsShortAnswer()
    {
        if (Value.Length < 10)
        {
            return true;
        }
        return false;
    }
}
