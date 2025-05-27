namespace OpenKunkor.Domain.Abstraction
{
    public interface IDomainEvent:INotification
    {
        public Guid EventId => new Guid();
        public DateTime OccuredOn => DateTime.UtcNow;
        public string EventType => GetType().AssemblyQualifiedName;
    }
}
