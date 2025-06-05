namespace OpenKunkor.Domain.ValueObject.QuizReview
{
    public sealed class Rate 
    {
        public decimal Value { get; }

        private Rate(decimal value)
        {
            if (value < 0 || value > 5)
                throw new ArgumentOutOfRangeException(nameof(value), "Rate must be between 0 and 5.");
            Value = value;
        }

        public static Rate Of(decimal value) => new Rate(value);

        
    }
}
