namespace WebApi.Models;

public sealed class Product
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string Name { get; private set; }

    public string Price { get; private set; }

    public int Quantity { get; private set; }
    
    public string CreatedAt { get; private set; }

    public Collaborator Collaborator { get; private set; }

    private Product(
        string name,
        string price,
        int quantity,
        string createdAt,
        Collaborator collaborator)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        CreatedAt = createdAt;
        Collaborator = collaborator;
    }

    public static Product Create(
        string name, 
        string price, 
        int quantity,
        string createdAt,
        Collaborator collaborator)
    {
        return new Product(name, price, quantity, createdAt, collaborator);
    }
}
