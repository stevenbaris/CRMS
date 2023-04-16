using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class new_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("25aaf155-7e15-4145-9d02-406503dea43e"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("697e043b-40c2-4a4d-afdc-2d67e1a4e19d"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("7a7a5016-3ec9-48b9-85f5-12449dcb86bd"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("9d07f65d-fedd-487a-8363-f1130bb16604"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("b1381ee6-66d9-4e7f-9da0-fe58d2d2cd8f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0180ecf2-56e9-4990-b036-6a481050fb13"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6f352e8a-e970-44c7-90f7-b2f514ab5a42"), new Guid("7d54b793-a22d-4de7-9c31-16e6c43a158e") });

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("4c464f9a-984c-4be9-965c-fc5e693bb97c"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("b93ab50c-d7e1-46c5-8e79-cd29e2d92e3c"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("d72f886a-315f-421d-a7eb-9790c14906c3"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("1a201628-cd8e-4f89-a139-1771ed0cdfcc"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("29191238-4dff-4744-9ea5-415e9f9e1f8f"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("38131ff4-da72-4be9-9795-03d5de2a0853"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("4bccfe2c-bbae-46d5-b8df-12fc22564153"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("56db31a1-15b6-4a96-9a27-dcdf7358f65c"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("5c56728e-0f10-47a8-9812-1a43493e0fc9"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("d0050a76-e57b-48ad-8e8d-62d8affb9217"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("e2a078e3-5eb0-48f2-a5d2-d28f666c2aff"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("5ab1929e-d250-4ec5-b2e6-7cb7cb9eebc6"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("77a2398f-69c8-4422-a854-69ff52b889cb"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("bce1ba78-6f1d-4a7f-ba21-d016b7e10110"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("c4049980-fdca-45b3-b29f-05ad99a9c574"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("26bd0aef-6d1e-44de-8ea1-0d15df94adf6"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("2aa63b33-97cc-4b6a-bfce-988a45f1c4d5"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("6c345791-618b-4308-a8de-d92957dcab5a"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("788d5c8b-5734-411c-87cd-ce339a8948aa"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("897120bb-062c-4325-83c6-4f5aeea5c966"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("a8532f5a-b673-4504-aaca-c3dd8eba0406"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("b77bb499-b4e3-4dcf-9396-d550e6e2910d"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("c3d657e5-fdbb-427e-8ef2-3b6cd83d0fb0"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("4e1c371f-a43f-4f35-8264-eedd4894f2a1"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("519b4d51-6a60-4696-a59d-5ec691bec551"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("573447e6-25c8-4fa5-a8f2-ad0848200747"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("72bc6650-6153-40fd-9f2d-e57e740c1f8a"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("9c340807-ac6e-4ecc-b9d9-6be1cfe90181"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("c732c637-f335-49e5-9dae-f28261f92eba"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("6bf34c63-6215-4f58-89e0-51e1af448b35"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("79808f88-5453-4796-a326-f3e27374dc0d"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("943a0e69-cf9f-44da-af84-631c9f776edc"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("cd873999-1bc3-4387-8e5b-e5d9a14dfec3"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("e0c9311f-a9a6-4961-83d6-0d388a18c5d7"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("e1677194-aed0-4034-b149-1ce3c2bad0ee"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6f352e8a-e970-44c7-90f7-b2f514ab5a42"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("47d75412-db88-4e08-8826-abdcd4ac29ea"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d54b793-a22d-4de7-9c31-16e6c43a158e"));

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("2b42e697-23ff-408e-9fdf-afce1ab28129"), "Sales Closing" },
                    { new Guid("641ca528-d21c-4fb2-a647-8bc8b52ae964"), "Proposal" },
                    { new Guid("679d70c4-de77-47dd-b9e2-624dca265f92"), "Presentation" },
                    { new Guid("99f6555e-9527-4f1b-b551-6e8c2323711e"), "Others" },
                    { new Guid("dae620d4-2e56-4703-95d3-2e0f098fb158"), "Fact-Find" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8e09c27b-c7f4-4143-a42c-c538d9af9c64"), "333a8828-3f92-4f11-b0df-609882b5f540", "Admin", "ADMIN" },
                    { new Guid("d41968cc-d0ad-4073-86d9-19bf0d7850d4"), "eef2ca70-a76c-4cb8-a777-c9d1c4d49da8", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2a4ea01b-47f1-4788-8332-a441d0b2a9eb"), 0, "PJ Lhuiller", "4b3963df-1559-44c8-a016-cc3640c2c564", new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEIJZO8wuTbAKdQ7bRvsh8K8rZDncc/oDpYFroQcZ51RdXN6m6Bb9PD70FNwOT/RAqg==", null, true, "", false, "su@crms.com" },
                    { new Guid("eb7c0ce7-bec0-4c18-bb34-756c7c9a18ad"), 0, "PJ Lhuiller", "dce4fc9a-8296-42bd-9826-ec8028082922", new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEBFqtxyDgRFwAnJdgE2Va33NkhKtX6gggFgpnXfW+rXPimK5ULxIbxS3j4wk6Zp/Rw==", null, true, "", false, "user@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("0022d2b9-e87e-40b0-bb1c-0c7640fdc45c"), "Instagram" },
                    { new Guid("0eb548a6-a698-480f-b96d-1c2f62324e21"), "Phone Call" },
                    { new Guid("26a99b96-220e-4565-b357-00c01b6f1130"), "WhatsApp" },
                    { new Guid("283ae90c-45f4-48c8-81f1-6136c85acdea"), "Others" },
                    { new Guid("296c72fb-438e-45df-bf3d-2068b83e3c82"), "Email" },
                    { new Guid("54a7b9ce-d171-4047-91e2-952272983901"), "Test Message" },
                    { new Guid("6acea6a8-ccb0-4666-a911-485af861be1c"), "Facebook" },
                    { new Guid("eab3f3ae-bc70-4ce4-b87a-298dcf9ff207"), "Line" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("121519e6-38a3-4efc-b2fb-20c6101ca92a"), "Read but no response" },
                    { new Guid("47c26cc4-bf6c-4865-8f44-570b5842f609"), "Simple Response" },
                    { new Guid("92f75301-5b59-40d1-b565-28d9be88de52"), "Good Engagement" },
                    { new Guid("d41eb4d0-6e9d-4932-80e6-0ae26711e147"), "Not Read" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("0bd67a79-69d4-4bf5-a7a2-29bcaa32d890"), "Company News" },
                    { new Guid("1b66ddc3-f4e9-45ce-a872-eb1ace6d7b5f"), "Discount" },
                    { new Guid("253fcda3-b353-46e7-989c-719fa92120c3"), "Others" },
                    { new Guid("35d75168-6c74-4ab4-b626-c686e9cc0edc"), "Anniversary" },
                    { new Guid("66cb7222-0a50-4785-a831-8f603ebb9f7d"), "Congratulations" },
                    { new Guid("84728c50-cab9-4000-b437-645815422ec3"), "New Product" },
                    { new Guid("85460245-c6b4-4bdb-8ee5-2e3f8ca8d4d3"), "Birthday" },
                    { new Guid("97f9cd8a-813c-4d96-8416-59612290d47c"), "Holiday" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("34f644f1-fa88-452b-9e63-4208aa21bc66"), "Social Media" },
                    { new Guid("3c91c8e6-817b-4d0b-8ba4-b63a60052a63"), "Webinar" },
                    { new Guid("87ac426b-6d39-4299-9364-1972f338b8aa"), "Others" },
                    { new Guid("98107181-e66d-448b-807b-dec8c721952d"), "Referral" },
                    { new Guid("aa79e5aa-9a5d-45da-9475-10bcb099ce48"), "Compony-Generated" },
                    { new Guid("c0413d85-3670-480a-9c64-69df7193734d"), "Friend" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("27368ae9-3bcc-40ca-a8b8-ec0d1d3e52d3"), "Proposal Generated" },
                    { new Guid("27cfa6f5-e9ed-487f-8ca9-64a897f44b13"), "Lead is Dead" },
                    { new Guid("65cfac00-7ad4-4b02-9cbc-f26e5ebee7da"), "Policy Issued" },
                    { new Guid("66df81bd-1ca3-429f-92f7-9e8a3b9d823b"), "Contacted" },
                    { new Guid("f479b108-f0ec-4e48-b406-8f10d94c70ce"), "Application Submitted" },
                    { new Guid("f5c8cf2c-7655-4d00-91c3-d91bb11082eb"), "Met" }
                });

            migrationBuilder.InsertData(
                table: "PRODUCTS",
                columns: new[] { "Product_Id", "Benefits", "ProductDescription", "ProductName" },
                values: new object[] { new Guid("1a3c6336-fc23-4b1c-9440-2e00b4abc5cf"), "Earthquake, Typhoon, Flood, Windstorm, Volcanic Eruption and other Acts of Nature, Extended Coverage, BOWTAP, BWD, SL and other water related damages, Vandalism/Spontaneous Combustion, All Other Losses", "CL MicroEnterpriseProtekis a Property Insurance Program specially designed for Cebuana Lhuillier clients. It covers loss “ALL Risks” of physical loss, destruction of or damage to the property of the insured and wholly attributable to any sudden and unforeseen cause, except as hereinafter excluded, occurring during the currency of the policy.", "CL MicroEnterpriseProtek" });

            migrationBuilder.InsertData(
                table: "PRODUCTS",
                columns: new[] { "Product_Id", "Benefits", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { new Guid("1e2d0eb9-6e4d-4155-a12f-49ad67d5f843"), "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Accidental Burial Benefit, Cash Assistance Benefit, Fire Cash Assistance", "CL Personal Accident Nano Plus Insurance covers Accidental Death, Disablement, or Dismemberment, Accident Medical Reimbursement, Accident Burial Benefit, Cash Assistance benefit, and Fire Cash Assistance.", "CL Personal Accident Nano Plus" },
                    { new Guid("369f510b-cea5-4caa-9472-a6d3fd9020e3"), "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Cash Assistance Due to Food Poisoning", "CL Personal Accident Nano Insurance covers loss for Accidental Death, Disablement, or Dismemberment, and Cash Assistance due to Food Poisoning.", "CL Personal Accident Nano" },
                    { new Guid("a1412935-9aab-4220-9573-40c54f9e0133"), "Death Benefit, Accident or Sickness Emergency Cash Assistance, Accidental Dismemberment and/or Disablement, Murder and Unprovoked Assault and Residential Fire Reconstruction cash assistance", "For as low as P50, each certificate is valid for four (4) months from the date of issuance and can be availed up to a maximum of 5 certificates per insured.", "ProtectMAX" },
                    { new Guid("c3185ce8-4ecf-4d23-9f1a-d2505314e447"), "The Policy is Effective for one (1) year from the date of issuance or after payment of claim,whichever comes first.", "covers the medical expenses incurred within a year from the date of issuance or purchase by the InsuredPerson for the treatment of an eligible emergency condition, availment of which caneither be as an Out-Patient in the Emergency Room Department or as an In-Patient of aHospital via cash assistance.", "CL ER Care" },
                    { new Guid("e471c18b-52e3-4de7-a539-5817aed3dd61"), "24/7 Call-a-doc, OP ER One Time use (All causes), Daily Hospital Income Benefit (All Causes)", "An Individual Personal Accident Insurance specifically designed for Cebuana Lhuillier clients.It covers Accidental Death and Disability (AD&D), Double Indemnity, 24/7 Call-a-doc, OP ER One Time use and Daily Hospital Income Benefit.", "CL Health Care" },
                    { new Guid("e60c8d84-e8ca-4df2-8ee3-f5c45850407d"), "Accidental Death, Accidental Dismemberment and/or Disablement", "Covers Accidental Death and Accidental Dismemberment and/or Disablement Benefit.", "CL Personal Accident Basic" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8e09c27b-c7f4-4143-a42c-c538d9af9c64"), new Guid("2a4ea01b-47f1-4788-8332-a441d0b2a9eb") });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("8e335679-a112-4d79-b874-e253c2619900"), new Guid("2a4ea01b-47f1-4788-8332-a441d0b2a9eb"), null, new DateTime(2023, 4, 14, 8, 36, 55, 352, DateTimeKind.Utc).AddTicks(6957), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812" },
                    { new Guid("9fcd0360-5d8c-4ca3-9e05-48d3e5775b70"), new Guid("eb7c0ce7-bec0-4c18-bb34-756c7c9a18ad"), new Guid("eb7c0ce7-bec0-4c18-bb34-756c7c9a18ad"), new DateTime(2023, 4, 11, 8, 36, 55, 352, DateTimeKind.Utc).AddTicks(6981), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 8, 36, 55, 352, DateTimeKind.Utc).AddTicks(6980), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321" },
                    { new Guid("ea714d24-8c4e-4b4f-8cd2-06ede45e16a1"), new Guid("2a4ea01b-47f1-4788-8332-a441d0b2a9eb"), new Guid("eb7c0ce7-bec0-4c18-bb34-756c7c9a18ad"), new DateTime(2023, 4, 9, 8, 36, 55, 352, DateTimeKind.Utc).AddTicks(6976), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 8, 36, 55, 352, DateTimeKind.Utc).AddTicks(6969), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("2b42e697-23ff-408e-9fdf-afce1ab28129"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("641ca528-d21c-4fb2-a647-8bc8b52ae964"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("679d70c4-de77-47dd-b9e2-624dca265f92"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("99f6555e-9527-4f1b-b551-6e8c2323711e"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("dae620d4-2e56-4703-95d3-2e0f098fb158"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d41968cc-d0ad-4073-86d9-19bf0d7850d4"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8e09c27b-c7f4-4143-a42c-c538d9af9c64"), new Guid("2a4ea01b-47f1-4788-8332-a441d0b2a9eb") });

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("8e335679-a112-4d79-b874-e253c2619900"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("9fcd0360-5d8c-4ca3-9e05-48d3e5775b70"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("ea714d24-8c4e-4b4f-8cd2-06ede45e16a1"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("0022d2b9-e87e-40b0-bb1c-0c7640fdc45c"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("0eb548a6-a698-480f-b96d-1c2f62324e21"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("26a99b96-220e-4565-b357-00c01b6f1130"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("283ae90c-45f4-48c8-81f1-6136c85acdea"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("296c72fb-438e-45df-bf3d-2068b83e3c82"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("54a7b9ce-d171-4047-91e2-952272983901"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("6acea6a8-ccb0-4666-a911-485af861be1c"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("eab3f3ae-bc70-4ce4-b87a-298dcf9ff207"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("121519e6-38a3-4efc-b2fb-20c6101ca92a"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("47c26cc4-bf6c-4865-8f44-570b5842f609"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("92f75301-5b59-40d1-b565-28d9be88de52"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("d41eb4d0-6e9d-4932-80e6-0ae26711e147"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("0bd67a79-69d4-4bf5-a7a2-29bcaa32d890"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("1b66ddc3-f4e9-45ce-a872-eb1ace6d7b5f"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("253fcda3-b353-46e7-989c-719fa92120c3"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("35d75168-6c74-4ab4-b626-c686e9cc0edc"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("66cb7222-0a50-4785-a831-8f603ebb9f7d"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("84728c50-cab9-4000-b437-645815422ec3"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("85460245-c6b4-4bdb-8ee5-2e3f8ca8d4d3"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("97f9cd8a-813c-4d96-8416-59612290d47c"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("34f644f1-fa88-452b-9e63-4208aa21bc66"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("3c91c8e6-817b-4d0b-8ba4-b63a60052a63"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("87ac426b-6d39-4299-9364-1972f338b8aa"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("98107181-e66d-448b-807b-dec8c721952d"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("aa79e5aa-9a5d-45da-9475-10bcb099ce48"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("c0413d85-3670-480a-9c64-69df7193734d"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("27368ae9-3bcc-40ca-a8b8-ec0d1d3e52d3"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("27cfa6f5-e9ed-487f-8ca9-64a897f44b13"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("65cfac00-7ad4-4b02-9cbc-f26e5ebee7da"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("66df81bd-1ca3-429f-92f7-9e8a3b9d823b"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("f479b108-f0ec-4e48-b406-8f10d94c70ce"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("f5c8cf2c-7655-4d00-91c3-d91bb11082eb"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("1a3c6336-fc23-4b1c-9440-2e00b4abc5cf"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("1e2d0eb9-6e4d-4155-a12f-49ad67d5f843"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("369f510b-cea5-4caa-9472-a6d3fd9020e3"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("a1412935-9aab-4220-9573-40c54f9e0133"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("c3185ce8-4ecf-4d23-9f1a-d2505314e447"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("e471c18b-52e3-4de7-a539-5817aed3dd61"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("e60c8d84-e8ca-4df2-8ee3-f5c45850407d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8e09c27b-c7f4-4143-a42c-c538d9af9c64"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a4ea01b-47f1-4788-8332-a441d0b2a9eb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("eb7c0ce7-bec0-4c18-bb34-756c7c9a18ad"));

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("25aaf155-7e15-4145-9d02-406503dea43e"), "Sales Closing" },
                    { new Guid("697e043b-40c2-4a4d-afdc-2d67e1a4e19d"), "Fact-Find" },
                    { new Guid("7a7a5016-3ec9-48b9-85f5-12449dcb86bd"), "Presentation" },
                    { new Guid("9d07f65d-fedd-487a-8363-f1130bb16604"), "Proposal" },
                    { new Guid("b1381ee6-66d9-4e7f-9da0-fe58d2d2cd8f"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0180ecf2-56e9-4990-b036-6a481050fb13"), "bae318c7-9c1e-4a7f-bf37-e3eb543313a1", "User", "USER" },
                    { new Guid("6f352e8a-e970-44c7-90f7-b2f514ab5a42"), "4c836850-8956-4b2a-b144-fc7ee74e2dea", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("47d75412-db88-4e08-8826-abdcd4ac29ea"), 0, "PJ Lhuiller", "234b8117-355c-40f2-96b1-2af3c5299caa", new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEPMv4YdJQamZfRnAYYseEliR998ghu7PlfYRN0ZP6X+cen/jXZ8eb3GlE7uQo5SSzA==", null, true, "", false, "user@crms.com" },
                    { new Guid("7d54b793-a22d-4de7-9c31-16e6c43a158e"), 0, "PJ Lhuiller", "b173dc06-784e-4b23-b853-4deaff76057c", new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAELkFXE6eytOxM/xC/+LmPN7pyQ2YI+DuG4DfCzgBMO9J7OC3kgfyNZ8qauwkJ2klpQ==", null, true, "", false, "su@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("1a201628-cd8e-4f89-a139-1771ed0cdfcc"), "Instagram" },
                    { new Guid("29191238-4dff-4744-9ea5-415e9f9e1f8f"), "Test Message" },
                    { new Guid("38131ff4-da72-4be9-9795-03d5de2a0853"), "Phone Call" },
                    { new Guid("4bccfe2c-bbae-46d5-b8df-12fc22564153"), "Facebook" },
                    { new Guid("56db31a1-15b6-4a96-9a27-dcdf7358f65c"), "Others" },
                    { new Guid("5c56728e-0f10-47a8-9812-1a43493e0fc9"), "Email" },
                    { new Guid("d0050a76-e57b-48ad-8e8d-62d8affb9217"), "WhatsApp" },
                    { new Guid("e2a078e3-5eb0-48f2-a5d2-d28f666c2aff"), "Line" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("5ab1929e-d250-4ec5-b2e6-7cb7cb9eebc6"), "Read but no response" },
                    { new Guid("77a2398f-69c8-4422-a854-69ff52b889cb"), "Not Read" },
                    { new Guid("bce1ba78-6f1d-4a7f-ba21-d016b7e10110"), "Good Engagement" },
                    { new Guid("c4049980-fdca-45b3-b29f-05ad99a9c574"), "Simple Response" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("26bd0aef-6d1e-44de-8ea1-0d15df94adf6"), "New Product" },
                    { new Guid("2aa63b33-97cc-4b6a-bfce-988a45f1c4d5"), "Birthday" },
                    { new Guid("6c345791-618b-4308-a8de-d92957dcab5a"), "Discount" },
                    { new Guid("788d5c8b-5734-411c-87cd-ce339a8948aa"), "Anniversary" },
                    { new Guid("897120bb-062c-4325-83c6-4f5aeea5c966"), "Holiday" },
                    { new Guid("a8532f5a-b673-4504-aaca-c3dd8eba0406"), "Company News" },
                    { new Guid("b77bb499-b4e3-4dcf-9396-d550e6e2910d"), "Others" },
                    { new Guid("c3d657e5-fdbb-427e-8ef2-3b6cd83d0fb0"), "Congratulations" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("4e1c371f-a43f-4f35-8264-eedd4894f2a1"), "Social Media" },
                    { new Guid("519b4d51-6a60-4696-a59d-5ec691bec551"), "Webinar" },
                    { new Guid("573447e6-25c8-4fa5-a8f2-ad0848200747"), "Friend" },
                    { new Guid("72bc6650-6153-40fd-9f2d-e57e740c1f8a"), "Others" },
                    { new Guid("9c340807-ac6e-4ecc-b9d9-6be1cfe90181"), "Referral" },
                    { new Guid("c732c637-f335-49e5-9dae-f28261f92eba"), "Compony-Generated" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("6bf34c63-6215-4f58-89e0-51e1af448b35"), "Contacted" },
                    { new Guid("79808f88-5453-4796-a326-f3e27374dc0d"), "Met" },
                    { new Guid("943a0e69-cf9f-44da-af84-631c9f776edc"), "Policy Issued" },
                    { new Guid("cd873999-1bc3-4387-8e5b-e5d9a14dfec3"), "Application Submitted" },
                    { new Guid("e0c9311f-a9a6-4961-83d6-0d388a18c5d7"), "Lead is Dead" },
                    { new Guid("e1677194-aed0-4034-b149-1ce3c2bad0ee"), "Proposal Generated" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("6f352e8a-e970-44c7-90f7-b2f514ab5a42"), new Guid("7d54b793-a22d-4de7-9c31-16e6c43a158e") });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("4c464f9a-984c-4be9-965c-fc5e693bb97c"), new Guid("7d54b793-a22d-4de7-9c31-16e6c43a158e"), new Guid("47d75412-db88-4e08-8826-abdcd4ac29ea"), new DateTime(2023, 4, 9, 8, 16, 55, 608, DateTimeKind.Utc).AddTicks(9017), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 8, 16, 55, 608, DateTimeKind.Utc).AddTicks(8998), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789" },
                    { new Guid("b93ab50c-d7e1-46c5-8e79-cd29e2d92e3c"), new Guid("7d54b793-a22d-4de7-9c31-16e6c43a158e"), null, new DateTime(2023, 4, 14, 8, 16, 55, 608, DateTimeKind.Utc).AddTicks(8978), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812" },
                    { new Guid("d72f886a-315f-421d-a7eb-9790c14906c3"), new Guid("47d75412-db88-4e08-8826-abdcd4ac29ea"), new Guid("47d75412-db88-4e08-8826-abdcd4ac29ea"), new DateTime(2023, 4, 11, 8, 16, 55, 608, DateTimeKind.Utc).AddTicks(9027), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 8, 16, 55, 608, DateTimeKind.Utc).AddTicks(9026), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321" }
                });
        }
    }
}
