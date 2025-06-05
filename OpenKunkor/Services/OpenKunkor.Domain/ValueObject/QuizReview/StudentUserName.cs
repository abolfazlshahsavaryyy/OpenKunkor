namespace OpenKunkor.Domain.ValueObject.QuizReview
{
    public sealed class StudentUserName 
    {
        public string Value { get; }

        private StudentUserName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Student username cannot be empty.", nameof(value));

            Value = value.Trim();
        }

        public static StudentUserName Of(string value) => new StudentUserName(value);

        
    }
}
