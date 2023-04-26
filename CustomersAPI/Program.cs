using CustomersAPI.Configuration;
using CustomersAPI.Data;
using CustomersAPI.Models;
using CustomersAPI.Repository;
using CustomersAPI.Repository.MSSQL;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


//DBCONTEXT
builder.Services.AddDbContext<CustomerDBContext>();


//OTHER DEPENDENCY INJECTION SERVICES
builder.Services
    .AddIdentityConfig()
    .AddAuthorizationandAuthentication(builder.Configuration)
    .AddRepoService()
    .AddSwaggerConfig();

builder.Services.AddAutoMapper(typeof(AutoMapperConfig));


var app = builder.Build();

// Configure the HTTP request pipeline.
app.Automigrate();

app.UseSwagger();

app.UseSwaggerUI();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
