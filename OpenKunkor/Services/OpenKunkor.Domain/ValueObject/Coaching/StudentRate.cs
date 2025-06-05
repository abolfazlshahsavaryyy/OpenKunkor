namespace OpenKunkor.Domain.ValueObject.Coaching
{
    public sealed class StudentRate 
    {
        public decimal Value { get; }

        private StudentRate(decimal value)
        {
            //rate has to be between 1 to 10
            if (value < 0 || value > 10)
                throw new ArgumentOutOfRangeException(nameof(value), "Student rate must be between 0 and 10.");
            Value = value;
        }

        public static StudentRate Create(decimal value) => new StudentRate(value);

        
    }
}
