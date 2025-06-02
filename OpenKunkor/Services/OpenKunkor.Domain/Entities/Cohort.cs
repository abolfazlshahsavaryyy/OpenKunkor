using OpenKunkor.Domain.Abstraction;
using OpenKunkor.Domain.ValueObject.Cohort;

namespace OpenKunkor.Domain.Entities
{
    public class Cohort : AggregateRoot<CohortId>
    {
        public CohorName Name { get; private set; }
        public int Member { get; private set; }
        public List<PhoneCoach> PhoneCoaches { get; set; } = new List<PhoneCoach>();
        public static Cohort Create(CohorName name)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name.Value);
            return new Cohort
            {
                Name = name,
                Member = 0
            };
            

        }


    }
}
