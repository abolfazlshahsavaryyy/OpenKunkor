using OpenKunkor.Domain.Abstraction;
using OpenKunkor.Domain.ValueObject.Cohort;

namespace OpenKunkor.Domain.Entities
{
    public class Cohort : Entity<CohortId>
    {
        public string Name { get; private set; }
        public int Member { get; private set; }


    }
}
