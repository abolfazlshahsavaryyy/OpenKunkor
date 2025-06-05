namespace OpenKunkor.Domain.ValueObject.QuizReview
{
    public sealed class ReviewDescription : ValueObject
    {
        public string Value { get; }

        private ReviewDescription(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Description cannot be empty.", nameof(value));

            Value = value.Trim();
        }

        public static ReviewDescription Of(string value) => new ReviewDescription(value);

        
    }
}
