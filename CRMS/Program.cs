using CRMS.Data;
using CRMS.Services._BackgroundServices;
using CRMS.Services._Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Configure entity framework to connect for a db
builder.Services.AddDbContext<CRMSDbContext>(options => options.EnableSensitiveDataLogging());


builder.Services
    .AddIdentityWithOptions()
    .AddScopedInjections()
    .APIBackgroundServices(builder.Configuration);




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.Automigrate();

app.UseStaticFiles();

app.UseRouting();
// Enable the identity framework for login all other pages by default
app.UseAuthentication(); ;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

