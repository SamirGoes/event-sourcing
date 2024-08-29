using EventSourcing.Domain.Entities;
using EventSourcing.Domain.Persistence;
using EventSourcing.Domain.UseCases.Queries;
using MediatR;

namespace EventSourcing.Domain.UseCases.Handlers;

public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, Order>
{
    private readonly IEventStore _eventStore;

    public GetOrderByIdQueryHandler(IEventStore eventStore)
    {
        _eventStore = eventStore;
    }

    public Task<Order> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}