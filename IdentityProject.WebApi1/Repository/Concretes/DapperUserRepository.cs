using IdentityProject.WebApi1.Models;
using IdentityProject.WebApi1.Repository.Abstracts;

namespace IdentityProject.WebApi1.Repository.Concretes;

public class DapperUserRepository : IUserRepository
{
    public User? GetById(int id)
    {
        throw new NotImplementedException();
    }


    public User Add(User user)
    {
        throw new NotImplementedException();
    }

    public User Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<User> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<User> GetAllByUsernameContains(string text)
    {
        throw new NotImplementedException();
    }

    public User GetByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public User Update(User user)
    {
        throw new NotImplementedException();
    }
}
