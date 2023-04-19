using CustomersAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomersAPI.Data
{
    public static class EntityRelationshipMapping
    {

        public static void CustomerMapping(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .ToTable("CUSTOMERS LIST")
                .HasKey(pk => pk.Contact_Id);

            modelBuilder.Entity<Customer>()
                .Property(cust => cust.PhoneNumber)
                .HasAnnotation("RegularExpression", @"^(09|\+639)\d{9}$");
        }

        public static void TransactionMapping(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transactions>()
                .ToTable("TRANSACTIONS LIST")
                .HasKey(pk => pk.Transaction_Id);

            modelBuilder.Entity<Transactions>()
                .HasOne<Customer>(trans => trans.Customer)
                .WithMany(cust => cust.Transactions)
                .HasForeignKey(trans => trans.ContactId)
                .HasConstraintName("FK_Contact_Id");

            modelBuilder.Entity<Transactions>()
                .Property(trans => trans.Amount)
                .HasPrecision(18,2);
        }


    }
}
