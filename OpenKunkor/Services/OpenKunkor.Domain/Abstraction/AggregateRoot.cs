namespace OpenKunkor.Domain.Abstraction
{
    public abstract class AggregateRoot<TId> : IAggregate<TId>
    {
        public TId Id { get; set; }
        private readonly List<IDomainEvent> _domainEvent = new();
        public IReadOnlyCollection<IDomainEvent> DomainEvent => _domainEvent.AsReadOnly();

        protected void AddEvent(IDomainEvent domainEvent)
        {
            _domainEvent.Add(domainEvent);
        }
        protected void ClearDomain()
        {
            _domainEvent.Clear();
        }
    }
}
