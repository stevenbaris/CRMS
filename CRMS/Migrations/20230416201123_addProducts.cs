using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class addProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("27e12145-648f-42bd-a07d-061fb3b7a6a7"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("98b4e42b-29ea-41b4-a708-a12e4d557e95"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("a7363c54-3d12-4489-940d-bc37ceb557e1"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("a7495e8a-edd8-4fe8-81b0-77e27b3334aa"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("b0f2ffee-4b24-46ab-b7e1-c0dae2535650"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3e76ae20-2614-4b40-a962-f55555087bae"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2f27f58a-382d-42d6-8e7e-c3f64dea0b9a"), new Guid("0cd247a9-1ffe-4701-98b2-59f8d914d428") });

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("27e4f7e4-e9c3-48af-8645-e9c4e5a30b4c"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("6766a803-0936-4316-b4ae-202509af9329"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("a7710c8e-6a00-4f5d-b647-1b707210e83b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("49910645-e8bb-4477-bcf5-6961c76ee9aa"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("5712d76f-3b52-49eb-953b-86a35885c1ca"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("751811bb-dd5f-49b7-bee3-e79d7e031957"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("7a158181-2cb7-4027-93df-88fd0e7af42e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("a43a2215-cadd-4329-8f0f-0e3cf2975a1a"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("a9501733-b1e8-4262-b736-8c2ccfbd82de"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("d1d9438b-ab8b-4916-8234-9be248c0075f"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("f5c2a3ee-68fc-4829-814a-0e4d68eaf8a2"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("1b337aa3-8b2b-4f6b-94bc-e8e96fe3f1e9"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("1c0d88fe-7b56-4d53-8b4a-ad41ae912961"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("3f429b6f-33e2-4ffc-99df-81f6cf645009"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("facb73ff-5526-40ca-be28-fdc4ca7f6728"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("0de31afd-d659-4c1a-a8cd-5c27fb19a360"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("1550ba58-0d8d-4153-962a-c5093db7c1b2"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("1b36ae57-6621-40ea-812c-b5116182d8c9"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("5e9cbdb7-2823-4ed4-b2fe-cbc0475c5d17"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("69baf32f-ac19-4b94-b187-f5c16a3f5b0c"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("b68cd17a-b0f2-4a98-8a4e-2996e37b9d8c"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("c47497f7-566b-4f0e-9eb5-f1f4860f11f8"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("ebd43c84-b692-4cee-a81b-d02ec9767f68"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("2a8d07ca-48df-49d9-a99f-016b5460d3f1"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("344c3cf8-dd11-4be7-a038-1b9b1c6d6225"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("432c211e-8d3d-424a-bcd9-944c6a19722c"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("7788bb4d-3421-4c45-bfe7-8d5c439788c9"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("bd6cd130-a965-435c-917b-70ae35eb9648"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("f5ff4166-2ca9-4438-815f-7f8e85698ae8"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("073406cc-5829-4510-97e5-49642b5b01b8"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("4016a6f4-9688-4ce3-adbd-54801ab95b98"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("bae12886-507d-466f-8928-7469680d821d"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("bf6676b5-4c03-402c-a5ec-849b8a32f2bf"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("c5aa33a2-cce6-4455-874b-c195160c320b"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("c87edbd6-bbbf-4bb0-aca7-2c62bf8c85c0"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2f27f58a-382d-42d6-8e7e-c3f64dea0b9a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0cd247a9-1ffe-4701-98b2-59f8d914d428"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0de1f25e-9466-4e0f-8ee8-e31342a61ae3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("be8108c2-10df-4a36-94d0-28c59ba26f6f"));

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("14859e03-ce92-4417-a27c-c19bcda6610a"), "Proposal" },
                    { new Guid("503586f2-8c84-431a-922a-3f862f478e81"), "Presentation" },
                    { new Guid("83be4907-d85b-45c6-b652-f25975817573"), "Sales Closing" },
                    { new Guid("91370c36-6cf9-4b27-affc-2a38abd7bb3e"), "Fact-Find" },
                    { new Guid("a715221d-d4db-4904-918b-c13ff8eb9d97"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("30367b9c-0f68-4e0f-b1ef-ec3a2a051b92"), "bdc341e4-b2ca-4fb4-b779-de7f199921f6", "Admin", "ADMIN" },
                    { new Guid("e0ef033b-90e1-4afb-afc7-7e17cc12a2da"), "96d84640-11ca-415a-a772-b19f7c9dffc5", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityAddress", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("14b3ff27-4019-4c20-bb27-902ea8245e2b"), 0, "Makati", "5de1fec1-64d3-47b5-87b1-73cf1b5cd0af", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEALejIZjgYsHWvqv5KUtjE8s3qTlruo3pLdktJGnd1PldwT7JSh4Y3Ucpma4W0RVKw==", null, true, "", false, "su@crms.com" },
                    { new Guid("2592c9e0-ad72-4ca7-be82-6defe5aae304"), 0, "Makati", "5d189312-c33b-4176-acc6-46739931bc29", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "sys@crms.com", true, "SYSTEM", "CRMS", true, null, "SYS@CRMS.COM", "SYSTEM", "AQAAAAEAACcQAAAAELZ8kZwXGVAdB9SbEPJdqknxke2RmORbDyWL/Y/NzHAcf6ABzpBVDI6vtcxhC9N8nQ==", null, true, "", false, "SYSTEM" },
                    { new Guid("2da46bb1-2037-407e-8adc-97541a51c808"), 0, "Makati", "08f4c935-4a51-4159-bdde-d83ce74cefbc", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEKdLxL/hmB6anJZq2Kc7u2F5pt3gOKuYheL+NkhBsnj5Q9hTqIAJjvBr59vefk0Xbw==", null, true, "", false, "user@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("2597ebdd-50ce-419c-822f-f5efe8c3d5a8"), "Test Message" },
                    { new Guid("4ee70aea-5f83-4c9d-a0b7-5610e6de22a9"), "Others" },
                    { new Guid("4fcac767-5706-48e9-9c51-8bf7343cc3fd"), "Email" },
                    { new Guid("614518cf-aeb7-4291-8741-97fce1415373"), "Instagram" },
                    { new Guid("8e623ffa-af78-4f91-a5aa-4c2201397754"), "WhatsApp" },
                    { new Guid("e3f5ab08-d84b-4a83-a433-1707cacfc7e1"), "Line" },
                    { new Guid("ed2db789-a35d-4801-be87-da3d8d82e294"), "Facebook" },
                    { new Guid("fe224bce-6e9d-4ed5-a03a-781b9d1e0ee7"), "Phone Call" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("508615c3-18d1-484c-872d-433f2ca15656"), "Good Engagement" },
                    { new Guid("591610e4-99e3-4ab6-8b32-b930d0675685"), "Not Read" },
                    { new Guid("ea64e40d-e2bf-46ae-8ba6-890dbc22fde8"), "Simple Response" },
                    { new Guid("f0db339c-0c06-425c-be25-1ec67772d59a"), "Read but no response" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("36eba0e6-5acc-400b-bfeb-875638c4b471"), "Discount" },
                    { new Guid("466bc040-0403-4e89-a4d9-40d52211d6d4"), "Birthday" },
                    { new Guid("4af7e873-e8f5-44e5-86b9-90274cbdb606"), "Others" },
                    { new Guid("58a79ada-6563-43f9-ad00-f748d5edbfc7"), "Company News" },
                    { new Guid("9c8598a9-2417-4e78-8741-7fabfd34739b"), "New Product" },
                    { new Guid("a08d748d-6f0c-4b6c-925a-1e610bd0f2e2"), "Holiday" },
                    { new Guid("c9b24004-414c-477f-9c5c-70f558ebd11e"), "Anniversary" },
                    { new Guid("d2f04e06-51f1-4ad6-9bc6-49edea1732b9"), "Congratulations" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("1d0b46ac-9b56-4e07-9d22-468147592aae"), "Others" },
                    { new Guid("416cfdfc-540a-47b1-9a6b-cbbb44af5fa3"), "Social Media" },
                    { new Guid("716f890f-4183-4589-8b29-1d4c60df64c0"), "Compony-Generated" },
                    { new Guid("c1b243ab-abb8-487e-89bc-92d3a4613b60"), "Referral" },
                    { new Guid("d11a2d99-142d-4b24-b699-cfa6d73a4009"), "Webinar" },
                    { new Guid("e0422d5a-fe8a-4f99-b45b-a1d601fc30c4"), "Friend" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("10d05f62-ed46-4368-9930-a9d4c1a4f7b8"), "Met" },
                    { new Guid("8090f852-6597-4e12-905c-0d7a872bc49e"), "Proposal Generated" },
                    { new Guid("a37fa651-f596-4f23-a64a-c199e231651b"), "Contacted" },
                    { new Guid("b6453842-4215-4012-ba79-bcc899eb6753"), "Application Submitted" },
                    { new Guid("b741abbd-7d84-4bca-828d-79b3ee5dcadc"), "Lead is Dead" },
                    { new Guid("f20ade28-b193-4b84-9609-b433426cbdfa"), "Policy Issued" }
                });

            migrationBuilder.InsertData(
                table: "PRODUCTS",
                columns: new[] { "Product_Id", "Benefits", "ProductDescription", "ProductName", "UpdateDate", "UpdatedBy", "UpdaterId" },
                values: new object[,]
                {
                    { new Guid("00dcdcd5-ddb8-4003-be11-824bccd6a981"), "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Cash Assistance Due to Food Poisoning", "CL Personal Accident Nano Insurance covers loss for Accidental Death, Disablement, or Dismemberment, and Cash Assistance due to Food Poisoning.", "CL Personal Accident Nano", new DateTime(2023, 4, 17, 4, 11, 22, 226, DateTimeKind.Local).AddTicks(7616), new Guid("2592c9e0-ad72-4ca7-be82-6defe5aae304"), null },
                    { new Guid("0a73e398-d736-41fe-8832-d46bb5e9cf80"), "Earthquake, Typhoon, Flood, Windstorm, Volcanic Eruption and other Acts of Nature, Extended Coverage, BOWTAP, BWD, SL and other water related damages, Vandalism/Spontaneous Combustion, All Other Losses", "CL MicroEnterpriseProtekis a Property Insurance Program specially designed for Cebuana Lhuillier clients. It covers loss “ALL Risks” of physical loss, destruction of or damage to the property of the insured and wholly attributable to any sudden and unforeseen cause, except as hereinafter excluded, occurring during the currency of the policy.", "CL MicroEnterpriseProtek", new DateTime(2023, 4, 17, 4, 11, 22, 226, DateTimeKind.Local).AddTicks(7623), new Guid("2592c9e0-ad72-4ca7-be82-6defe5aae304"), null },
                    { new Guid("35c4ed8b-7f2c-453e-afaf-36a6c08c2d92"), "Accidental Death, Accidental Dismemberment and/or Disablement", "Covers Accidental Death and Accidental Dismemberment and/or Disablement Benefit.", "CL Personal Accident Basic", new DateTime(2023, 4, 17, 4, 11, 22, 226, DateTimeKind.Local).AddTicks(7629), new Guid("2592c9e0-ad72-4ca7-be82-6defe5aae304"), null },
                    { new Guid("38b39940-d870-4fb3-a48c-4b1b8956fd5f"), "24/7 Call-a-doc, OP ER One Time use (All causes), Daily Hospital Income Benefit (All Causes)", "An Individual Personal Accident Insurance specifically designed for Cebuana Lhuillier clients.It covers Accidental Death and Disability (AD&D), Double Indemnity, 24/7 Call-a-doc, OP ER One Time use and Daily Hospital Income Benefit.", "CL Health Care", new DateTime(2023, 4, 17, 4, 11, 22, 226, DateTimeKind.Local).AddTicks(7626), new Guid("2592c9e0-ad72-4ca7-be82-6defe5aae304"), null },
                    { new Guid("4326caf0-c13a-4ce0-b8ce-8d0c15881bee"), "The Policy is Effective for one (1) year from the date of issuance or after payment of claim,whichever comes first.", "covers the medical expenses incurred within a year from the date of issuance or purchase by the InsuredPerson for the treatment of an eligible emergency condition, availment of which caneither be as an Out-Patient in the Emergency Room Department or as an In-Patient of aHospital via cash assistance.", "CL ER Care", new DateTime(2023, 4, 17, 4, 11, 22, 226, DateTimeKind.Local).AddTicks(7630), new Guid("2592c9e0-ad72-4ca7-be82-6defe5aae304"), null },
                    { new Guid("67c4ef36-ee43-44f0-ade6-7dd533859471"), "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Accidental Burial Benefit, Cash Assistance Benefit, Fire Cash Assistance", "CL Personal Accident Nano Plus Insurance covers Accidental Death, Disablement, or Dismemberment, Accident Medical Reimbursement, Accident Burial Benefit, Cash Assistance benefit, and Fire Cash Assistance.", "CL Personal Accident Nano Plus", new DateTime(2023, 4, 17, 4, 11, 22, 226, DateTimeKind.Local).AddTicks(7621), new Guid("2592c9e0-ad72-4ca7-be82-6defe5aae304"), null },
                    { new Guid("a020c593-8afd-4448-895a-a65b397fe12a"), "Death Benefit, Accident or Sickness Emergency Cash Assistance, Accidental Dismemberment and/or Disablement, Murder and Unprovoked Assault and Residential Fire Reconstruction cash assistance", "For as low as P50, each certificate is valid for four (4) months from the date of issuance and can be availed up to a maximum of 5 certificates per insured.", "ProtectMAX", new DateTime(2023, 4, 17, 4, 11, 22, 226, DateTimeKind.Local).AddTicks(7625), new Guid("2592c9e0-ad72-4ca7-be82-6defe5aae304"), null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("30367b9c-0f68-4e0f-b1ef-ec3a2a051b92"), new Guid("14b3ff27-4019-4c20-bb27-902ea8245e2b") });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "UpdateDate", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("a9a27b3f-0532-4285-ac77-bfaeaf9d8070"), new Guid("14b3ff27-4019-4c20-bb27-902ea8245e2b"), new Guid("2da46bb1-2037-407e-8adc-97541a51c808"), new DateTime(2023, 4, 12, 4, 11, 22, 226, DateTimeKind.Local).AddTicks(7605), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 4, 11, 22, 226, DateTimeKind.Local).AddTicks(7600), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789", new DateTime(2023, 4, 17, 4, 11, 22, 226, DateTimeKind.Local).AddTicks(7606), new Guid("2592c9e0-ad72-4ca7-be82-6defe5aae304") },
                    { new Guid("af3ba38c-0af9-4b9f-89b0-165ba8227c5c"), new Guid("14b3ff27-4019-4c20-bb27-902ea8245e2b"), null, new DateTime(2023, 4, 17, 4, 11, 22, 226, DateTimeKind.Local).AddTicks(7595), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812", new DateTime(2023, 4, 17, 4, 11, 22, 226, DateTimeKind.Local).AddTicks(7596), new Guid("2592c9e0-ad72-4ca7-be82-6defe5aae304") },
                    { new Guid("fb720e17-4b85-43ce-8d50-3c55cd90d726"), new Guid("2da46bb1-2037-407e-8adc-97541a51c808"), new Guid("2da46bb1-2037-407e-8adc-97541a51c808"), new DateTime(2023, 4, 14, 4, 11, 22, 226, DateTimeKind.Local).AddTicks(7611), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 4, 11, 22, 226, DateTimeKind.Local).AddTicks(7609), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321", new DateTime(2023, 4, 17, 4, 11, 22, 226, DateTimeKind.Local).AddTicks(7611), new Guid("2592c9e0-ad72-4ca7-be82-6defe5aae304") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("14859e03-ce92-4417-a27c-c19bcda6610a"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("503586f2-8c84-431a-922a-3f862f478e81"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("83be4907-d85b-45c6-b652-f25975817573"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("91370c36-6cf9-4b27-affc-2a38abd7bb3e"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("a715221d-d4db-4904-918b-c13ff8eb9d97"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e0ef033b-90e1-4afb-afc7-7e17cc12a2da"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("30367b9c-0f68-4e0f-b1ef-ec3a2a051b92"), new Guid("14b3ff27-4019-4c20-bb27-902ea8245e2b") });

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("a9a27b3f-0532-4285-ac77-bfaeaf9d8070"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("af3ba38c-0af9-4b9f-89b0-165ba8227c5c"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("fb720e17-4b85-43ce-8d50-3c55cd90d726"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("2597ebdd-50ce-419c-822f-f5efe8c3d5a8"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("4ee70aea-5f83-4c9d-a0b7-5610e6de22a9"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("4fcac767-5706-48e9-9c51-8bf7343cc3fd"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("614518cf-aeb7-4291-8741-97fce1415373"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("8e623ffa-af78-4f91-a5aa-4c2201397754"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("e3f5ab08-d84b-4a83-a433-1707cacfc7e1"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("ed2db789-a35d-4801-be87-da3d8d82e294"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("fe224bce-6e9d-4ed5-a03a-781b9d1e0ee7"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("508615c3-18d1-484c-872d-433f2ca15656"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("591610e4-99e3-4ab6-8b32-b930d0675685"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("ea64e40d-e2bf-46ae-8ba6-890dbc22fde8"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("f0db339c-0c06-425c-be25-1ec67772d59a"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("36eba0e6-5acc-400b-bfeb-875638c4b471"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("466bc040-0403-4e89-a4d9-40d52211d6d4"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("4af7e873-e8f5-44e5-86b9-90274cbdb606"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("58a79ada-6563-43f9-ad00-f748d5edbfc7"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("9c8598a9-2417-4e78-8741-7fabfd34739b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("a08d748d-6f0c-4b6c-925a-1e610bd0f2e2"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("c9b24004-414c-477f-9c5c-70f558ebd11e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("d2f04e06-51f1-4ad6-9bc6-49edea1732b9"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("1d0b46ac-9b56-4e07-9d22-468147592aae"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("416cfdfc-540a-47b1-9a6b-cbbb44af5fa3"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("716f890f-4183-4589-8b29-1d4c60df64c0"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("c1b243ab-abb8-487e-89bc-92d3a4613b60"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("d11a2d99-142d-4b24-b699-cfa6d73a4009"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("e0422d5a-fe8a-4f99-b45b-a1d601fc30c4"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("10d05f62-ed46-4368-9930-a9d4c1a4f7b8"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("8090f852-6597-4e12-905c-0d7a872bc49e"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("a37fa651-f596-4f23-a64a-c199e231651b"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("b6453842-4215-4012-ba79-bcc899eb6753"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("b741abbd-7d84-4bca-828d-79b3ee5dcadc"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("f20ade28-b193-4b84-9609-b433426cbdfa"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("00dcdcd5-ddb8-4003-be11-824bccd6a981"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("0a73e398-d736-41fe-8832-d46bb5e9cf80"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("35c4ed8b-7f2c-453e-afaf-36a6c08c2d92"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("38b39940-d870-4fb3-a48c-4b1b8956fd5f"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("4326caf0-c13a-4ce0-b8ce-8d0c15881bee"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("67c4ef36-ee43-44f0-ade6-7dd533859471"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("a020c593-8afd-4448-895a-a65b397fe12a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30367b9c-0f68-4e0f-b1ef-ec3a2a051b92"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("14b3ff27-4019-4c20-bb27-902ea8245e2b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2592c9e0-ad72-4ca7-be82-6defe5aae304"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2da46bb1-2037-407e-8adc-97541a51c808"));

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("27e12145-648f-42bd-a07d-061fb3b7a6a7"), "Fact-Find" },
                    { new Guid("98b4e42b-29ea-41b4-a708-a12e4d557e95"), "Sales Closing" },
                    { new Guid("a7363c54-3d12-4489-940d-bc37ceb557e1"), "Others" },
                    { new Guid("a7495e8a-edd8-4fe8-81b0-77e27b3334aa"), "Presentation" },
                    { new Guid("b0f2ffee-4b24-46ab-b7e1-c0dae2535650"), "Proposal" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2f27f58a-382d-42d6-8e7e-c3f64dea0b9a"), "5144952b-5cad-4be8-b514-c9e2bd42e574", "Admin", "ADMIN" },
                    { new Guid("3e76ae20-2614-4b40-a962-f55555087bae"), "44ce48c0-b315-44fb-a737-936a24f458e4", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityAddress", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0cd247a9-1ffe-4701-98b2-59f8d914d428"), 0, "Makati", "182eb692-3faa-4f99-a626-8c11b493fdc0", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEBoZy2FRB7dOSupsrc2KeVLq9J7C0/06qLyZXChFEIIzYh0OQmM4CrH203MffzOXPw==", null, true, "", false, "su@crms.com" },
                    { new Guid("0de1f25e-9466-4e0f-8ee8-e31342a61ae3"), 0, "Makati", "34d8ad02-0348-477e-84e1-d32f0c897a80", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEFhbEu/dg3Tuhn4ruNH5tGS7vkMyGmIx/HF5AD21KfFtJvlNzBy/AZh8foHyGZoFgQ==", null, true, "", false, "user@crms.com" },
                    { new Guid("be8108c2-10df-4a36-94d0-28c59ba26f6f"), 0, "Makati", "75e25c42-d642-4eab-a82d-3ae8a84df889", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "sys@crms.com", true, "SYSTEM", "CRMS", true, null, "SYS@CRMS.COM", "SYSTEM", "AQAAAAEAACcQAAAAEIGXEQUF0kNDifPMKLs/793vOBa8RQtp8nLsbhZBnbEt3E/HfcZaAk9qsmnZC7FUmg==", null, true, "", false, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("49910645-e8bb-4477-bcf5-6961c76ee9aa"), "WhatsApp" },
                    { new Guid("5712d76f-3b52-49eb-953b-86a35885c1ca"), "Instagram" },
                    { new Guid("751811bb-dd5f-49b7-bee3-e79d7e031957"), "Test Message" },
                    { new Guid("7a158181-2cb7-4027-93df-88fd0e7af42e"), "Email" },
                    { new Guid("a43a2215-cadd-4329-8f0f-0e3cf2975a1a"), "Facebook" },
                    { new Guid("a9501733-b1e8-4262-b736-8c2ccfbd82de"), "Line" },
                    { new Guid("d1d9438b-ab8b-4916-8234-9be248c0075f"), "Others" },
                    { new Guid("f5c2a3ee-68fc-4829-814a-0e4d68eaf8a2"), "Phone Call" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("1b337aa3-8b2b-4f6b-94bc-e8e96fe3f1e9"), "Not Read" },
                    { new Guid("1c0d88fe-7b56-4d53-8b4a-ad41ae912961"), "Good Engagement" },
                    { new Guid("3f429b6f-33e2-4ffc-99df-81f6cf645009"), "Read but no response" },
                    { new Guid("facb73ff-5526-40ca-be28-fdc4ca7f6728"), "Simple Response" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("0de31afd-d659-4c1a-a8cd-5c27fb19a360"), "Discount" },
                    { new Guid("1550ba58-0d8d-4153-962a-c5093db7c1b2"), "New Product" },
                    { new Guid("1b36ae57-6621-40ea-812c-b5116182d8c9"), "Congratulations" },
                    { new Guid("5e9cbdb7-2823-4ed4-b2fe-cbc0475c5d17"), "Anniversary" },
                    { new Guid("69baf32f-ac19-4b94-b187-f5c16a3f5b0c"), "Company News" },
                    { new Guid("b68cd17a-b0f2-4a98-8a4e-2996e37b9d8c"), "Birthday" },
                    { new Guid("c47497f7-566b-4f0e-9eb5-f1f4860f11f8"), "Holiday" },
                    { new Guid("ebd43c84-b692-4cee-a81b-d02ec9767f68"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("2a8d07ca-48df-49d9-a99f-016b5460d3f1"), "Others" },
                    { new Guid("344c3cf8-dd11-4be7-a038-1b9b1c6d6225"), "Social Media" },
                    { new Guid("432c211e-8d3d-424a-bcd9-944c6a19722c"), "Webinar" },
                    { new Guid("7788bb4d-3421-4c45-bfe7-8d5c439788c9"), "Compony-Generated" },
                    { new Guid("bd6cd130-a965-435c-917b-70ae35eb9648"), "Referral" },
                    { new Guid("f5ff4166-2ca9-4438-815f-7f8e85698ae8"), "Friend" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("073406cc-5829-4510-97e5-49642b5b01b8"), "Contacted" },
                    { new Guid("4016a6f4-9688-4ce3-adbd-54801ab95b98"), "Proposal Generated" },
                    { new Guid("bae12886-507d-466f-8928-7469680d821d"), "Policy Issued" },
                    { new Guid("bf6676b5-4c03-402c-a5ec-849b8a32f2bf"), "Lead is Dead" },
                    { new Guid("c5aa33a2-cce6-4455-874b-c195160c320b"), "Application Submitted" },
                    { new Guid("c87edbd6-bbbf-4bb0-aca7-2c62bf8c85c0"), "Met" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("2f27f58a-382d-42d6-8e7e-c3f64dea0b9a"), new Guid("0cd247a9-1ffe-4701-98b2-59f8d914d428") });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "UpdateDate", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("27e4f7e4-e9c3-48af-8645-e9c4e5a30b4c"), new Guid("0de1f25e-9466-4e0f-8ee8-e31342a61ae3"), new Guid("0de1f25e-9466-4e0f-8ee8-e31342a61ae3"), new DateTime(2023, 4, 14, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5644), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5642), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321", new DateTime(2023, 4, 17, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5644), new Guid("be8108c2-10df-4a36-94d0-28c59ba26f6f") },
                    { new Guid("6766a803-0936-4316-b4ae-202509af9329"), new Guid("0cd247a9-1ffe-4701-98b2-59f8d914d428"), new Guid("0de1f25e-9466-4e0f-8ee8-e31342a61ae3"), new DateTime(2023, 4, 12, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5632), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5623), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789", new DateTime(2023, 4, 17, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5633), new Guid("be8108c2-10df-4a36-94d0-28c59ba26f6f") },
                    { new Guid("a7710c8e-6a00-4f5d-b647-1b707210e83b"), new Guid("0cd247a9-1ffe-4701-98b2-59f8d914d428"), null, new DateTime(2023, 4, 17, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5614), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812", new DateTime(2023, 4, 17, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5615), new Guid("be8108c2-10df-4a36-94d0-28c59ba26f6f") }
                });
        }
    }
}
