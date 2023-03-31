using CRMS.Models;
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

            //RELATIONSHIP


            //COLUMN PROPERTIES


        }

    }
}
