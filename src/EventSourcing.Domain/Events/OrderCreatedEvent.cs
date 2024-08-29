using EventSourcing.Domain.Entities;

namespace EventSourcing.Domain.Events;

public class OrderCreatedEvent : Event
{
    public OrderCreatedEvent(Order order)
    {
        Id = Guid.NewGuid();
        Order = order;
    }

    public Order Order{ get; private set; }
}