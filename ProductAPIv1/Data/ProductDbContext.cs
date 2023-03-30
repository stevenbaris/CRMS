using ProductAPI.Data;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Model;

namespace ProductAPI.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions option) : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.SeedDefaultData();
            base.OnModelCreating(modelBuilder);
   
        }
        public DbSet<Product> Products { get; set; }

    }
}