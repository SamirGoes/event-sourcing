using MediatR;
using EventSourcing.Domain.UseCases.Commands;
using EventSourcing.Domain.Entities;
using EventSourcing.Domain.Events;

namespace EventSourcing.Domain.UseCases.Handlers;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Guid>
{
    public Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = new Order(request.ProductName, request.Quantity, request.Price);

        var @event = new OrderCreatedEvent(order);

        return Task.FromResult(order.Id);
    }
}
