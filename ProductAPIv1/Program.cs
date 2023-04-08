using Microsoft.EntityFrameworkCore;
using ProductAPI.Configuration;
using ProductAPI.Data;
using ProductAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductDbContext>();

builder.Services.AddIdentityConfiguration()
                .AddAuthorizationandAuthentication(builder.Configuration)
                .AddRepoService()
                .AddSwaggerConfig();

builder.Services.AddAutoMapper(typeof(AutoMapperConfig));


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();

app.UseSwaggerUI();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
