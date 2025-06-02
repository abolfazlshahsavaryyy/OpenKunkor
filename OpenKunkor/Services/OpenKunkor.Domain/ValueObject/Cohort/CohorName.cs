namespace OpenKunkor.Domain.ValueObject.Cohort
{
    public class CohorName
    {
        public string Value { get; set; }
        public static CohorName Of(string name)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);
            return new CohorName
            {
                Value = name
            };
        }
    }
}
