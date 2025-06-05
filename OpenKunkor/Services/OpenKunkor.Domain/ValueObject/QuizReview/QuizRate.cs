namespace OpenKunkor.Domain.ValueObject.QuizReview
{
    public sealed class QuizRate 
    {
        public decimal Value { get; }

        private QuizRate(decimal value)
        {
            if (value < 0 || value > 100)
                throw new ArgumentOutOfRangeException(nameof(value), "QuizRate must be between 0 and 100.");
            Value = value;
        }

        public static QuizRate Of(decimal value) => new QuizRate(value);

        
    }
}
