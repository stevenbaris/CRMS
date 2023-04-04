using CRMS.Models;
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

            var purpose = new List<AppointmentPurpose> 
            {
              new AppointmentPurpose(Guid.NewGuid(), "Fact-Find"),
              new AppointmentPurpose(Guid.NewGuid(), "Presentation"),
              new AppointmentPurpose(Guid.NewGuid(), "Proposal"),
              new AppointmentPurpose(Guid.NewGuid(), "Sales Closing"),
              new AppointmentPurpose(Guid.NewGuid(), "Others")
            };

            var methods = new List<CommunicationMethod>
            {
              new CommunicationMethod(Guid.NewGuid(), "Facebook"),
              new CommunicationMethod(Guid.NewGuid(), "Instagram"),
              new CommunicationMethod(Guid.NewGuid(), "WhatsApp"),
              new CommunicationMethod(Guid.NewGuid(), "Line"),
              new CommunicationMethod(Guid.NewGuid(), "Phone Call"),
              new CommunicationMethod(Guid.NewGuid(), "Test Message"),
              new CommunicationMethod(Guid.NewGuid(), "Email"),
              new CommunicationMethod(Guid.NewGuid(), "Others")
            };

            var effectivity = new List<Effectivity>
            {
              new Effectivity(Guid.NewGuid(), "Not Read"),
              new Effectivity(Guid.NewGuid(), "Read but no response"),
              new Effectivity(Guid.NewGuid(), "Simple Response"),
              new Effectivity(Guid.NewGuid(), "Good Engagement")
            };
      
            var engagementType = new List<EngagementType>
            {
              new EngagementType(Guid.NewGuid(), "Congratulations"),
              new EngagementType(Guid.NewGuid(), "Birthday"),
              new EngagementType(Guid.NewGuid(), "Anniversary"),
              new EngagementType(Guid.NewGuid(), "Holiday"),
              new EngagementType(Guid.NewGuid(), "Discount"),
              new EngagementType(Guid.NewGuid(), "Company News"),
              new EngagementType(Guid.NewGuid(), "New Product"),
              new EngagementType(Guid.NewGuid(), "Others")
            };

            var src = new List<Source>
            {
              new Source(Guid.NewGuid(), "Referral"),
              new Source(Guid.NewGuid(), "Friend"),
              new Source(Guid.NewGuid(), "Compony-Generated"),
              new Source(Guid.NewGuid(), "Social Media"),
              new Source(Guid.NewGuid(), "Webinar"),
              new Source(Guid.NewGuid(), "Others")
            };

            var status = new List<LeadStatus>
            {
              new LeadStatus(Guid.NewGuid(), "Contacted"),
              new LeadStatus(Guid.NewGuid(), "Met"),
              new LeadStatus(Guid.NewGuid(), "Proposal Generated"),
              new LeadStatus(Guid.NewGuid(), "Application Submitted"),
              new LeadStatus(Guid.NewGuid(), "Policy Issued"),
              new LeadStatus(Guid.NewGuid(), "Lead is Dead")
            };

            modelBuilder.Entity<AppointmentPurpose>().HasData(purpose);
            modelBuilder.Entity<CommunicationMethod>().HasData(methods);
            modelBuilder.Entity<Effectivity>().HasData(effectivity);
            modelBuilder.Entity<EngagementType>().HasData(engagementType);
            modelBuilder.Entity<Source>().HasData(src);
            modelBuilder.Entity<LeadStatus>().HasData(status);
        }

    }
}