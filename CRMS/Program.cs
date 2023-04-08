using CRMS.Data;
using CRMS.Models;
using CRMS.Repository;
using CRMS.Repository.MsSQL;
using CRMS.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

using CRMS.Data;
using CRMS.Services;
using CRMS.Services.SqlRepositories;
using Microsoft.AspNetCore.Identity;
using CRMS.Models.Customization;
using CRMS.Services.Contacts_Services;
using CRMS.Services._Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Configure entity framework to connect for a db
builder.Services.AddDbContext<CRMSDbContext>();


builder.Services
    .AddIdentityWithOptions()
    .AddScopedInjections();


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
    pattern: "{controller=User}/{action=Login}/{id?}");

app.Run();

