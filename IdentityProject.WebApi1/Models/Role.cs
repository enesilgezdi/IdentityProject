namespace IdentityProject.WebApi1.Models;

public sealed class Role : Entity
{
    public string Name { get; set; }

    public List<User> Users { get; set; }
}
