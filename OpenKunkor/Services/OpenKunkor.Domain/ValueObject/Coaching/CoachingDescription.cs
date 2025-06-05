namespace OpenKunkor.Domain.ValueObject.Coaching
{
    public sealed class CoachingDescription 
    {
        public string Value { get; }

        private CoachingDescription(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Description cannot be empty.");

            Value = value.Trim();
        }

        public static CoachingDescription Create(string value) => new CoachingDescription(value);

        
    }
}
