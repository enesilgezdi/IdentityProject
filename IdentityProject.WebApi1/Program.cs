using IdentityProject.WebApi1.Contexts;
using IdentityProject.WebApi1.Repository.Abstracts;
using IdentityProject.WebApi1.Repository.Concretes;
using IdentityProject.WebApi1.Services.Abstracts;
using IdentityProject.WebApi1.Services.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, EfUserRepository>();
builder.Services.AddScoped<IUserService, UserService>();


builder.Services.AddDbContext<MsSqlContext>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
