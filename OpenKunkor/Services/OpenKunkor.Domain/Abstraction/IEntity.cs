namespace OpenKunkor.Domain.Abstraction
{
    public interface IEntity<TId>
    {
        public TId Id { get; set; }
    }
}
