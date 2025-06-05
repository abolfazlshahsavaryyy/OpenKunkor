namespace OpenKunkor.Domain.ValueObject.Coaching
{
    public sealed class CoachingId 
    {
        public Guid Value { get; }

        private CoachingId(Guid value)
        {
            Value = value;
        }

        public static CoachingId Of(Guid Id) => new CoachingId(Id);

        

        public override string ToString() => Value.ToString();
    }
}
