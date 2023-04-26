using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Model;
using ProductAPI.Models;
using System.Reflection.Emit;

namespace ProductAPI.Data
{
    public static class SeedData
    {
        public static void SeedDefaultData(this ModelBuilder modelbuilder)
        {
            var product = new List<Product>
            {
                 new Product(Guid.NewGuid(), "CL Personal Accident Nano",
                   "CL Personal Accident Nano Insurance covers loss for Accidental Death," +
               " Disablement, or Dismemberment, and Cash Assistance due to Food Poisoning.",
                   "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, " +
                   "Cash Assistance Due to Food Poisoning",DateTime.Now.AddDays(-60),DateTime.Now.AddDays(-60)
                   ),
               new Product(Guid.NewGuid(), "CL Personal Accident Nano Plus",
                   "CL Personal Accident Nano Plus Insurance covers Accidental Death, Disablement, or Dismemberment, " +
                   "Accident Medical Reimbursement, Accident Burial Benefit, Cash Assistance benefit, and Fire Cash Assistance.",
                   "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Accidental Burial Benefit, " +
                   "Cash Assistance Benefit, Fire Cash Assistance",DateTime.Now.AddDays(-60),DateTime.Now.AddDays(-60)
               ),
               new Product(Guid.NewGuid(), "CL MicroEnterpriseProtek",
                   "CL MicroEnterpriseProtekis a Property Insurance Program specially designed for Cebuana Lhuillier clients. " +
                   "It covers loss “ALL Risks” of physical loss, destruction of or damage to the property of the insured and wholly attributable to any " +
                   "sudden and unforeseen cause, except as hereinafter excluded, occurring during the currency of the policy.",
                   "Earthquake, Typhoon, Flood, Windstorm, Volcanic Eruption and other Acts of Nature, Extended Coverage, BOWTAP, BWD, SL and other water related damages, " +
                   "Vandalism/Spontaneous Combustion, All Other Losses",DateTime.Now.AddDays(-60),DateTime.Now.AddDays(-60)
               ),
               new Product(Guid.NewGuid(),
                   "ProtectMAX",
                   "For as low as P50, each certificate is valid for four (4) months from the date of issuance and can be availed up to a " +
                   "maximum of 5 certificates per insured.",
                   "Death Benefit, Accident or Sickness Emergency Cash Assistance, Accidental Dismemberment and/or Disablement, Murder and Unprovoked Assault and " +
                   "Residential Fire Reconstruction cash assistance",DateTime.Now.AddDays(-60),DateTime.Now.AddDays(-60)
               ),
                new Product(
                    Guid.NewGuid(),
                    "CL Health Care",
                    "An Individual Personal Accident Insurance specifically designed for Cebuana Lhuillier clients.It covers Accidental Death and Disability (AD&D), Double Indemnity, " +
                    "24/7 Call-a-doc, OP ER One Time use and Daily Hospital Income Benefit.",
                    "24/7 Call-a-doc, OP ER One Time use (All causes), Daily Hospital Income Benefit (All Causes)",DateTime.Now.AddDays(-60),DateTime.Now.AddDays(-60)
                ),
                 new Product(Guid.NewGuid(),
                     "CL Personal Accident Basic",
                     "Covers Accidental Death and Accidental Dismemberment and/or Disablement Benefit.",
                     "Accidental Death, Accidental Dismemberment and/or Disablement",DateTime.Now.AddDays(-60),DateTime.Now.AddDays(-60)
                 ),
                 new Product(Guid.NewGuid(),
                     "CL ER Care",
                     "covers the medical expenses incurred within a year from the date of issuance or purchase by the InsuredPerson for the treatment of an eligible " +
                     "emergency condition, availment of which caneither be as an Out-Patient in the Emergency Room Department or as an In-Patient of aHospital via cash assistance.",
                     "The Policy is Effective for one (1) year from the date of issuance or after payment of claim,whichever comes first.",DateTime.Now.AddDays(-60),DateTime.Now.AddDays(-60)
                 )
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
                  }
            };

            modelbuilder.Entity<ApplicationUser>().HasData(user);
            modelbuilder.Entity<Product>().HasData(product);

        }
    }
}
