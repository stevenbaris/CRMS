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
                        UserName = "su@crms.com",
                        NormalizedUserName = "su@crms.com".ToUpper(),
                        Email = "su@crms.com",
                        NormalizedEmail = "su@crms.com".ToUpper(),
                        AccessFailedCount = 0,
                        EmailConfirmed = true,
                        PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Admin123"),
                        SecurityStamp = string.Empty,
                        FirstName = "Super",
                        LastName= "User",
                        DOB = DateTime.Now.Date,
                        CityAddress = "Makati",

                        LockoutEnabled = true,
                        TwoFactorEnabled = false,
                        PhoneNumberConfirmed = true,
                    },
                  new ApplicationUser
                    {
                        Id = Guid.NewGuid(),
                        UserName = "user@crms.com",
                        NormalizedUserName = "user@crms.com".ToUpper(),
                        Email = "user@crms.com",
                        NormalizedEmail = "user@crms.com".ToUpper(),
                        AccessFailedCount = 0,
                        EmailConfirmed = true,
                        PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "user123"),
                        SecurityStamp = string.Empty,
                        FirstName = "Regular",
                        LastName= "User",
                        DOB = DateTime.Now.Date,
                        CityAddress = "Makati",

                        LockoutEnabled = true,
                        TwoFactorEnabled = false,
                        PhoneNumberConfirmed = true,
                    },

                  new ApplicationUser
                    {
                        Id = Guid.NewGuid(),
                        UserName = "SYSTEM",
                        NormalizedUserName = "SYSTEM".ToUpper(),
                        Email = "sys@crms.com",
                        NormalizedEmail = "sys@crms.com".ToUpper(),
                        AccessFailedCount = 0,
                        EmailConfirmed = true,
                        PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "$y$t3M"),
                        SecurityStamp = string.Empty,
                        FirstName = "SYSTEM",
                        LastName= "CRMS",
                        DOB = DateTime.Now.Date,
                        CityAddress = "Makati",

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
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    UpdatedBy = user[2].Id

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
                    DateAssigned = DateTime.Now.AddDays(-3),
                    ContactCreatorID = user[0].Id,
                    CreateDate = DateTime.Now.AddDays(-5),
                    UpdateDate = DateTime.Now,
                    UpdatedBy = user[2].Id
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
                    DateAssigned = DateTime.Now.AddDays(-1),
                    ContactCreatorID = user[1].Id,
                    CreateDate = DateTime.Now.AddDays(-3),
                    UpdateDate = DateTime.Now,
                    UpdatedBy = user[2].Id
                }
            };

            //var product = new List<Product>
            //{
            //     new Product(Guid.NewGuid(), "CL Personal Accident Nano",
            //       "CL Personal Accident Nano Insurance covers loss for Accidental Death," +
            //   " Disablement, or Dismemberment, and Cash Assistance due to Food Poisoning.",
            //       "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, " +
            //       "Cash Assistance Due to Food Poisoning",user[2].Id,DateTime.Now
            //       ),
            //   new Product(Guid.NewGuid(), "CL Personal Accident Nano Plus",
            //       "CL Personal Accident Nano Plus Insurance covers Accidental Death, Disablement, or Dismemberment, " +
            //       "Accident Medical Reimbursement, Accident Burial Benefit, Cash Assistance benefit, and Fire Cash Assistance.",
            //       "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Accidental Burial Benefit, " +
            //       "Cash Assistance Benefit, Fire Cash Assistance",user[2].Id,DateTime.Now
            //   ),
            //   new Product(Guid.NewGuid(), "CL MicroEnterpriseProtek",
            //       "CL MicroEnterpriseProtekis a Property Insurance Program specially designed for Cebuana Lhuillier clients. " +
            //       "It covers loss “ALL Risks” of physical loss, destruction of or damage to the property of the insured and wholly attributable to any " +
            //       "sudden and unforeseen cause, except as hereinafter excluded, occurring during the currency of the policy.",
            //       "Earthquake, Typhoon, Flood, Windstorm, Volcanic Eruption and other Acts of Nature, Extended Coverage, BOWTAP, BWD, SL and other water related damages, " +
            //       "Vandalism/Spontaneous Combustion, All Other Losses",user[2].Id,DateTime.Now
            //   ),
            //   new Product(Guid.NewGuid(),
            //       "ProtectMAX",
            //       "For as low as P50, each certificate is valid for four (4) months from the date of issuance and can be availed up to a " +
            //       "maximum of 5 certificates per insured.",
            //       "Death Benefit, Accident or Sickness Emergency Cash Assistance, Accidental Dismemberment and/or Disablement, Murder and Unprovoked Assault and " +
            //       "Residential Fire Reconstruction cash assistance",user[2].Id,DateTime.Now
            //   ),
            //    new Product(
            //        Guid.NewGuid(),
            //        "CL Health Care",
            //        "An Individual Personal Accident Insurance specifically designed for Cebuana Lhuillier clients.It covers Accidental Death and Disability (AD&D), Double Indemnity, " +
            //        "24/7 Call-a-doc, OP ER One Time use and Daily Hospital Income Benefit.",
            //        "24/7 Call-a-doc, OP ER One Time use (All causes), Daily Hospital Income Benefit (All Causes)",user[2].Id,DateTime.Now
            //    ),
            //     new Product(Guid.NewGuid(),
            //         "CL Personal Accident Basic",
            //         "Covers Accidental Death and Accidental Dismemberment and/or Disablement Benefit.",
            //         "Accidental Death, Accidental Dismemberment and/or Disablement",user[2].Id,DateTime.Now
            //     ),
            //     new Product(Guid.NewGuid(),
            //         "CL ER Care",
            //         "covers the medical expenses incurred within a year from the date of issuance or purchase by the InsuredPerson for the treatment of an eligible " +
            //         "emergency condition, availment of which caneither be as an Out-Patient in the Emergency Room Department or as an In-Patient of aHospital via cash assistance.",
            //         "The Policy is Effective for one (1) year from the date of issuance or after payment of claim,whichever comes first.",user[2].Id,DateTime.Now
            //     )
            //};

            modelBuilder.Entity<AppointmentPurpose>().HasData(purpose);
            modelBuilder.Entity<CommunicationMethod>().HasData(methods);
            modelBuilder.Entity<Effectivity>().HasData(effectivity);
            modelBuilder.Entity<EngagementType>().HasData(engagementType);
            modelBuilder.Entity<Source>().HasData(src);
            modelBuilder.Entity<LeadStatus>().HasData(status);
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(roles);
            modelBuilder.Entity<ApplicationUser>().HasData(user);
            modelBuilder.Entity<Contacts>().HasData(contact);
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(userRole);
            //modelBuilder.Entity<Product>().HasData(product);
        }
        private static string NormalizeAttribute(string attribute)
        {
            return attribute.ToUpperInvariant();
        }
    }
}