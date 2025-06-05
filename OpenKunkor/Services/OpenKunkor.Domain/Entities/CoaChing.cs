using OpenKunkor.Domain.Abstraction;
using OpenKunkor.Domain.ValueObject.Coaching;

namespace OpenKunkor.Domain.Entities
{
    public class CoaChing : Entity<CoachingId>
    {
        public StudentUsername StudentUsername { get; private set; }
        public CoachingDescription Description { get; private set; }
        public StudentRate StudentRate { get; private set; }
        public CoachingTime Time { get; private set; }

        private CoaChing() { }

        public static CoaChing Create(
            CoachingId coachingId,
            StudentUsername studentUsername,
            CoachingDescription description,
            StudentRate studentRate,
            CoachingTime time)
        {
            return new CoaChing
            {
                Id=coachingId,
                StudentUsername = studentUsername,
                Description = description,
                StudentRate = studentRate,
                Time = time
            };
        }
    }
}
