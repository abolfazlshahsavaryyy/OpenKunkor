using OpenKunkor.Domain.Arguments;

namespace OpenKunkor.Domain.ValueObject.Cohort
{
    public class CohortId
    {
        public Guid Value { get; set; }
        public CohortId(Guid value)
        {
            this.Value = value;
        }
        public static CohortId Of(Guid Id)
        {
            CustomArgumentException.ThrowIfIdIsNull(Id);
            var res = new CohortId(Id);
            return res;
        }
    }
}
