using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("1c6b2da7-a90d-41b4-85e7-f9f71919933e"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("259966ad-c606-4174-9ce7-e33944b5992f"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("cd3dd1c2-a44f-4722-a4b3-81939d945576"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("d912449e-d6a8-4a12-884a-7efc1d587035"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("e81c434c-d502-4868-90f9-d686d75ddf79"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1779d278-b5fe-4ade-8d3c-ad713b2b6de7"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("32ffee76-0ab3-4393-976b-831d4ffd79ef"), new Guid("de6ea7f0-f294-49a4-8c23-a6b581f0885c") });

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("5ff68057-586c-4ec9-8bdf-17dc9b399cfc"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("98577cc3-7f54-4a96-b2d5-dbbccd092bd8"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("b9806987-1258-4896-aef6-25d017a108d6"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("007b1501-fe50-40eb-93ff-5d3969acdd58"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("12a27f90-b879-4989-8d89-9b47f1fcbd9e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("13010292-382c-45dd-9bcb-8a4cb11a798e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("683225c2-7772-4225-849f-978566015ffa"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("6fabd68a-3f4d-4469-a374-a1cd7c098121"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("82bc9a89-3bd2-423f-b579-c03555a4da10"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("84645044-15d4-4b49-bb82-716f338c6936"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("f5b22b63-e6cf-40c7-a970-1c8797df53dc"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("8d600af8-645e-424e-9691-6b544e52ba0e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("c4fa6dd9-10b2-4e45-8c77-a8ca13e5a59c"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("c5f6779f-298b-4f26-842d-4de134ac29ef"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("d8e3b099-00a5-4836-b1fa-bd2200b986bf"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("2ed21d1f-e7b0-4432-9e2f-31ef30408f30"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("597a122f-9b56-4357-a1c6-546f1ef1c136"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("5e2add1e-0fa7-40c2-ab40-e0a1cc74a2cf"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("5f372d3d-d4c8-45d2-9c87-d6f2fc4403e7"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("7a210eeb-91d3-4f14-acad-214f4daf86ae"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("7ffa0f8e-9115-455a-92fe-cd60903c604b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("8478e546-e885-4bcd-a90d-eeb0db057b50"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("a0a3c699-db4c-47eb-89f7-993fb143db89"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("24a4192b-d003-48a4-b8d4-419c49c0569c"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("4f071cae-e9f3-4e12-abcf-a674faf81e57"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("66dcab81-dce9-4937-9b0d-7f801eb5e279"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("a64308d3-8c2e-4948-bdf1-ae3cfba1d804"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("ab3333f4-3871-40f9-b5bb-eb7ba6c3c0c1"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("ccb4a93b-43ac-4c7a-965c-390f0cc97f59"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("0b43b949-5466-4462-94a3-c21f3ad4b4c9"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("22a78a37-1f46-4687-82ba-b135a9651e77"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("3b436876-a805-4535-965c-6fb70bfe222d"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("7284c62c-3093-4197-8740-52148c384353"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("ebd9a39c-5882-49a8-86be-d85ed641b095"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("faeba0a7-2114-4a8f-bae6-677702c84425"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32ffee76-0ab3-4393-976b-831d4ffd79ef"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("571501c2-00c0-4d58-83f3-3a6d6c0773f6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c27a14fa-38e2-4920-94b8-60ca0414c392"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("de6ea7f0-f294-49a4-8c23-a6b581f0885c"));

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("416b59c0-7b1f-4859-ab78-3c832914691c"), "Sales Closing" },
                    { new Guid("6ae8548d-7aee-4d12-92c7-9fd2ad3dd2d6"), "Others" },
                    { new Guid("6c90af9d-59ce-4cc7-82d0-a2e2c184c52e"), "Proposal" },
                    { new Guid("9b667817-f2ed-46e3-aa6e-96b5a1f09834"), "Fact-Find" },
                    { new Guid("f0b1269c-2ddc-4366-9130-ac8f9bf7088c"), "Presentation" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1ff56645-9315-451b-9eee-1bfbcad6f7d8"), "424a3080-b4fc-46ee-8a19-64943a6599b6", "Admin", "ADMIN" },
                    { new Guid("61683179-00c1-43e7-ac74-2a7d4ee40f55"), "a1e039bd-e598-4b4d-9d7e-5c711c56e264", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityAddress", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1be337e7-794a-4ede-a774-858204402667"), 0, "Makati", "65f9cde3-3d46-44da-8b05-9538e74eacad", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "sys@crms.com", true, "SYSTEM", "CRMS", true, null, "SYS@CRMS.COM", "SYSTEM", "AQAAAAEAACcQAAAAEEACjz1UeqxHS59DrJACbxewFDM/8i2yHeaLAZ/DI1IdAhTvj0Fv603+7OVF2ya9hg==", null, true, "", false, "SYSTEM" },
                    { new Guid("3dd936c0-ee7e-47e7-b516-ab2a6e84368f"), 0, "Makati", "4968f870-e712-4a64-9be4-4cd79e895173", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEHn6Pf4Q+3Q0HT90yn8XIJY4Yts6aKdxwMhw4gmKpS12a68Jw2jUGgGGNlekK3U4pA==", null, true, "", false, "su@crms.com" },
                    { new Guid("5014a0ee-ffe5-4f55-acad-44a5ce34e96b"), 0, "Makati", "fb83465a-6789-431c-b1fc-f104678dc141", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAELvE14QnDHqDASjcgWOiftcFJYmvlZjbGpM5eI8mmA6/VjmjD1fTjCQ6hUduYXhVDQ==", null, true, "", false, "user@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("1ae132b1-d306-4ba9-992b-d7e21661226e"), "Others" },
                    { new Guid("4d140d69-928c-4ed1-8322-9e0731acffe0"), "Phone Call" },
                    { new Guid("702574f9-e31a-46a6-860d-f6e64fe8dfab"), "Line" },
                    { new Guid("7d48eca7-6ba8-4f59-8df6-5e602d59a928"), "Instagram" },
                    { new Guid("84846fb6-c670-4f44-9841-3127b706e842"), "Test Message" },
                    { new Guid("ccb43ecc-be8f-4486-b92b-80f913b49b10"), "WhatsApp" },
                    { new Guid("cd161033-4cd9-4c7a-bf97-bb85686a1982"), "Email" },
                    { new Guid("ea62ba54-c7dc-4848-8a0f-ff243c4b3847"), "Facebook" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("0ffeaf0f-6288-44bd-bfe7-c209885f89a1"), "Simple Response" },
                    { new Guid("243a4876-6f33-400d-96ec-aebbc79a2524"), "Read but no response" },
                    { new Guid("5a984e08-fd74-4ea0-a34b-dd415e961496"), "Good Engagement" },
                    { new Guid("6132df83-edf5-4fff-8ab3-cb8da6e71643"), "Not Read" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("0b79eb92-ffbf-4f59-a828-d052679c60bd"), "New Product" },
                    { new Guid("3f9968c9-2d19-4ebf-930f-ff54a939b769"), "Congratulations" },
                    { new Guid("506bcdcf-7ba5-4b57-81ef-d0959cf62fd2"), "Others" },
                    { new Guid("5a143199-b278-4257-8cb5-6a58b02b5c70"), "Birthday" },
                    { new Guid("5ba37fee-1ddb-4ee9-9e8b-753887374994"), "Holiday" },
                    { new Guid("5c29c515-d85f-4428-b56a-950768118dd1"), "Company News" },
                    { new Guid("9b5bb143-26aa-40d1-bdfd-d703363345f7"), "Anniversary" },
                    { new Guid("cf31916d-5950-43a9-ba9a-ff87c7fad606"), "Discount" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("3ee0a89e-4e60-430c-aa03-464454a22896"), "Webinar" },
                    { new Guid("4af9c0b4-b264-4cde-b2d2-01e9dd0715be"), "Friend" },
                    { new Guid("5767ebdb-9267-418b-813c-36f45f434623"), "Social Media" },
                    { new Guid("a7bc9458-513d-4853-8e36-88c180918fb1"), "Compony-Generated" },
                    { new Guid("d07993cc-539c-471a-a746-fd9759d1d142"), "Others" },
                    { new Guid("fa0c7bae-1ee4-4b53-849d-3806d8c2f499"), "Referral" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("2b757f5f-76d5-4ac3-a81b-a080430c1aae"), "Lead is Dead" },
                    { new Guid("82290c2e-a7fa-493c-940a-4597668bc95c"), "Contacted" },
                    { new Guid("94a0f72b-4d9d-4661-96e3-58536617aca4"), "Proposal Generated" },
                    { new Guid("c1213527-3e7d-4f68-b030-41bd47b40df7"), "Policy Issued" },
                    { new Guid("d591a0d6-358d-4ec8-9102-11ca0d464473"), "Application Submitted" },
                    { new Guid("ed887ed9-11ce-47cf-9689-c8c6a973de0d"), "Met" }
                });

            migrationBuilder.InsertData(
                table: "PRODUCTS",
                columns: new[] { "Product_Id", "Benefits", "ProductDescription", "ProductName", "UpdateDate", "UpdatedBy", "UpdaterId" },
                values: new object[,]
                {
                    { new Guid("2461b8e5-9300-4d2f-bc7a-7919fe067b1c"), "The Policy is Effective for one (1) year from the date of issuance or after payment of claim,whichever comes first.", "covers the medical expenses incurred within a year from the date of issuance or purchase by the InsuredPerson for the treatment of an eligible emergency condition, availment of which caneither be as an Out-Patient in the Emergency Room Department or as an In-Patient of aHospital via cash assistance.", "CL ER Care", new DateTime(2023, 4, 17, 8, 16, 41, 531, DateTimeKind.Local).AddTicks(3421), new Guid("1be337e7-794a-4ede-a774-858204402667"), null },
                    { new Guid("514b2398-20d6-435d-9ff7-d34619743c38"), "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Cash Assistance Due to Food Poisoning", "CL Personal Accident Nano Insurance covers loss for Accidental Death, Disablement, or Dismemberment, and Cash Assistance due to Food Poisoning.", "CL Personal Accident Nano", new DateTime(2023, 4, 17, 8, 16, 41, 531, DateTimeKind.Local).AddTicks(3379), new Guid("1be337e7-794a-4ede-a774-858204402667"), null },
                    { new Guid("5d5d6f5c-dd62-42d7-b3ae-4f9fce39f1e0"), "Death Benefit, Accident or Sickness Emergency Cash Assistance, Accidental Dismemberment and/or Disablement, Murder and Unprovoked Assault and Residential Fire Reconstruction cash assistance", "For as low as P50, each certificate is valid for four (4) months from the date of issuance and can be availed up to a maximum of 5 certificates per insured.", "ProtectMAX", new DateTime(2023, 4, 17, 8, 16, 41, 531, DateTimeKind.Local).AddTicks(3403), new Guid("1be337e7-794a-4ede-a774-858204402667"), null },
                    { new Guid("631e9067-91cd-416b-a8b2-c46e51eb71d9"), "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Accidental Burial Benefit, Cash Assistance Benefit, Fire Cash Assistance", "CL Personal Accident Nano Plus Insurance covers Accidental Death, Disablement, or Dismemberment, Accident Medical Reimbursement, Accident Burial Benefit, Cash Assistance benefit, and Fire Cash Assistance.", "CL Personal Accident Nano Plus", new DateTime(2023, 4, 17, 8, 16, 41, 531, DateTimeKind.Local).AddTicks(3397), new Guid("1be337e7-794a-4ede-a774-858204402667"), null },
                    { new Guid("9292b4e4-2c27-4c22-811e-1eea4e43c412"), "Earthquake, Typhoon, Flood, Windstorm, Volcanic Eruption and other Acts of Nature, Extended Coverage, BOWTAP, BWD, SL and other water related damages, Vandalism/Spontaneous Combustion, All Other Losses", "CL MicroEnterpriseProtekis a Property Insurance Program specially designed for Cebuana Lhuillier clients. It covers loss “ALL Risks” of physical loss, destruction of or damage to the property of the insured and wholly attributable to any sudden and unforeseen cause, except as hereinafter excluded, occurring during the currency of the policy.", "CL MicroEnterpriseProtek", new DateTime(2023, 4, 17, 8, 16, 41, 531, DateTimeKind.Local).AddTicks(3400), new Guid("1be337e7-794a-4ede-a774-858204402667"), null },
                    { new Guid("bbe30bce-1777-4fa1-af9b-6ef43829cff4"), "Accidental Death, Accidental Dismemberment and/or Disablement", "Covers Accidental Death and Accidental Dismemberment and/or Disablement Benefit.", "CL Personal Accident Basic", new DateTime(2023, 4, 17, 8, 16, 41, 531, DateTimeKind.Local).AddTicks(3416), new Guid("1be337e7-794a-4ede-a774-858204402667"), null },
                    { new Guid("d8557dde-e7f4-4afd-a6a9-08217dae6ec5"), "24/7 Call-a-doc, OP ER One Time use (All causes), Daily Hospital Income Benefit (All Causes)", "An Individual Personal Accident Insurance specifically designed for Cebuana Lhuillier clients.It covers Accidental Death and Disability (AD&D), Double Indemnity, 24/7 Call-a-doc, OP ER One Time use and Daily Hospital Income Benefit.", "CL Health Care", new DateTime(2023, 4, 17, 8, 16, 41, 531, DateTimeKind.Local).AddTicks(3407), new Guid("1be337e7-794a-4ede-a774-858204402667"), null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("1ff56645-9315-451b-9eee-1bfbcad6f7d8"), new Guid("3dd936c0-ee7e-47e7-b516-ab2a6e84368f") });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "UpdateDate", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("52de1678-a7ad-444b-8f62-242cf49d1af0"), new Guid("3dd936c0-ee7e-47e7-b516-ab2a6e84368f"), null, new DateTime(2023, 4, 17, 8, 16, 41, 531, DateTimeKind.Local).AddTicks(3312), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812", new DateTime(2023, 4, 17, 8, 16, 41, 531, DateTimeKind.Local).AddTicks(3314), new Guid("1be337e7-794a-4ede-a774-858204402667") },
                    { new Guid("988a1fb1-ce0c-4ebc-9148-b8d9a2496527"), new Guid("3dd936c0-ee7e-47e7-b516-ab2a6e84368f"), new Guid("5014a0ee-ffe5-4f55-acad-44a5ce34e96b"), new DateTime(2023, 4, 12, 8, 16, 41, 531, DateTimeKind.Local).AddTicks(3345), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 8, 16, 41, 531, DateTimeKind.Local).AddTicks(3330), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789", new DateTime(2023, 4, 17, 8, 16, 41, 531, DateTimeKind.Local).AddTicks(3346), new Guid("1be337e7-794a-4ede-a774-858204402667") },
                    { new Guid("d37bbab2-3958-4c05-82ea-759de20c4223"), new Guid("5014a0ee-ffe5-4f55-acad-44a5ce34e96b"), new Guid("5014a0ee-ffe5-4f55-acad-44a5ce34e96b"), new DateTime(2023, 4, 14, 8, 16, 41, 531, DateTimeKind.Local).AddTicks(3369), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 8, 16, 41, 531, DateTimeKind.Local).AddTicks(3365), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321", new DateTime(2023, 4, 17, 8, 16, 41, 531, DateTimeKind.Local).AddTicks(3370), new Guid("1be337e7-794a-4ede-a774-858204402667") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("416b59c0-7b1f-4859-ab78-3c832914691c"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("6ae8548d-7aee-4d12-92c7-9fd2ad3dd2d6"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("6c90af9d-59ce-4cc7-82d0-a2e2c184c52e"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("9b667817-f2ed-46e3-aa6e-96b5a1f09834"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("f0b1269c-2ddc-4366-9130-ac8f9bf7088c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("61683179-00c1-43e7-ac74-2a7d4ee40f55"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1ff56645-9315-451b-9eee-1bfbcad6f7d8"), new Guid("3dd936c0-ee7e-47e7-b516-ab2a6e84368f") });

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("52de1678-a7ad-444b-8f62-242cf49d1af0"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("988a1fb1-ce0c-4ebc-9148-b8d9a2496527"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("d37bbab2-3958-4c05-82ea-759de20c4223"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("1ae132b1-d306-4ba9-992b-d7e21661226e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("4d140d69-928c-4ed1-8322-9e0731acffe0"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("702574f9-e31a-46a6-860d-f6e64fe8dfab"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("7d48eca7-6ba8-4f59-8df6-5e602d59a928"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("84846fb6-c670-4f44-9841-3127b706e842"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("ccb43ecc-be8f-4486-b92b-80f913b49b10"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("cd161033-4cd9-4c7a-bf97-bb85686a1982"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("ea62ba54-c7dc-4848-8a0f-ff243c4b3847"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("0ffeaf0f-6288-44bd-bfe7-c209885f89a1"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("243a4876-6f33-400d-96ec-aebbc79a2524"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("5a984e08-fd74-4ea0-a34b-dd415e961496"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("6132df83-edf5-4fff-8ab3-cb8da6e71643"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("0b79eb92-ffbf-4f59-a828-d052679c60bd"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("3f9968c9-2d19-4ebf-930f-ff54a939b769"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("506bcdcf-7ba5-4b57-81ef-d0959cf62fd2"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("5a143199-b278-4257-8cb5-6a58b02b5c70"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("5ba37fee-1ddb-4ee9-9e8b-753887374994"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("5c29c515-d85f-4428-b56a-950768118dd1"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("9b5bb143-26aa-40d1-bdfd-d703363345f7"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("cf31916d-5950-43a9-ba9a-ff87c7fad606"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("3ee0a89e-4e60-430c-aa03-464454a22896"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("4af9c0b4-b264-4cde-b2d2-01e9dd0715be"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("5767ebdb-9267-418b-813c-36f45f434623"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("a7bc9458-513d-4853-8e36-88c180918fb1"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("d07993cc-539c-471a-a746-fd9759d1d142"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("fa0c7bae-1ee4-4b53-849d-3806d8c2f499"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("2b757f5f-76d5-4ac3-a81b-a080430c1aae"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("82290c2e-a7fa-493c-940a-4597668bc95c"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("94a0f72b-4d9d-4661-96e3-58536617aca4"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("c1213527-3e7d-4f68-b030-41bd47b40df7"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("d591a0d6-358d-4ec8-9102-11ca0d464473"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("ed887ed9-11ce-47cf-9689-c8c6a973de0d"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("2461b8e5-9300-4d2f-bc7a-7919fe067b1c"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("514b2398-20d6-435d-9ff7-d34619743c38"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("5d5d6f5c-dd62-42d7-b3ae-4f9fce39f1e0"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("631e9067-91cd-416b-a8b2-c46e51eb71d9"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("9292b4e4-2c27-4c22-811e-1eea4e43c412"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("bbe30bce-1777-4fa1-af9b-6ef43829cff4"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Product_Id",
                keyValue: new Guid("d8557dde-e7f4-4afd-a6a9-08217dae6ec5"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1ff56645-9315-451b-9eee-1bfbcad6f7d8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1be337e7-794a-4ede-a774-858204402667"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3dd936c0-ee7e-47e7-b516-ab2a6e84368f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5014a0ee-ffe5-4f55-acad-44a5ce34e96b"));

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("1c6b2da7-a90d-41b4-85e7-f9f71919933e"), "Sales Closing" },
                    { new Guid("259966ad-c606-4174-9ce7-e33944b5992f"), "Proposal" },
                    { new Guid("cd3dd1c2-a44f-4722-a4b3-81939d945576"), "Others" },
                    { new Guid("d912449e-d6a8-4a12-884a-7efc1d587035"), "Fact-Find" },
                    { new Guid("e81c434c-d502-4868-90f9-d686d75ddf79"), "Presentation" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1779d278-b5fe-4ade-8d3c-ad713b2b6de7"), "096b786f-f401-4674-b068-a2682bd14195", "User", "USER" },
                    { new Guid("32ffee76-0ab3-4393-976b-831d4ffd79ef"), "465d871b-4e6a-4480-b26f-8ca7d0126576", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityAddress", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("571501c2-00c0-4d58-83f3-3a6d6c0773f6"), 0, "Makati", "16c198e9-f654-42a6-ac47-6ba3f711fe96", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEBWVPmA0ykjxeXweW3LbcweumNPySKCd3OgALSWtWb3DBupmfWwqG9AREOUr2HyQMw==", null, true, "", false, "user@crms.com" },
                    { new Guid("c27a14fa-38e2-4920-94b8-60ca0414c392"), 0, "Makati", "0f39dbd7-65d6-4ec4-a90a-4bac02d486f2", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "sys@crms.com", true, "SYSTEM", "CRMS", true, null, "SYS@CRMS.COM", "SYSTEM", "AQAAAAEAACcQAAAAEPX93OFVysS+9HQTgR7hKZhkYctF9DWjHe8YW2F7BZ7UFPQREg8zaNbm1F2brWX/yg==", null, true, "", false, "SYSTEM" },
                    { new Guid("de6ea7f0-f294-49a4-8c23-a6b581f0885c"), 0, "Makati", "1bf61cb3-59ed-4b09-b214-f7921cca9edf", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEIu8LkLyqPiH/7s5XvMxCxqSlUjRazxuEHmKkogjyc/89xI175lJExvalZyJFyN5WQ==", null, true, "", false, "su@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("007b1501-fe50-40eb-93ff-5d3969acdd58"), "Line" },
                    { new Guid("12a27f90-b879-4989-8d89-9b47f1fcbd9e"), "Phone Call" },
                    { new Guid("13010292-382c-45dd-9bcb-8a4cb11a798e"), "Facebook" },
                    { new Guid("683225c2-7772-4225-849f-978566015ffa"), "WhatsApp" },
                    { new Guid("6fabd68a-3f4d-4469-a374-a1cd7c098121"), "Email" },
                    { new Guid("82bc9a89-3bd2-423f-b579-c03555a4da10"), "Instagram" },
                    { new Guid("84645044-15d4-4b49-bb82-716f338c6936"), "Test Message" },
                    { new Guid("f5b22b63-e6cf-40c7-a970-1c8797df53dc"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("8d600af8-645e-424e-9691-6b544e52ba0e"), "Not Read" },
                    { new Guid("c4fa6dd9-10b2-4e45-8c77-a8ca13e5a59c"), "Read but no response" },
                    { new Guid("c5f6779f-298b-4f26-842d-4de134ac29ef"), "Good Engagement" },
                    { new Guid("d8e3b099-00a5-4836-b1fa-bd2200b986bf"), "Simple Response" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("2ed21d1f-e7b0-4432-9e2f-31ef30408f30"), "Congratulations" },
                    { new Guid("597a122f-9b56-4357-a1c6-546f1ef1c136"), "Company News" },
                    { new Guid("5e2add1e-0fa7-40c2-ab40-e0a1cc74a2cf"), "Discount" },
                    { new Guid("5f372d3d-d4c8-45d2-9c87-d6f2fc4403e7"), "Anniversary" },
                    { new Guid("7a210eeb-91d3-4f14-acad-214f4daf86ae"), "Birthday" },
                    { new Guid("7ffa0f8e-9115-455a-92fe-cd60903c604b"), "Holiday" },
                    { new Guid("8478e546-e885-4bcd-a90d-eeb0db057b50"), "Others" },
                    { new Guid("a0a3c699-db4c-47eb-89f7-993fb143db89"), "New Product" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("24a4192b-d003-48a4-b8d4-419c49c0569c"), "Compony-Generated" },
                    { new Guid("4f071cae-e9f3-4e12-abcf-a674faf81e57"), "Others" },
                    { new Guid("66dcab81-dce9-4937-9b0d-7f801eb5e279"), "Social Media" },
                    { new Guid("a64308d3-8c2e-4948-bdf1-ae3cfba1d804"), "Referral" },
                    { new Guid("ab3333f4-3871-40f9-b5bb-eb7ba6c3c0c1"), "Webinar" },
                    { new Guid("ccb4a93b-43ac-4c7a-965c-390f0cc97f59"), "Friend" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("0b43b949-5466-4462-94a3-c21f3ad4b4c9"), "Proposal Generated" },
                    { new Guid("22a78a37-1f46-4687-82ba-b135a9651e77"), "Lead is Dead" },
                    { new Guid("3b436876-a805-4535-965c-6fb70bfe222d"), "Application Submitted" },
                    { new Guid("7284c62c-3093-4197-8740-52148c384353"), "Met" },
                    { new Guid("ebd9a39c-5882-49a8-86be-d85ed641b095"), "Policy Issued" },
                    { new Guid("faeba0a7-2114-4a8f-bae6-677702c84425"), "Contacted" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("32ffee76-0ab3-4393-976b-831d4ffd79ef"), new Guid("de6ea7f0-f294-49a4-8c23-a6b581f0885c") });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "UpdateDate", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("5ff68057-586c-4ec9-8bdf-17dc9b399cfc"), new Guid("de6ea7f0-f294-49a4-8c23-a6b581f0885c"), null, new DateTime(2023, 4, 17, 3, 35, 27, 919, DateTimeKind.Local).AddTicks(3981), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812", new DateTime(2023, 4, 17, 3, 35, 27, 919, DateTimeKind.Local).AddTicks(3981), new Guid("c27a14fa-38e2-4920-94b8-60ca0414c392") },
                    { new Guid("98577cc3-7f54-4a96-b2d5-dbbccd092bd8"), new Guid("571501c2-00c0-4d58-83f3-3a6d6c0773f6"), new Guid("571501c2-00c0-4d58-83f3-3a6d6c0773f6"), new DateTime(2023, 4, 14, 3, 35, 27, 919, DateTimeKind.Local).AddTicks(4008), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 3, 35, 27, 919, DateTimeKind.Local).AddTicks(4006), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321", new DateTime(2023, 4, 17, 3, 35, 27, 919, DateTimeKind.Local).AddTicks(4009), new Guid("c27a14fa-38e2-4920-94b8-60ca0414c392") },
                    { new Guid("b9806987-1258-4896-aef6-25d017a108d6"), new Guid("de6ea7f0-f294-49a4-8c23-a6b581f0885c"), new Guid("571501c2-00c0-4d58-83f3-3a6d6c0773f6"), new DateTime(2023, 4, 12, 3, 35, 27, 919, DateTimeKind.Local).AddTicks(4000), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 3, 35, 27, 919, DateTimeKind.Local).AddTicks(3991), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789", new DateTime(2023, 4, 17, 3, 35, 27, 919, DateTimeKind.Local).AddTicks(4002), new Guid("c27a14fa-38e2-4920-94b8-60ca0414c392") }
                });
        }
    }
}
