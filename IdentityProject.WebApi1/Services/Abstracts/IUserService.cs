using IdentityProject.WebApi1.Models;
using IdentityProject.WebApi1.Models.Dtos.User.Request;
using IdentityProject.WebApi1.Models.Dtos.User.Response;

namespace IdentityProject.WebApi1.Services.Abstracts;

public interface IUserService
{
    List<UserResponseDto> GetAllUser();
    User GetById(int id);
    User Add(AddUserRequestDto user);

    User Update(User user);

    User Delete(int id);

    User GetByEmail(string email);


}
