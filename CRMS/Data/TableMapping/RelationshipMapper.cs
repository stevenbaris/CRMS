using CRMS.Models;
using CRMS.Models.Customization;
using CRMS.Models.Records;
using Microsoft.AspNetCore.Identity;
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

            modelBuilder.Entity<IdentityUserRole<Guid>>()
                .ToTable("AspNetUserRoles")
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<Appointments>()
                .ToTable("APPOINTMENTS")
                .HasKey(ap => ap.Appointment_Id);

            modelBuilder.Entity<Engagement>()
                .ToTable("ENGAGEMENTS")
                .HasKey(en => en.Engagement_Id);

            modelBuilder.Entity<Product>()
               .ToTable("PRODUCTS")
               .HasKey(prod => prod.Product_Id);




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

            modelBuilder.Entity<Contacts>()
                .HasOne(c => c.Updater)
                .WithMany()
                .HasForeignKey(c => c.UpdatedBy)
                .HasConstraintName("FK_ContactUpdater")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RollingTransactions>()
                .HasOne<Contacts>(transact => transact.Contacts)
                .WithOne(contact => contact.Transactions)
                .HasForeignKey<RollingTransactions>(transact => transact.ContactId)
                .HasConstraintName("FK_TransactionsOfContact");

            modelBuilder.Entity<Appointments>()
                .HasOne<Contacts>(ap => ap.prospect)
                .WithMany()
                .HasForeignKey(ap => ap.ContactId)
                .HasConstraintName("FK_AppointmentProspect");

            modelBuilder.Entity<Appointments>()
                .HasOne<AppointmentPurpose>(purpose => purpose.AppointmentPurpose)
                .WithMany()
                .HasForeignKey(purpose => purpose.PurposeId)
                .HasConstraintName("FK_AppointmentPurpose");

            modelBuilder.Entity<Appointments>()
               .HasOne<ApplicationUser>(apCreator => apCreator.User)
               .WithMany()
               .HasForeignKey(apCreator => apCreator.CreatedBy)
               .HasConstraintName("FK_AppointmentCreator");

            modelBuilder.Entity<Engagement>()
               .HasOne<EngagementType>(en => en.EngagementType)
               .WithMany()
               .HasForeignKey(en => en.ETypeId)
               .HasConstraintName("FK_EngagementType");

            modelBuilder.Entity<Engagement>()
              .HasOne<Effectivity>(en => en.Effectivity)
              .WithMany()
              .HasForeignKey(en => en.EffectivityId)
              .HasConstraintName("FK_Effectivity");

            modelBuilder.Entity<Engagement>()
              .HasOne<CommunicationMethod>(en => en.CommunicationMethod)
              .WithMany()
              .HasForeignKey(en => en.CommsMethodId)
              .HasConstraintName("FK_CommunicationMethod");

            modelBuilder.Entity<Engagement>()
              .HasOne<Contacts>(en => en.Contacts)
              .WithMany()
              .HasForeignKey(en => en.ContactId)
              .HasConstraintName("FK_Contacts");

            modelBuilder.Entity<Engagement>()
              .HasOne<ApplicationUser>(en => en.User)
              .WithMany()
              .HasForeignKey(en => en.CreatedById)
              .HasConstraintName("FK_Creator");





            //COLUMN PROPERTIES
            modelBuilder.Entity<RollingTransactions>()
                .Property(trans => trans.TransacationTotal)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Contacts>()
                .Property(con => con.Email)
                .IsRequired();

        }
    }
}
