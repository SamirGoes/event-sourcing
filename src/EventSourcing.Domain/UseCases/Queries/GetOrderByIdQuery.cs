using EventSourcing.Domain.Entities;
using MediatR;

namespace EventSourcing.Domain.UseCases.Queries;

public class GetOrderByIdQuery : IRequest<Order>
{
    public Guid Id{ get; set; }
}