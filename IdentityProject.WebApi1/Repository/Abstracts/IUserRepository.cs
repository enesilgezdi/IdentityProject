using IdentityProject.WebApi1.Models;

namespace IdentityProject.WebApi1.Repository.Abstracts;

public interface IUserRepository : IEntityRepository<User>
{
    User GetByEmail(string email);
    List<User> GetAllByUsernameContains(string text);
}
