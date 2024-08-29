namespace EventSourcing.Domain.Entities;

public class Order
{
    public Order(string productName, int quantity, decimal price)
    {
        Id = Guid.NewGuid();
        ProductName = productName;
        Quantity = quantity;
        Price = price;
    }

    public Guid Id { get; private set; }
    public string ProductName { get; private set; }
    public int Quantity { get; private set; }
    public decimal Price { get; private set; }
    
}