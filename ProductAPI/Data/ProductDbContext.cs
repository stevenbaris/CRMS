using Microsoft.EntityFrameworkCore;
using ProductAPI.Model;
using Microsoft.AspNetCore.Identity;
using ProductAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ProductAPI.Data
{
    public class ProductDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        IConfiguration _appConfig;

        public ProductDbContext(DbContextOptions<ProductDbContext> options, IConfiguration appConfig) : base(options)
        {
            _appConfig = appConfig;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var server = _appConfig.GetConnectionString("Server");
            var db = _appConfig.GetConnectionString("DB");
            var userName = _appConfig.GetConnectionString("UserName");
            var password = _appConfig.GetConnectionString("Password");
            string connectionString = $"Server={server};Database={db};User Id= {userName};Password={password};MultipleActiveResultSets=true;Trusted_Connection=True;TrustServerCertificate=True"; /*TrustServerCertificate = true*/

            optionsBuilder.UseSqlServer(connectionString, sqlOptions =>
            {
                sqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 5, // Number of retry attempts
                    maxRetryDelay: TimeSpan.FromSeconds(30), // Delay between retries
                    errorNumbersToAdd: null); // SQL error codes to retry on (null means all errors)
            })
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            base.OnConfiguring(optionsBuilder);
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.SeedDefaultData();
            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Product> Products { get; set; }
    }
}