using CRMS.Data;
using CRMS.Models;
using CRMS.Repository;
using CRMS.Repository.MsSQL;
using CRMS.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Configure entity framework to connect for a db
builder.Services.AddDbContext<CRMSDbContext>();
//builder.Services.AddScoped<IUserRepository, UserDBRepository>();
//builder.Services.AddScoped<IRoleRepository, RoleDBRepository>();

//Configure Identity Framework
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<CRMSDbContext>();
//Configuration cutomization for password
//builder.Services.Configure<IdentityOptions>(options =>
//{
//    options.Password.RequiredLength = 1;
//    options.Password.RequireNonAlphanumeric = false;
//    options.Password.RequireDigit = false;
//    options.Password.RequiredUniqueChars = 0;
//    options.Password.RequireLowercase = false;
//    options.Password.RequireUppercase = false;
//});

builder.Services.AddScoped<IUserRepository, UserDBRepository>();
builder.Services.AddScoped<IRoleRepository, RoleDBRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
// Enable the identity framework for login all other pages by default
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

