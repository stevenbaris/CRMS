using Microsoft.EntityFrameworkCore;

namespace CRMS.Data
{
    public static class SeedData
    {
        public static void SeededData(this ModelBuilder modelBuilder)
        {
            ////EXAMPLE
            //var cust = new List<EntityModel>
            //{
            //    new EntityModel (Guid.NewGuid(), "Madeline", "Baxter", "Female",new DateTime(1975, 3, 15), "mauris.sagittis@icloud.edu", "09123546789", "5234 Crossing Street" ),
            // };
            //modelBuilder.Entity<EntityModel>().HasData(cust);

        }

    }
}