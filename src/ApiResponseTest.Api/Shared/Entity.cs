namespace ApiResponseTest.Api.Shared;

public abstract class Entity 
{
    private readonly List<IDomainEvent> _domainEvents = new();

    protected Entity()
    {
    }

    public List<IDomainEvent> DomainEvents => _domainEvents.ToList();

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    protected void Raise(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}