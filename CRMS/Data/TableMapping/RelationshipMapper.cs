using CRMS.Models;
using CRMS.Models.Customization;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Data.TableMapping
{
    public static class RelationshipMapper
    {
        public static void TableRelationMapper(this ModelBuilder modelBuilder)
        {
            //TABLE PROPERTIES
            modelBuilder.Entity<AppointmentPurpose>()
                .ToTable("APPOINTMENT_PURPOSES")
                .HasKey(purpose => purpose.Purpose_Id);

            modelBuilder.Entity<CommunicationMethod>()
                .ToTable("ENGAGEMENT_COMMUNICATION METHODS")
                .HasKey(method => method.CommunicationMethod_Id);

            modelBuilder.Entity<Effectivity>()
                .ToTable("ENGAGEMENT_EFFECTIVITY")
                .HasKey(eff => eff.Effectivity_Id);

            modelBuilder.Entity<EngagementType>()
                .ToTable("ENGAGEMENT_ENGAGEMENT-TYPES")
                .HasKey(etype => etype.EType_Id);

            modelBuilder.Entity<Source>()
                .ToTable("LEADS_SOURCES")
                .HasKey(source => source.Source_Id);

            modelBuilder.Entity<LeadStatus>()
                .ToTable("LEADS_STATUSES")
                .HasKey(stts => stts.LeadStatus_Id);

            modelBuilder.Entity<Contacts>()
                .ToTable("CONTACTS")
                .HasKey(contact => contact.Contact_Id);

            modelBuilder.Entity<RollingTransactions>()
                .ToTable("ROLLING TRANSACTIONS")
                .HasKey(transact => transact.RollingTransactions_ID);


            //RELATIONSHIP
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Contacts)
                .WithOne(c => c.Owner)
                .HasForeignKey(c => c.ContactOwnerID)
                .HasConstraintName("FK_ContactOwner")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Contacts>()
                .HasOne(c => c.Creator)
                .WithMany()
                .HasForeignKey(c => c.ContactCreatorID)
                .HasConstraintName("FK_ContactCreator")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RollingTransactions>()
                .HasOne<Contacts>(transact => transact.Contacts)
                .WithOne(contact => contact.Transactions)
                .HasForeignKey<RollingTransactions>(transact => transact.ContactId)
                .HasConstraintName("FK_TransactionsOfContact");



            //COLUMN PROPERTIES
            modelBuilder.Entity<RollingTransactions>()
                .Property(trans => trans.TransacationTotal)
                .HasColumnType("decimal(18,2)");

        }
    }
}
