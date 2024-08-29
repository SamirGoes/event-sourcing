using EventSourcing.Domain.Events;

namespace EventSourcing.Domain.Persistence;

public interface IEventStore
{
    void Save(Event @event);
    IEnumerable<Event> GetEventsById(Guid id);
}