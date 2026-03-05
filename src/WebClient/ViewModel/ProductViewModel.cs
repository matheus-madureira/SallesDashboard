namespace WebClient.ViewModel;

public sealed record ProductViewModel(
    Guid Id,
    string Name,
    string Price,
    int Quantity,
    string CreatedAt,
    CollaboratorViewModel Collaborator
);
