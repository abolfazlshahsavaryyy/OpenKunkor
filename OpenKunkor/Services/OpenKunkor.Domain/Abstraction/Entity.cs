namespace OpenKunkor.Domain.Abstraction
{
    public abstract class Entity<TId> : IEntity<TId>
    {
        public TId Id { get; set; }

    }
}
