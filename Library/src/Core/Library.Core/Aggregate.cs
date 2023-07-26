namespace Library.Core;

public class Aggregate
{
    public List<IDomainEvent> DomainEvents { get; } = new();
}