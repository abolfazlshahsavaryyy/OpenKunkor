namespace OpenKunkor.Domain.ValueObject.Coaching
{
    public sealed class StudentUsername 
    {
        public string Value { get; }

        private StudentUsername(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Student username cannot be empty.", nameof(value));

            Value = value.Trim();
        }

        public static StudentUsername Create(string value) => new StudentUsername(value);

        

        public override string ToString() => Value;
    }
}
