using CustomersAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomersAPI.Data
{
    public class CustomerDBContext : DbContext
    {
        IConfiguration _appConfig;

        public CustomerDBContext(IConfiguration appConfig)
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
            
            optionsBuilder.UseSqlServer(connectionString)
                          .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.CustomerMapping();
            modelBuilder.TransactionMapping();
            modelBuilder.SeededData();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Transactions>? Transactions { get; set; } 
    }
}
