using CRMS.Data;
using CRMS.Models;
using CRMS.Services;
using CRMS.Services.SqlRepositories;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CRMSDbContext>()
                .AddScoped<IRepository<AppointmentPurpose>, PurposeRepo>()
                .AddScoped<IRepository<Effectivity>, EffectivityRepo>()
                .AddScoped<IRepository<EngagementType>, EngagementTypeRepo>()
                .AddScoped<IRepository<CommunicationMethod>, CommunicationMethodRepo>()
                .AddScoped<IRepository<LeadStatus>, LeadStatusRepo>()
                .AddScoped<IRepository<Source>, SourcesRepo>();

builder.Services.AddIdentity<ApplicationUser, IdentityRole<Guid>>()
                .AddEntityFrameworkStores<CRMSDbContext>()
                .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequiredLength = 5;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = true;
    options.Password.RequiredUniqueChars = 0;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employees}/{action=Index}/{id?}");

app.Run();
