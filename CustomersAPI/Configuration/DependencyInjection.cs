using CustomersAPI.Repository.MSSQL;
using CustomersAPI.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using CustomersAPI.Models;
using Microsoft.AspNetCore.Identity;
using CustomersAPI.Data;
using Microsoft.OpenApi.Models;

namespace CustomersAPI.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepoService(this IServiceCollection Services)
        {
            //REPOSTORY PATTER
            Services.AddScoped<ICustomerDBRepository, CustomerDBRepo>();
            Services.AddScoped<ITransactionDBRepository, TransactionDBRepo>();
            Services.AddScoped<IAuthRepository, AuthorizationRepo>();
            Services.AddScoped<CustomerTransactionService>();

            return Services;
        }

        public static IServiceCollection AddAuthorizationandAuthentication(
            this IServiceCollection Services,
            IConfiguration Configuration)
        {
            Services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuer = true,
                            ValidateAudience = true,
                            ValidateLifetime = true,
                            ValidateIssuerSigningKey = true,
                            ValidIssuer = Configuration["JWT:Issuer"],
                            ValidAudience = Configuration["JWT:Audience"],
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Key"]))
                        };
                });

            return Services;
        }

        public static IServiceCollection AddIdentityConfig(this IServiceCollection Services)
        {
            Services.AddIdentity<ApplicationUser, IdentityRole<Guid>>()
                .AddEntityFrameworkStores<CustomerDBContext>()
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


            //Services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("AdminPolicy", policy =>
            //        policy.RequireRole("Admin"));
            //});

            return Services;
        }

        public static IServiceCollection AddSwaggerConfig(this IServiceCollection Services)
        {
            Services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo { Title = "CustomersAPI", Version = "v1" });
                opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "bearer"
                });
                opt.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id="Bearer"
                            }
                        },
                        new string[]{}
                    }
                });
            });

            return Services;
        }


        public static IServiceCollection AddCORS(this IServiceCollection Services, string MyAllowSpecificOrigins )
        {
            Services
                .AddCors(opt =>
                {
                    opt.AddPolicy(name: MyAllowSpecificOrigins, policy =>
                    {
                        //policy.AllowAnyOrigin()
                        policy.WithOrigins("https://localhost:5126", "https://localhost:51524")
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials();
                        
                    });
                });



            //Services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("AdminPolicy", policy =>
            //        policy.RequireRole("Admin"));
            //});

            return Services;
        }
    }
}
