using IdentityProject.WebApi1.Contexts;
using IdentityProject.WebApi1.Models;
using IdentityProject.WebApi1.Repository.Abstracts;

namespace IdentityProject.WebApi1.Repository.Concretes;

public class EfUserRepository : IUserRepository
{
    private MsSqlContext _context;

    public EfUserRepository(MsSqlContext context)
    {
        _context = context;
    }
    public User Add(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();

        return user;
    }

    public User Delete(int id)
    {
        User user = GetById(id);
        _context.Users.Remove(user);
        _context.SaveChanges();
        return user;
    }

    public List<User> GetAll()
    {
        return _context.Users.ToList();
    }

    public List<User> GetAllByUsernameContains(string text)
    {
        List<User> users = _context.Users.
            Where(x=> x.UserName.Contains(text , StringComparison.OrdinalIgnoreCase)).ToList();
        return users;
    }

    public User GetByEmail(string email)
    {
        User user = _context.Users.SingleOrDefault(x=>x.Email == email);
        return user;
    }

    public User? GetById(int id)
    {
        User? user = _context.Users.Find(id);
        return user; 
    }

    public User Update(User user)
    {
        _context.Users.Update(user);
        _context.SaveChanges();

        return user;
    }
}
