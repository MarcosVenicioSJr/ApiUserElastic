using ApiUser.Context;
using ApiUser.Interfaces;
using ApiUser.Repository;
using ApiUser.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("UserDatabase");

builder.Services.AddControllers();
builder.Services.AddDbContext<UserContext>(options =>
{
    options.UseSqlServer(connectionString).LogTo(Console.WriteLine, LogLevel.Information);
});

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserServices>();
builder.Services.AddScoped<UserContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
