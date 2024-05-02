using Microsoft.AspNetCore.Identity;
using MinhaPrimeiraApi.Business.Services.Abstractions.Gym;
using MinhaPrimeiraApi.Business.Services.Abstractions.User;
using MinhaPrimeiraApi.Business.Services.Gym;
using MinhaPrimeiraApi.Business.Services.User;
using MinhaPrimeiraApi.Data.Repositories.Abstraction.Gym;
using MinhaPrimeiraApi.Data.Repositories.Abstraction.User;
using MinhaPrimeiraApi.Data.Repositories.Gym;
using MinhaPrimeiraApi.Data.Repositories.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency injections
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IGymRepository, GymRepository>();
builder.Services.AddScoped<IGymService, GymService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
