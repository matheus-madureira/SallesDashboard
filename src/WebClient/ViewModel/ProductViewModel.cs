namespace WebClient.ViewModel;

public sealed record ProductViewModel(
    Guid Id,
    string Name,
    string Price,
    string CreatedAt,
    CollaboratorViewModel Collaborator
);
