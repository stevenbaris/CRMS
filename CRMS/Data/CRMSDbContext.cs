using CRMS.Data.TableMapping;
using CRMS.Models;
using CRMS.Models.Customization;
using CRMS.Models.Records;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Data
{
    public class CRMSDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
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

            optionsBuilder.UseSqlServer(connectionString)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);


            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.TableRelationMapper();
            modelBuilder.SeededData();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AppointmentPurpose> Purposes { get; set; }
        public DbSet<CommunicationMethod> CommunicationMethods { get; set; }
        public DbSet<Effectivity> Effectivity { get; set; }
        public DbSet<EngagementType> EngagementTypes { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<LeadStatus> Statuses { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<RollingTransactions> RollingTransactions { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<Engagement> Engagements { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}