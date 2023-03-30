using CRMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Data
{
    public class CRMSDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Database Connectivity
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=CRMSDB;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // fluent api customize the tables schema
            //modelBuilder.UserModel();

            // seed some basic data 
            // administrator user in the user table
            modelBuilder.Entity<User>()
            .HasOne<Roles>(me => me.Roles)
            .WithMany(parent => parent.Users)
            .HasForeignKey(me => me.RolesId);

            //modelBuilder.SeedDefaultData();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
