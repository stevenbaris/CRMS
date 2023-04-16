using CRMS.Data;
using CRMS.Models;
using CRMS.Models.Customization;
using CRMS.Models.Records;
using CRMS.Services._BackgroundServices;
using CRMS.Services._BackgroundServices.Token;
using CRMS.Services.Account_Services;
using CRMS.Services.Contacts_Services;
using CRMS.Services.Products_Services;
using CRMS.Services.Record_Services;
using CRMS.Services.Records;
using CRMS.Services.SqlRepositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using NuGet.Protocol;

namespace CRMS.Services._Config
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddIdentityWithOptions(this IServiceCollection Services)
        {
            Services.AddIdentity<ApplicationUser, IdentityRole<Guid>>()
                .AddEntityFrameworkStores<CRMSDbContext>()
                .AddDefaultTokenProviders();

            Services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 5;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = true;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
            });
            return Services;
        }

        public static IServiceCollection AddScopedInjections(this IServiceCollection Services)
        {
            Services
                    //ACCOUNT
                    .AddScoped<IUserRepository, UserDBRepository>()
                    .AddScoped<IRoleRepository, RoleDBRepository>()
                    .AddScoped<IUnitOfWork, UnitOfWork>()

                    //CUSTOMIZATION
                    .AddScoped<IRepository<AppointmentPurpose>, PurposeRepo>()
                    .AddScoped<IRepository<Effectivity>, EffectivityRepo>()
                    .AddScoped<IRepository<EngagementType>, EngagementTypeRepo>()
                    .AddScoped<IRepository<CommunicationMethod>, CommunicationMethodRepo>()
                    .AddScoped<IRepository<LeadStatus>, LeadStatusRepo>()
                    .AddScoped<IRepository<Source>, SourcesRepo>()

                    //CONTACTS
                    .AddScoped<IContactRepository, ContactRepo>()

                    //RECORDS
                    .AddScoped<IRepository<Appointments>, AppointmentsRepo>()
                    .AddScoped<IRepository<Engagement>, EngagementRepo>()

                                     ;

            return Services;
        }
        public static IServiceCollection APIBackgroundServices(
            this IServiceCollection Services, 
            IConfiguration _configuration)
        {
            Services
                   .AddHttpClient()

                   //.AddSingleton<ITokenStorage, InMemoryTokenStorage>()
                   .AddTransient<IRepository<Product>, ProductsRepo>()
                   
                   .AddScoped<IProductConfidentialClientApplication>(provider => 
                   {
                       var clientId = _configuration["Oath2Product:ClientId"];
                       var clientSecret = _configuration["Oath2Product:Secret"];
                       var tenantId = _configuration["Oath2Product:TenantId"];
                       var authority = $"https://login.microsoftonline.com/{tenantId}";


                       var app = ConfidentialClientApplicationBuilder
                           .Create(clientId)
                           .WithClientSecret(clientSecret)
                           .WithAuthority(new Uri(authority))
                           .Build();

                       return (IProductConfidentialClientApplication)app;
                   })

                   .AddScoped<IHostedService, ProductsAPI>()


            ;

            return Services;
        }
    }
}
