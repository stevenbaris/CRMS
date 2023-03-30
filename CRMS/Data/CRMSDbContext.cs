using Microsoft.EntityFrameworkCore;

namespace CRMS.Data
{
    public class CRMSDbContext : DbContext
    {
        private readonly IConfiguration _appConfig;

        public CRMSDbContext(IConfiguration appConfig)
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
            
            optionsBuilder.UseSqlServer(connectionString);


            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
        }
    }
}
