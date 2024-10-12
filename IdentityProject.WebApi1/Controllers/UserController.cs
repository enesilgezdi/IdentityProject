using IdentityProject.WebApi1.Contexts;
using IdentityProject.WebApi1.Models;
using IdentityProject.WebApi1.Models.Dtos.User.Request;
using IdentityProject.WebApi1.Services.Abstracts;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace IdentityProject.WebApi1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    //MsSqlContext msSqlContext = new MsSqlContext();
    //private static List<User> users = new List<User>()
    //{
    //    new User
    //    {
    //        Id = 1,
    //        Email = "seren@gmail.com",
    //        Password = "deneme123",
    //        Phone = "05654123687",
    //        UserName = "qubitfaruk"
    //    },
    //    new User
    //    {
    //        Id = 2,
    //        Email = "muhammed_kus@gmail.com",
    //        Password = "deneme_123",
    //        Phone = "05412569874",
    //        UserName = "cıstakcıstak"
    //    },
    //       new User
    //    {
    //        Id = 3,
    //        Email = "safa_turizm@gmail.com",
    //        Password = "sarımsak37",
    //        Phone = "05412569884",
    //        UserName = "gastamonulu_baba"
    //    }
    //};

    //[HttpGet("getall")]
    //public List<User> GetUsers()
    //{
    //    return users;
    //}

    //[HttpGet("getbyid")]
    //// http://localhost:5242/api/getbyid/3
    //public IActionResult GetById(int id)
    //{


    //    User user = users.FirstOrDefault(x => x.Id == id);
    //    if (user is null)
    //    {
    //        return NotFound("Aradığınız kullanıcı bulunamadı.");
    //    }

    //    return Ok(user);


    //}

    //[HttpPost("add")]
    //public IActionResult Add([FromBody] User user)
    //{
    //    User? getUserByEmail = users.SingleOrDefault(x => x.Email == user.Email);
    //    if (getUserByEmail is not null)
    //    {
    //        string message = $"Aynı email e ait kullanıcı mevcuttur: {user.Email}";
    //        return BadRequest(message);
    //    }

    //    users.Add(user);
    //    return Ok("Kullanıcı eklendi.");
    //}


    //[HttpDelete("delete")]
    //public IActionResult Delete(string email)
    //{
    //    User? user = users.SingleOrDefault(u => u.Email == email);
    //    if (user is null)
    //    {
    //        return NotFound("Aradığınız email e göre kullanıcı bulunamadı.");
    //    }

    //    users.Remove(user);
    //    return Ok(user);
    //}

    //[HttpPut("Update")]
    //public IActionResult Update([FromQuery] int id, [FromBody] User updated)
    //{
    //    User user = users.FirstOrDefault(x => x.Id == id);
    //    if (user is null)
    //    {
    //        return NotFound("Aradığınız kullanıcı bulunamadı.");
    //    }

    //    int index = users.IndexOf(user);
    //    users.Remove(user);
    //    users.Insert(index, updated);

    //    return Ok("Güncellendi.");

    //}

    private IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }  

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        // insert into Users(...) values (...)
        //msSqlContext.Users.Add(user);
        //msSqlContext.SaveChanges();

        //return Ok(user);

        var result = _userService.GetAllUser();
        return Ok(result);
    }
    // IEntityTypeConfigurationBuilder


    [HttpPost("add")]
    public IActionResult Add(AddUserRequestDto user)
    {
        // select * from users
        var result = _userService.Add(user);
        return Ok(result);
    }

    [HttpGet("getemail")]
    public IActionResult GetByEmail(string email)
    {

        var result = _userService.GetByEmail(email);
        return Ok(result);
    }
}
