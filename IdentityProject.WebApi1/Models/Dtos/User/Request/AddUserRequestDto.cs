namespace IdentityProject.WebApi1.Models.Dtos.User.Request;

public class AddUserRequestDto
{
    public string UserName { get; set; }
    public string Email { get; set; }

    public string Password { get; set; }

    public string Phone { get; set; }

     
    public int RoleId { get; set; }
}
