using Microsoft.EntityFrameworkCore;
using ProductAPI.Model;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace ProductAPI.Data
{
    public static class SeedData
    {
        public static void SeedDefaultData(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Product>().HasData(
               new Product() { Id = Guid.NewGuid(), ProductName = "CL Personal Accident Nano", 
                   ProductDescription = "CL Personal Accident Nano Insurance covers loss for Accidental Death," +
               " Disablement, or Dismemberment, and Cash Assistance due to Food Poisoning.", 
                   Benefits = "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, " +
                   "Cash Assistance Due to Food Poisoning"},
               new Product() { Id = Guid.NewGuid(), ProductName = "CL Personal Accident Nano Plus", 
                   ProductDescription = "CL Personal Accident Nano Plus Insurance covers Accidental Death, Disablement, or Dismemberment, " +
                   "Accident Medical Reimbursement, Accident Burial Benefit, Cash Assistance benefit, and Fire Cash Assistance.", 
                   Benefits = "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Accidental Burial Benefit, " +
                   "Cash Assistance Benefit, Fire Cash Assistance"
               },
               new Product() { Id = Guid.NewGuid(), ProductName = "CL MicroEnterpriseProtek", 
                   ProductDescription = "CL MicroEnterpriseProtekis a Property Insurance Program specially designed for Cebuana Lhuillier clients. " +
                   "It covers loss “ALL Risks” of physical loss, destruction of or damage to the property of the insured and wholly attributable to any " +
                   "sudden and unforeseen cause, except as hereinafter excluded, occurring during the currency of the policy.", 
                   Benefits = "Earthquake, Typhoon, Flood, Windstorm, Volcanic Eruption and other Acts of Nature, Extended Coverage, BOWTAP, BWD, SL and other water related damages, " +
                   "Vandalism/Spontaneous Combustion, All Other Losses"
               },
               new Product()
               {
                   Id = Guid.NewGuid(),
                   ProductName = "ProtectMAX",
                   ProductDescription = "For as low as P50, each certificate is valid for four (4) months from the date of issuance and can be availed up to a " +
                   "maximum of 5 certificates per insured.",
                   Benefits = "Death Benefit, Accident or Sickness Emergency Cash Assistance, Accidental Dismemberment and/or Disablement, Murder and Unprovoked Assault and " +
                   "Residential Fire Reconstruction cash assistance"
               },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "CL Health Care",
                    ProductDescription = "An Individual Personal Accident Insurance specifically designed for Cebuana Lhuillier clients.It covers Accidental Death and Disability (AD&D), Double Indemnity, " +
                    "24/7 Call-a-doc, OP ER One Time use and Daily Hospital Income Benefit.",
                    Benefits = "24/7 Call-a-doc, OP ER One Time use (All causes), Daily Hospital Income Benefit (All Causes)"
                },
                 new Product()
                 {
                     Id = Guid.NewGuid(),
                     ProductName = "CL Personal Accident Basic",
                     ProductDescription = "Covers Accidental Death and Accidental Dismemberment and/or Disablement Benefit.",
                     Benefits = "Accidental Death, Accidental Dismemberment and/or Disablement"
                 },
                 new Product()
                 {
                     Id = Guid.NewGuid(),
                     ProductName = "CL ER Care",
                     ProductDescription = "covers the medical expenses incurred within a year from the date of issuance or purchase by the InsuredPerson for the treatment of an eligible " +
                     "emergency condition, availment of which caneither be as an Out-Patient in the Emergency Room Department or as an In-Patient of aHospital via cash assistance.",
                     Benefits = "The Policy is Effective for one (1) year from the date of issuance or after payment of claim,whichever comes first."
                 }
               );
        }
    }
}
