using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductAPI.Migrations
{
    public partial class addedSeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21d7802b-4427-4191-9d09-0aa81cf07df4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23fb8c9a-fcf8-4a16-8572-9536824311a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61709f6f-4ff1-4761-935a-2d0e2864f355"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be7203da-17ff-4e82-9771-cc6c684594f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8a7cc4b-7615-46cf-8f4f-6700719d7325"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4c45f83-506e-4a2b-a535-5313e095cdda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e6384c23-b667-4f1c-ac3b-2a055c42a7af"));

            migrationBuilder.AddColumn<string>(
                name: "CityAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityAddress", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("9285fe50-1d1a-4091-9d3f-1f217de6fb81"), 0, "Makati", "d58f2201-afc3-4638-a5e8-3e1215a2b71f", new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEOdE/iY2pIs20fqmAIaHJtzXr0TYwAMfQzoCUyMy8b7aMZ5QQBS7sdj8ZNIhuX6zwg==", null, true, "", false, "user@crms.com" },
                    { new Guid("af9103e0-8686-4ee9-84d6-47b3a48a8dc2"), 0, "Makati", "5951e20d-86ce-41a1-931c-d58ebd2dc8c9", new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEPuBRyJXLl2yp6zH6OWP/mBI8VVVHi1jNwmq6WDWgiIb6amZi05ng5ZvBJzSC+IgIw==", null, true, "", false, "su@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Benefits", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { new Guid("2f3a5b1d-0466-4744-b0b5-934d2ba0695a"), "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Cash Assistance Due to Food Poisoning", "CL Personal Accident Nano Insurance covers loss for Accidental Death, Disablement, or Dismemberment, and Cash Assistance due to Food Poisoning.", "CL Personal Accident Nano" },
                    { new Guid("2f96372a-0268-4723-ad73-0b6da8f16a31"), "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Accidental Burial Benefit, Cash Assistance Benefit, Fire Cash Assistance", "CL Personal Accident Nano Plus Insurance covers Accidental Death, Disablement, or Dismemberment, Accident Medical Reimbursement, Accident Burial Benefit, Cash Assistance benefit, and Fire Cash Assistance.", "CL Personal Accident Nano Plus" },
                    { new Guid("6e563dad-2738-474c-b3fd-e9ce0869bfcb"), "The Policy is Effective for one (1) year from the date of issuance or after payment of claim,whichever comes first.", "covers the medical expenses incurred within a year from the date of issuance or purchase by the InsuredPerson for the treatment of an eligible emergency condition, availment of which caneither be as an Out-Patient in the Emergency Room Department or as an In-Patient of aHospital via cash assistance.", "CL ER Care" },
                    { new Guid("716740a0-5fb9-4eab-bf80-75e9b89ac143"), "Death Benefit, Accident or Sickness Emergency Cash Assistance, Accidental Dismemberment and/or Disablement, Murder and Unprovoked Assault and Residential Fire Reconstruction cash assistance", "For as low as P50, each certificate is valid for four (4) months from the date of issuance and can be availed up to a maximum of 5 certificates per insured.", "ProtectMAX" },
                    { new Guid("7f6914ca-38fb-464d-943e-89c2fbeda31a"), "Accidental Death, Accidental Dismemberment and/or Disablement", "Covers Accidental Death and Accidental Dismemberment and/or Disablement Benefit.", "CL Personal Accident Basic" },
                    { new Guid("c7d93b44-85ff-4f93-b803-53707ce799b5"), "Earthquake, Typhoon, Flood, Windstorm, Volcanic Eruption and other Acts of Nature, Extended Coverage, BOWTAP, BWD, SL and other water related damages, Vandalism/Spontaneous Combustion, All Other Losses", "CL MicroEnterpriseProtekis a Property Insurance Program specially designed for Cebuana Lhuillier clients. It covers loss “ALL Risks” of physical loss, destruction of or damage to the property of the insured and wholly attributable to any sudden and unforeseen cause, except as hereinafter excluded, occurring during the currency of the policy.", "CL MicroEnterpriseProtek" },
                    { new Guid("f7aad4cf-4a57-4c7a-a4e3-ab42fe2bba8c"), "24/7 Call-a-doc, OP ER One Time use (All causes), Daily Hospital Income Benefit (All Causes)", "An Individual Personal Accident Insurance specifically designed for Cebuana Lhuillier clients.It covers Accidental Death and Disability (AD&D), Double Indemnity, 24/7 Call-a-doc, OP ER One Time use and Daily Hospital Income Benefit.", "CL Health Care" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9285fe50-1d1a-4091-9d3f-1f217de6fb81"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("af9103e0-8686-4ee9-84d6-47b3a48a8dc2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f3a5b1d-0466-4744-b0b5-934d2ba0695a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f96372a-0268-4723-ad73-0b6da8f16a31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e563dad-2738-474c-b3fd-e9ce0869bfcb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("716740a0-5fb9-4eab-bf80-75e9b89ac143"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f6914ca-38fb-464d-943e-89c2fbeda31a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7d93b44-85ff-4f93-b803-53707ce799b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7aad4cf-4a57-4c7a-a4e3-ab42fe2bba8c"));

            migrationBuilder.DropColumn(
                name: "CityAddress",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Benefits", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { new Guid("21d7802b-4427-4191-9d09-0aa81cf07df4"), "Death Benefit, Accident or Sickness Emergency Cash Assistance, Accidental Dismemberment and/or Disablement, Murder and Unprovoked Assault and Residential Fire Reconstruction cash assistance", "For as low as P50, each certificate is valid for four (4) months from the date of issuance and can be availed up to a maximum of 5 certificates per insured.", "ProtectMAX" },
                    { new Guid("23fb8c9a-fcf8-4a16-8572-9536824311a3"), "Accidental Death, Accidental Dismemberment and/or Disablement", "Covers Accidental Death and Accidental Dismemberment and/or Disablement Benefit.", "CL Personal Accident Basic" },
                    { new Guid("61709f6f-4ff1-4761-935a-2d0e2864f355"), "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Accidental Burial Benefit, Cash Assistance Benefit, Fire Cash Assistance", "CL Personal Accident Nano Plus Insurance covers Accidental Death, Disablement, or Dismemberment, Accident Medical Reimbursement, Accident Burial Benefit, Cash Assistance benefit, and Fire Cash Assistance.", "CL Personal Accident Nano Plus" },
                    { new Guid("be7203da-17ff-4e82-9771-cc6c684594f0"), "Earthquake, Typhoon, Flood, Windstorm, Volcanic Eruption and other Acts of Nature, Extended Coverage, BOWTAP, BWD, SL and other water related damages, Vandalism/Spontaneous Combustion, All Other Losses", "CL MicroEnterpriseProtekis a Property Insurance Program specially designed for Cebuana Lhuillier clients. It covers loss “ALL Risks” of physical loss, destruction of or damage to the property of the insured and wholly attributable to any sudden and unforeseen cause, except as hereinafter excluded, occurring during the currency of the policy.", "CL MicroEnterpriseProtek" },
                    { new Guid("c8a7cc4b-7615-46cf-8f4f-6700719d7325"), "The Policy is Effective for one (1) year from the date of issuance or after payment of claim,whichever comes first.", "covers the medical expenses incurred within a year from the date of issuance or purchase by the InsuredPerson for the treatment of an eligible emergency condition, availment of which caneither be as an Out-Patient in the Emergency Room Department or as an In-Patient of aHospital via cash assistance.", "CL ER Care" },
                    { new Guid("d4c45f83-506e-4a2b-a535-5313e095cdda"), "24/7 Call-a-doc, OP ER One Time use (All causes), Daily Hospital Income Benefit (All Causes)", "An Individual Personal Accident Insurance specifically designed for Cebuana Lhuillier clients.It covers Accidental Death and Disability (AD&D), Double Indemnity, 24/7 Call-a-doc, OP ER One Time use and Daily Hospital Income Benefit.", "CL Health Care" },
                    { new Guid("e6384c23-b667-4f1c-ac3b-2a055c42a7af"), "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Cash Assistance Due to Food Poisoning", "CL Personal Accident Nano Insurance covers loss for Accidental Death, Disablement, or Dismemberment, and Cash Assistance due to Food Poisoning.", "CL Personal Accident Nano" }
                });
        }
    }
}
