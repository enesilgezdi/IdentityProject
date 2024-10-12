using IdentityProject.WebApi1.Models;
using IdentityProject.WebApi1.Models.Dtos.User.Request;
using IdentityProject.WebApi1.Models.Dtos.User.Response;
using IdentityProject.WebApi1.Repository.Abstracts;
using IdentityProject.WebApi1.Services.Abstracts;

namespace IdentityProject.WebApi1.Services.Concretes;

public class UserService : IUserService
{
    private IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository  = userRepository;
    }

    public User Add(AddUserRequestDto dto)
    {
        User user = (User)dto;
        User crated = _userRepository.Add(user);
        return crated;
    }

    public User Delete(int id)
    {
        User user = _userRepository.Delete(id);
        return user;
    }

    public List<UserResponseDto> GetAllUser()
    {
        return _userRepository.GetAll().Select(x=>(UserResponseDto)x).ToList();

    }

    public User GetByEmail(string email)
    {
        User user = _userRepository.GetByEmail(email);
        return user;
    }

    public User GetById(int id)
    {
        User user = _userRepository.GetById(id);
        return user;
    }

    public User Update(User user)
    {
        User updated = _userRepository.Update(user);
        return updated;
    }
}
