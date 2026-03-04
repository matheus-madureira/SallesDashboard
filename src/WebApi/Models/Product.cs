namespace WebApi.Models;

public sealed class Product
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string Name { get; private set; }

    public string Price { get; private set; }

    public string CreatedAt { get; private set; }

    public Collaborator Collaborator { get; private set; }

    private Product(
        string name,
        string price,
        string createdAt,
        Collaborator collaborator)
    {
        Name = name;
        Price = price;
        CreatedAt = createdAt;
        Collaborator = collaborator;
    }

    public static Product Create(
        string name, 
        string price, 
        string createdAt,
        Collaborator collaborator)
    {
        return new Product(name, price, createdAt, collaborator);
    }
}
