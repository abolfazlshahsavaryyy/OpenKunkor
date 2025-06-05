namespace OpenKunkor.Domain.ValueObject.Coaching
{
    public sealed class CoachingTime 
    {
        public DateTime Start { get; }
        public DateTime End { get; }
        public TimeSpan TimeSpan { get; }

        private CoachingTime(DateTime start, DateTime end)
        {
            if (end <= start)
                throw new ArgumentException("End time must be after start time.");

            Start = start;
            End = end;
            TimeSpan = end - start;
        }

        public static CoachingTime Create(DateTime start, DateTime end) => new CoachingTime(start, end);

        
    }
}
