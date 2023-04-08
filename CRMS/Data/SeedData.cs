using CRMS.Models;
using CRMS.Models.Customization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Web.Helpers;

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

           
               
               

            var roles = new List<IdentityRole<Guid>>
            {
                 
                 new IdentityRole<Guid>{Id = Guid.NewGuid(),Name = "Admin", NormalizedName = NormalizeAttribute("Admin") },
                 new IdentityRole<Guid>{Id = Guid.NewGuid(),Name = "User",  NormalizedName = NormalizeAttribute("User") },
            };

            var user = new List<ApplicationUser>
            {
                  new ApplicationUser
                    {
                        Id = Guid.NewGuid(),
                        UserName = "su@crms.com",
                        Email = "su@crms.com",
                        AccessFailedCount = 0,
                        EmailConfirmed = true,
                        PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Admin123"),
                        SecurityStamp = string.Empty,
                        FirstName = "Super",
                        LastName= "User",
                        DOB = DateTime.Now.Date,
                        Address = "PJ Lhuiller",

                        LockoutEnabled = true,
                        TwoFactorEnabled = false,
                        PhoneNumberConfirmed = true,
                    },
                  new ApplicationUser
                    {
                        Id = Guid.NewGuid(),
                        UserName = "user@crms.com",
                        Email = "user@crms.com",
                        AccessFailedCount = 0,
                        EmailConfirmed = true,
                        PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "user123"),
                        SecurityStamp = string.Empty,
                        FirstName = "Regular",
                        LastName= "User",
                        DOB = DateTime.Now.Date,
                        Address = "PJ Lhuiller",

                        LockoutEnabled = true,
                        TwoFactorEnabled = false,
                        PhoneNumberConfirmed = true,
                    }
            };

            var contact = new List<Contacts>
            {
                new Contacts
                {
                    Contact_Id = Guid.NewGuid(),
                    FirstName = "Charl",
                    LastName = "Legista",
                    Email = "charl.legista@gmail.com",
                    PhoneNumber = "09052214812",
                    Gender = GenderType.Male,
                    DOB = new DateTime(1994, 05, 10),
                    ContactCreatorID = user[0].Id,
                    CreateDate = DateTime.UtcNow
                },
                new Contacts
                {
                    Contact_Id = Guid.NewGuid(),
                    FirstName = "Steven",
                    LastName = "Baris",
                    Email = "steven.baris14@gmail.com",
                    PhoneNumber = "09123456789",
                    Gender = GenderType.Male,
                    DOB = new DateTime(1999, 09, 12),
                    ContactOwnerID = user[1].Id,
                    DateAssigned = DateTime.UtcNow.AddDays(-3),
                    ContactCreatorID = user[0].Id,
                    CreateDate = DateTime.UtcNow.AddDays(-5)
                },
                new Contacts
                {
                    Contact_Id = Guid.NewGuid(),
                    FirstName = "Customer",
                    LastName = "Number1",
                    Email = "cust.no1@gmail.com",
                    PhoneNumber = "09987654321",
                    Gender = GenderType.Female,
                    DOB = new DateTime(1996, 01, 22),
                    ContactOwnerID = user[1].Id,
                    DateAssigned = DateTime.UtcNow.AddDays(-1),
                    ContactCreatorID = user[1].Id,
                    CreateDate = DateTime.UtcNow.AddDays(-3)
                }
            };

            modelBuilder.Entity<AppointmentPurpose>().HasData(purpose);
            modelBuilder.Entity<CommunicationMethod>().HasData(methods);
            modelBuilder.Entity<Effectivity>().HasData(effectivity);
            modelBuilder.Entity<EngagementType>().HasData(engagementType);
            modelBuilder.Entity<Source>().HasData(src);
            modelBuilder.Entity<LeadStatus>().HasData(status);
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(roles);
            modelBuilder.Entity<ApplicationUser>().HasData(user);
            modelBuilder.Entity<Contacts>().HasData(contact);
        }
        private static string NormalizeAttribute(string attribute)
        {
            return attribute.ToUpperInvariant();
        }
    }
}