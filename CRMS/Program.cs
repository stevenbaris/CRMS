using CRMS.Data;
using CRMS.Models;
using CRMS.Services;
using CRMS.Services.SqlRepositories;

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
