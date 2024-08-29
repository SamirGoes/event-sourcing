namespace EventSourcing.Domain.Events;

public class Event
{
    public Guid Id { get; protected set;}
    public DateTime CreatedAt { get; } = DateTime.Now;
}