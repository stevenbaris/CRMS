using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class addedUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("2c2e9c29-ccbc-4b2c-a9ee-81146e2de22d"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("3c769188-8a68-4037-b51a-2fb189497cfb"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("d3ba75bc-5de4-478d-8a66-5f2bd2cec4a5"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("f01f9eb8-fc9d-47a3-bfb6-8d44e2f43cb3"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("f8ba08e6-9cf1-41c3-a5d5-7cc3032dcec6"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("40368af9-c08f-4bfd-8dad-d529b7f4d5da"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("92d989ba-61b8-4b4a-887c-b554564212a6"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("6d8948fe-a12b-462f-871e-838514a5069d"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("b337a669-b852-4f66-9f3d-9b65b0d5ce2a"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("ef2c8661-9546-4084-99e8-859b4a90ff9c"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("16cb0bc3-0917-43bf-b8c9-a066db7bb491"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("191a15fe-8c17-445a-ad9d-2991e279a03e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("4b617ec1-8f50-4d10-abaf-5ff831595620"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("4faee073-d67e-4a82-922c-6cc814185927"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("98b623df-5371-4865-b2f8-5a226df78824"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("bb192721-2f23-4457-8c9e-aae49bd77353"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("c392e798-86ea-4d92-83cf-4955897d9b46"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("fae361ed-0cc7-48cc-a644-e47409de679d"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("09f4a7dc-3e62-4c5d-b914-f32901d07a23"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("86d5f475-1994-4aad-ad38-b4016405acfa"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("ad42a22b-7bbe-405b-87cf-c4a20c79feb7"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("c51eef35-b1fa-413d-958a-bc8840f26928"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("12b11e9c-f21e-4227-9c0f-f49748ba134e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("2158254d-b77a-46ff-b1c8-8dd1c1b9052b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("24293c33-f2d7-4c9a-8e11-e9db5e5eda44"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("5ef89411-83c3-4fac-9f9d-bb1e665fd2d1"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("7315d6e7-394b-4d0b-8a63-d467908b5cf0"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("790dbbbf-0ba3-4592-86c8-836c6cab6460"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("7e99f307-8575-47a8-a536-0efb24329cee"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("af8f7919-f4ae-400c-87f3-adb24e9b35fe"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("17e9cae5-67aa-482b-a5c1-53aaf940327e"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("3866c319-dd60-4a10-b8ad-4d5f25916a18"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("87950063-698c-4959-8344-ba26ac5f05e5"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("ae0684b2-b30d-43fd-9604-776413ee7f79"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("cc2865b0-4cab-4fdf-82a8-c901aa84fa0d"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("f83c544b-2483-4c6f-825b-dca08d514380"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("25093e02-9a84-49d8-a43d-ec3f78224b63"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("3c485316-e5c2-4787-92ff-40373b84e8d4"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("415448d8-ed1e-418a-8bd9-5e8883d6c779"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("c9421ef5-5fe4-466b-af82-1ce5925c8f75"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("e690baf4-c476-48f1-a1ec-98e13cec9368"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("fd24cec1-f933-48b2-b781-b64adbfd0b98"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("29fadd6d-c7a9-4475-94f2-d79e0d30fb91"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3298c81c-5d07-4b39-8fa0-15be079c7021"));

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("153157d4-1b89-4df9-b946-c1eef0ad79c5"), "Proposal" },
                    { new Guid("66260d6c-9320-4865-b9ac-37a3c2a9679f"), "Fact-Find" },
                    { new Guid("82999b2f-72cc-49b7-ba5d-a9da43bba95b"), "Others" },
                    { new Guid("ab06e970-7d3d-48c6-8153-620c81540654"), "Presentation" },
                    { new Guid("db4c23d9-02fe-4a4f-8260-abcbe4d47ace"), "Sales Closing" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("9897b960-b78a-4dcb-8dbb-5aa4774a7c67"), "cff24225-afb8-4cf3-9ef0-061013df60e5", "User", "USER" },
                    { new Guid("9cdb2ac5-0bd8-4644-a0a5-6f547f69d4e0"), "a7439c9a-ea40-4f4c-b33a-193c8cc68335", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("05614079-4a66-4ea5-9c1e-8feea31374e6"), 0, "PJ Lhuiller", "abd2feba-b411-4a77-a954-5e85abad0290", new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, null, null, "AQAAAAEAACcQAAAAEFPOHlU5ljarAm9NU1DmDdMrTFuf7R946ZoiluQzMhHygPUjP8ndLHHaxuL72K1rrA==", null, true, "", false, "su@crms.com" },
                    { new Guid("a9091087-9c9e-4a1d-9e0c-bdb10c97d3e0"), 0, "PJ Lhuiller", "fd1a2dcf-66e0-4447-8054-6dc4ab1a6ce5", new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, null, null, "AQAAAAEAACcQAAAAECZmqhry/4Y6iScPvJK0tcoPltww0S3KDo/gY4Is0ialAjFZ1sjXs/f8qybuE/UoNg==", null, true, "", false, "user@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("1eb1d725-831f-434b-97d2-733e63023ed1"), "Others" },
                    { new Guid("24726c5f-8159-4437-8f27-a31adc83a404"), "Instagram" },
                    { new Guid("417e9bba-0ccd-49e3-ab65-a7c7545ddcdf"), "Email" },
                    { new Guid("8b4dd61e-c431-43fc-8548-8e96f35172fb"), "Phone Call" },
                    { new Guid("aee7553e-f369-414f-ba7b-88e96f576e80"), "WhatsApp" },
                    { new Guid("bf8c9d19-8098-4590-801a-33f4af87429e"), "Facebook" },
                    { new Guid("c71360c7-fac1-4e12-a233-4f1dac6fb236"), "Test Message" },
                    { new Guid("cccfcc23-3b8a-4d48-80ae-79dd4db9c301"), "Line" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("0eab5b4e-aef8-469d-b19d-ec4a0bdd88dd"), "Not Read" },
                    { new Guid("a00c701a-6531-4562-b797-0618ad8b7a3d"), "Good Engagement" },
                    { new Guid("a56b1387-6f3c-47b6-9142-020f24b0f98b"), "Simple Response" },
                    { new Guid("fd625ec7-ff91-4bac-84e6-3604b14b6945"), "Read but no response" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("15bcbf4b-18e4-4874-91cf-6ea7b4ae1d96"), "Birthday" },
                    { new Guid("16be768f-3596-40af-8da3-996a96105bd5"), "Congratulations" },
                    { new Guid("83ab06e7-be5a-40f7-876b-3b5e756de2e9"), "Anniversary" },
                    { new Guid("8590b048-5fd1-4cdc-9da2-446d99528c0f"), "Holiday" },
                    { new Guid("88ca8fb3-a5d8-477d-9398-04b264b4cdaa"), "Discount" },
                    { new Guid("97918d84-9fc0-4f91-a561-5fe06347b805"), "Company News" },
                    { new Guid("aea3554b-e96c-4e4d-8a61-fb82a4993d46"), "Others" },
                    { new Guid("df40bf69-76f6-4577-871a-ca9d2612ada3"), "New Product" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("1c0c6814-91b3-491c-a0fd-11a6363439e3"), "Referral" },
                    { new Guid("4cd61380-7458-4c37-bd53-b3e37670eec6"), "Compony-Generated" },
                    { new Guid("6c1e24ec-0d6d-4696-882b-9e0e12ec34f8"), "Webinar" },
                    { new Guid("6d241113-b946-4f62-9f1a-484eaff08112"), "Social Media" },
                    { new Guid("9969b413-ffdc-47c7-8751-28f28264a937"), "Others" },
                    { new Guid("bfc381cb-24ad-4e88-93d9-5ee9d4d79394"), "Friend" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("55cdc5e2-e052-44eb-9f4b-cf31ea318d28"), "Proposal Generated" },
                    { new Guid("8028f285-ca41-42ef-88d4-5fbe84ff8bec"), "Lead is Dead" },
                    { new Guid("81c9a988-8718-4437-822e-b4a2fc75517f"), "Policy Issued" },
                    { new Guid("a8352e2e-f523-4105-bca1-19773067b657"), "Application Submitted" },
                    { new Guid("c6d261f9-1090-4118-b7c3-8718a2624fef"), "Met" },
                    { new Guid("f78888a7-155d-4642-aab5-6d49e5e4324d"), "Contacted" }
                });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("731ffa68-1eba-41df-a2c8-c4e36c1c23f9"), new Guid("05614079-4a66-4ea5-9c1e-8feea31374e6"), new Guid("a9091087-9c9e-4a1d-9e0c-bdb10c97d3e0"), new DateTime(2023, 4, 3, 14, 43, 47, 715, DateTimeKind.Utc).AddTicks(2340), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 14, 43, 47, 715, DateTimeKind.Utc).AddTicks(2335), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789" });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("acf0c40b-a314-448f-bf8f-a34a4875bc1d"), new Guid("a9091087-9c9e-4a1d-9e0c-bdb10c97d3e0"), new Guid("a9091087-9c9e-4a1d-9e0c-bdb10c97d3e0"), new DateTime(2023, 4, 5, 14, 43, 47, 715, DateTimeKind.Utc).AddTicks(2344), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 14, 43, 47, 715, DateTimeKind.Utc).AddTicks(2343), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321" });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("b47a2aef-b052-498a-9290-e688edc428c0"), new Guid("05614079-4a66-4ea5-9c1e-8feea31374e6"), null, new DateTime(2023, 4, 8, 14, 43, 47, 715, DateTimeKind.Utc).AddTicks(2288), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("153157d4-1b89-4df9-b946-c1eef0ad79c5"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("66260d6c-9320-4865-b9ac-37a3c2a9679f"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("82999b2f-72cc-49b7-ba5d-a9da43bba95b"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("ab06e970-7d3d-48c6-8153-620c81540654"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("db4c23d9-02fe-4a4f-8260-abcbe4d47ace"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9897b960-b78a-4dcb-8dbb-5aa4774a7c67"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9cdb2ac5-0bd8-4644-a0a5-6f547f69d4e0"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("731ffa68-1eba-41df-a2c8-c4e36c1c23f9"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("acf0c40b-a314-448f-bf8f-a34a4875bc1d"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("b47a2aef-b052-498a-9290-e688edc428c0"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("1eb1d725-831f-434b-97d2-733e63023ed1"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("24726c5f-8159-4437-8f27-a31adc83a404"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("417e9bba-0ccd-49e3-ab65-a7c7545ddcdf"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("8b4dd61e-c431-43fc-8548-8e96f35172fb"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("aee7553e-f369-414f-ba7b-88e96f576e80"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("bf8c9d19-8098-4590-801a-33f4af87429e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("c71360c7-fac1-4e12-a233-4f1dac6fb236"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("cccfcc23-3b8a-4d48-80ae-79dd4db9c301"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("0eab5b4e-aef8-469d-b19d-ec4a0bdd88dd"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("a00c701a-6531-4562-b797-0618ad8b7a3d"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("a56b1387-6f3c-47b6-9142-020f24b0f98b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("fd625ec7-ff91-4bac-84e6-3604b14b6945"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("15bcbf4b-18e4-4874-91cf-6ea7b4ae1d96"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("16be768f-3596-40af-8da3-996a96105bd5"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("83ab06e7-be5a-40f7-876b-3b5e756de2e9"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("8590b048-5fd1-4cdc-9da2-446d99528c0f"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("88ca8fb3-a5d8-477d-9398-04b264b4cdaa"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("97918d84-9fc0-4f91-a561-5fe06347b805"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("aea3554b-e96c-4e4d-8a61-fb82a4993d46"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("df40bf69-76f6-4577-871a-ca9d2612ada3"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("1c0c6814-91b3-491c-a0fd-11a6363439e3"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("4cd61380-7458-4c37-bd53-b3e37670eec6"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("6c1e24ec-0d6d-4696-882b-9e0e12ec34f8"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("6d241113-b946-4f62-9f1a-484eaff08112"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("9969b413-ffdc-47c7-8751-28f28264a937"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("bfc381cb-24ad-4e88-93d9-5ee9d4d79394"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("55cdc5e2-e052-44eb-9f4b-cf31ea318d28"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("8028f285-ca41-42ef-88d4-5fbe84ff8bec"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("81c9a988-8718-4437-822e-b4a2fc75517f"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("a8352e2e-f523-4105-bca1-19773067b657"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("c6d261f9-1090-4118-b7c3-8718a2624fef"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("f78888a7-155d-4642-aab5-6d49e5e4324d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("05614079-4a66-4ea5-9c1e-8feea31374e6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a9091087-9c9e-4a1d-9e0c-bdb10c97d3e0"));

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("2c2e9c29-ccbc-4b2c-a9ee-81146e2de22d"), "Presentation" },
                    { new Guid("3c769188-8a68-4037-b51a-2fb189497cfb"), "Proposal" },
                    { new Guid("d3ba75bc-5de4-478d-8a66-5f2bd2cec4a5"), "Fact-Find" },
                    { new Guid("f01f9eb8-fc9d-47a3-bfb6-8d44e2f43cb3"), "Others" },
                    { new Guid("f8ba08e6-9cf1-41c3-a5d5-7cc3032dcec6"), "Sales Closing" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("40368af9-c08f-4bfd-8dad-d529b7f4d5da"), "7f08463d-8f1f-401b-b8ac-82ef7aa95577", "Admin", "ADMIN" },
                    { new Guid("92d989ba-61b8-4b4a-887c-b554564212a6"), "eca50876-7697-404b-82d7-9b6ec5b12f47", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("29fadd6d-c7a9-4475-94f2-d79e0d30fb91"), 0, "PJ Lhuiller", "09fe6b48-0d68-4549-b2f8-2eedf2ce1b1b", new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, null, null, "AQAAAAEAACcQAAAAEOwnC27oWLTSMcwP3FG0YIyR+VkYdNbfmlDHXdTAqgoEUhf0BEqGM/97S8A/BkRnOQ==", null, true, "", false, "user@crms.com" },
                    { new Guid("3298c81c-5d07-4b39-8fa0-15be079c7021"), 0, "PJ Lhuiller", "d4dfc9f6-b89b-4826-9a27-307dd0ca3d47", new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, null, null, "AQAAAAEAACcQAAAAEKwhfGjnTfQjtjN2Lb6tp/9esqNv5G0LM/xkTihjZyOeiq1E46amdUXwiHvOu4FBRw==", null, true, "", false, "su@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("16cb0bc3-0917-43bf-b8c9-a066db7bb491"), "Instagram" },
                    { new Guid("191a15fe-8c17-445a-ad9d-2991e279a03e"), "Facebook" },
                    { new Guid("4b617ec1-8f50-4d10-abaf-5ff831595620"), "Email" },
                    { new Guid("4faee073-d67e-4a82-922c-6cc814185927"), "Phone Call" },
                    { new Guid("98b623df-5371-4865-b2f8-5a226df78824"), "Test Message" },
                    { new Guid("bb192721-2f23-4457-8c9e-aae49bd77353"), "Others" },
                    { new Guid("c392e798-86ea-4d92-83cf-4955897d9b46"), "Line" },
                    { new Guid("fae361ed-0cc7-48cc-a644-e47409de679d"), "WhatsApp" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("09f4a7dc-3e62-4c5d-b914-f32901d07a23"), "Not Read" },
                    { new Guid("86d5f475-1994-4aad-ad38-b4016405acfa"), "Good Engagement" },
                    { new Guid("ad42a22b-7bbe-405b-87cf-c4a20c79feb7"), "Read but no response" },
                    { new Guid("c51eef35-b1fa-413d-958a-bc8840f26928"), "Simple Response" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("12b11e9c-f21e-4227-9c0f-f49748ba134e"), "Anniversary" },
                    { new Guid("2158254d-b77a-46ff-b1c8-8dd1c1b9052b"), "Company News" },
                    { new Guid("24293c33-f2d7-4c9a-8e11-e9db5e5eda44"), "Holiday" },
                    { new Guid("5ef89411-83c3-4fac-9f9d-bb1e665fd2d1"), "Birthday" },
                    { new Guid("7315d6e7-394b-4d0b-8a63-d467908b5cf0"), "Discount" },
                    { new Guid("790dbbbf-0ba3-4592-86c8-836c6cab6460"), "Congratulations" },
                    { new Guid("7e99f307-8575-47a8-a536-0efb24329cee"), "Others" },
                    { new Guid("af8f7919-f4ae-400c-87f3-adb24e9b35fe"), "New Product" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("17e9cae5-67aa-482b-a5c1-53aaf940327e"), "Webinar" },
                    { new Guid("3866c319-dd60-4a10-b8ad-4d5f25916a18"), "Compony-Generated" },
                    { new Guid("87950063-698c-4959-8344-ba26ac5f05e5"), "Others" },
                    { new Guid("ae0684b2-b30d-43fd-9604-776413ee7f79"), "Social Media" },
                    { new Guid("cc2865b0-4cab-4fdf-82a8-c901aa84fa0d"), "Friend" },
                    { new Guid("f83c544b-2483-4c6f-825b-dca08d514380"), "Referral" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("25093e02-9a84-49d8-a43d-ec3f78224b63"), "Met" },
                    { new Guid("3c485316-e5c2-4787-92ff-40373b84e8d4"), "Application Submitted" },
                    { new Guid("415448d8-ed1e-418a-8bd9-5e8883d6c779"), "Proposal Generated" },
                    { new Guid("c9421ef5-5fe4-466b-af82-1ce5925c8f75"), "Policy Issued" },
                    { new Guid("e690baf4-c476-48f1-a1ec-98e13cec9368"), "Lead is Dead" },
                    { new Guid("fd24cec1-f933-48b2-b781-b64adbfd0b98"), "Contacted" }
                });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("6d8948fe-a12b-462f-871e-838514a5069d"), new Guid("3298c81c-5d07-4b39-8fa0-15be079c7021"), new Guid("29fadd6d-c7a9-4475-94f2-d79e0d30fb91"), new DateTime(2023, 4, 3, 8, 29, 57, 128, DateTimeKind.Utc).AddTicks(3388), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 8, 29, 57, 128, DateTimeKind.Utc).AddTicks(3352), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789" });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("b337a669-b852-4f66-9f3d-9b65b0d5ce2a"), new Guid("3298c81c-5d07-4b39-8fa0-15be079c7021"), null, new DateTime(2023, 4, 8, 8, 29, 57, 128, DateTimeKind.Utc).AddTicks(3305), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812" });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("ef2c8661-9546-4084-99e8-859b4a90ff9c"), new Guid("29fadd6d-c7a9-4475-94f2-d79e0d30fb91"), new Guid("29fadd6d-c7a9-4475-94f2-d79e0d30fb91"), new DateTime(2023, 4, 5, 8, 29, 57, 128, DateTimeKind.Utc).AddTicks(3417), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 8, 29, 57, 128, DateTimeKind.Utc).AddTicks(3407), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321" });
        }
    }
}
