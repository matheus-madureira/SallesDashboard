namespace WebApi.Models;

public sealed class Collaborator
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    
    public string Name { get; private set; }
    
    public string Email { get; private set; }

    private Collaborator(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public static Collaborator Create(string name, string email)
    {
        return new Collaborator(name, email);
    }
}
