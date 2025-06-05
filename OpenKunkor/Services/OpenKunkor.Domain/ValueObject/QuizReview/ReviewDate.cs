namespace OpenKunkor.Domain.ValueObject.QuizReview
{
    public sealed class ReviewDate 
    {
        public DateTime Value { get; }

        private ReviewDate(DateTime value)
        {
            if (value > DateTime.UtcNow)
                throw new ArgumentException("Review date cannot be in the future.");

            Value = value;
        }

        public static ReviewDate Of(DateTime value) => new ReviewDate(value);

        
    }
}
