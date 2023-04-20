using CustomersAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomersAPI.Data
{
    public class CustomerDBContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        IConfiguration _appConfig;

        public CustomerDBContext(DbContextOptions<CustomerDBContext> options, IConfiguration appConfig) : base(options)
        {
            _appConfig = appConfig;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var server = _appConfig.GetConnectionString("Server");
            var db = _appConfig.GetConnectionString("DB");
            var userName = _appConfig.GetConnectionString("UserName");
            var password = _appConfig.GetConnectionString("Password");
            string connectionString = $"Server={server};Database={db};User Id= {userName};Password={password};MultipleActiveResultSets=true";

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
            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.Email)
                .IsUnique();


            modelBuilder.CustomerMapping();
            modelBuilder.TransactionMapping();
            modelBuilder.SeededData();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Transactions>? Transactions { get; set; } 
    }
}
