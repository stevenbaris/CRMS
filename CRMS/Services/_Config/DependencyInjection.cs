using CRMS.Data;
using CRMS.Models;
using CRMS.Models.Customization;
using CRMS.Services.Account_Services;
using CRMS.Services.Contacts_Services;
using CRMS.Services.SqlRepositories;
using Microsoft.AspNetCore.Identity;

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




                    ;

            return Services;
        }
    }
}
