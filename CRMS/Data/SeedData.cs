using CRMS.Models;
using CRMS.Models.Customization;
using Microsoft.AspNetCore.Identity;
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
                        UserName = "SysAdmin",
                        NormalizedUserName = "SysAdmin".ToUpper(),
                        Email = "su@crms.com",
                        NormalizedEmail = "su@crms.com".ToUpper(),
                        AccessFailedCount = 0,
                        EmailConfirmed = true,
                        PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Admin123"),
                        SecurityStamp = string.Empty,
                        FirstName = "System",
                        LastName= "Admin",
                        DOB = DateTime.Now.Date,
                        CityAddress = "Makati",

                        LockoutEnabled = true,
                        TwoFactorEnabled = false,
                        PhoneNumberConfirmed = true,
                    },
                  new ApplicationUser
                    {
                        Id = Guid.NewGuid(),
                        UserName = "cgl@crms.com",
                        NormalizedUserName = "cgl@crms.com".ToUpper(),
                        Email = "cgl@crms.com",
                        NormalizedEmail = "cgl@crms.com".ToUpper(),
                        AccessFailedCount = 0,
                        EmailConfirmed = true,
                        PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "legista123"),
                        SecurityStamp = string.Empty,
                        FirstName = "Charl",
                        LastName= "Legista",
                        DOB = DateTime.Now.Date,
                        CityAddress = "Pasay",

                        LockoutEnabled = true,
                        TwoFactorEnabled = false,
                        PhoneNumberConfirmed = true,
                    },
                  new ApplicationUser
                    {
                        Id = Guid.NewGuid(),
                        UserName = "sbb@crms.com",
                        NormalizedUserName = "sbb@crms.com".ToUpper(),
                        Email = "sbb@crms.com",
                        NormalizedEmail = "sbb@crms.com".ToUpper(),
                        AccessFailedCount = 0,
                        EmailConfirmed = true,
                        PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "barris123"),
                        SecurityStamp = string.Empty,
                        FirstName = "Steven",
                        LastName= "Barris",
                        DOB = DateTime.Now.Date,
                        CityAddress = "General Trias",

                        LockoutEnabled = true,
                        TwoFactorEnabled = false,
                        PhoneNumberConfirmed = true,
                    }
            };

            var userRole = new List<IdentityUserRole<Guid>>
            {
                new IdentityUserRole<Guid>
                {
                    RoleId = roles[0].Id,
                    UserId = user[0].Id,
                }

            };

            //var contact = new List<Contacts>
            //{
            //    new Contacts
            //    {
            //        Contact_Id = Guid.NewGuid(),
            //        FirstName = "Charl",
            //        LastName = "Legista",
            //        Email = "charl.legista@gmail.com",
            //        PhoneNumber = "09052214812",
            //        Gender = GenderType.Male,
            //        DOB = new DateTime(1994, 05, 10),
            //        ContactCreatorID = user[0].Id,
            //        CreateDate = DateTime.Now,
            //        UpdateDate = DateTime.Now,
            //        UpdatedBy = user[0].Id

            //    },
            //    new Contacts
            //    {
            //        Contact_Id = Guid.NewGuid(),
            //        FirstName = "Steven",
            //        LastName = "Baris",
            //        Email = "steven.baris14@gmail.com",
            //        PhoneNumber = "09123456789",
            //        Gender = GenderType.Male,
            //        DOB = new DateTime(1999, 09, 12),
            //        ContactOwnerID = user[1].Id,
            //        DateAssigned = DateTime.Now.AddDays(-3),
            //        ContactCreatorID = user[0].Id,
            //        CreateDate = DateTime.Now.AddDays(-5),
            //        UpdateDate = DateTime.Now,
            //        UpdatedBy = user[0].Id
            //    },
            //    new Contacts
            //    {
            //        Contact_Id = Guid.NewGuid(),
            //        FirstName = "Customer",
            //        LastName = "Number1",
            //        Email = "cust.no1@gmail.com",
            //        PhoneNumber = "09987654321",
            //        Gender = GenderType.Female,
            //        DOB = new DateTime(1996, 01, 22),
            //        ContactOwnerID = user[1].Id,
            //        DateAssigned = DateTime.Now.AddDays(-1),
            //        ContactCreatorID = user[1].Id,
            //        CreateDate = DateTime.Now.AddDays(-3),
            //        UpdateDate = DateTime.Now,
            //        UpdatedBy = user[0].Id
            //    }
            //};

            modelBuilder.Entity<AppointmentPurpose>().HasData(purpose);
            modelBuilder.Entity<CommunicationMethod>().HasData(methods);
            modelBuilder.Entity<Effectivity>().HasData(effectivity);
            modelBuilder.Entity<EngagementType>().HasData(engagementType);
            modelBuilder.Entity<Source>().HasData(src);
            modelBuilder.Entity<LeadStatus>().HasData(status);
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(roles);
            modelBuilder.Entity<ApplicationUser>().HasData(user);
            //modelBuilder.Entity<Contacts>().HasData(contact);
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(userRole);
        }
        private static string NormalizeAttribute(string attribute)
        {
            return attribute.ToUpperInvariant();
        }
    }
}