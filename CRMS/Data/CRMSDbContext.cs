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


            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
           .HasOne<Role>(me => me.Role)
           .WithMany(parent => parent.Users)
           .HasForeignKey(me => me.RoleId);

            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}