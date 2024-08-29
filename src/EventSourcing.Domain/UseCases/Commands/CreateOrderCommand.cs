using MediatR;

namespace EventSourcing.Domain.UseCases.Commands;

public class CreateOrderCommand: IRequest<Guid>
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}