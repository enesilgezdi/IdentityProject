using IdentityProject.WebApi1.Models.Dtos.User.Request;

namespace IdentityProject.WebApi1.Models;

public sealed class User : Entity
{
    public string UserName { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public int RoleId { get; set; }
    public Role Role { get; set; }



    public static explicit operator User(AddUserRequestDto dto)
    {
        return new User
        {
            Email = dto.Email,
            Password = dto.Password,
            Phone = dto.Phone,
            UserName = dto.UserName,
            RoleId = dto.RoleId,
        };
    }
}
