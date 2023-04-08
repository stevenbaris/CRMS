using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class AddContactsinDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("280e236d-aecc-4535-8f12-e32c9f5b8aca"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("91185bb8-e1dc-4086-84c0-1bd262d49952"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("a73e3e80-1ca1-4184-b42c-117e2683edca"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("b334d4f6-461b-499b-84de-2b24aaebb2cf"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("d0b463fd-9886-4c79-83a6-5068bdd27f49"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8792a412-a1d5-4b4a-919c-7327f14780e1"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fa61d82e-a3fc-4271-a880-06ca42ed294e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("775b50f9-b147-4b01-a82c-c897506603c7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a65582f0-df4b-4204-8b07-704e66360daf"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("1bd4b881-b780-467f-8f67-935ed8e8a6d9"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("3be13dc5-2519-4b3c-81e1-1f996749fdbc"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("3f59417e-0699-423b-a4fc-2ed96d4fb379"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("5782af8a-a74c-43ce-99fb-bdb8c4c0c209"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("5abde515-a1d5-49e0-b8ab-17d5baed2a93"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("74f40398-8459-4f42-900b-2f77fea12e9d"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("9436869e-79c5-4f8d-9685-ea1010815e88"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("e1f23061-ee21-42ab-bc10-ea3d154e9f55"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("59ab2491-a778-4777-a035-3419c4bc52eb"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("5df580a9-fe4e-4165-9614-a787c6b8db84"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("db61e122-d0d7-405a-a2c6-06b6af18a14b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("f9ff0128-6839-4c4e-814f-d9246e52f2c7"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("3dfb98b4-810c-43e8-9e0c-6ab301472378"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("546a1ba0-bb7c-44f2-aec8-bb2831959ad5"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("7b8d16e5-f16b-4ace-9ce5-c71d26bf7a1d"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("7e861260-be53-4acf-affb-24339d4ba04d"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("bf24de0b-968f-4ffd-99fa-808b2f199b20"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("f4cb8f9a-40b0-444d-bad2-23939b249091"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("f69b6225-422a-481b-86f4-08e2e36dcde3"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("fab25155-bdd9-4935-a2ee-7d38e5a0642b"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("177bb019-dc15-4b89-8960-e3fe98bfc687"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("308168e8-cd74-478c-a735-11746def6c83"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("404be604-0f5a-4320-ab98-0080513cbeea"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("7c6417cc-6271-4ce3-a456-efaae122c138"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("a9698b4f-b1fd-4f98-a1c6-8b270bcfb17f"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("ee87c2ed-7896-49cc-9b39-2c0e23b6b31c"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("5ca59b0e-2349-4b44-b5f9-23aae1e1bd84"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("5d5ca464-24eb-4b57-886d-de5f0f50e054"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("930d6e6f-740f-4190-a41c-3a95290d9403"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("b3bad378-34a8-4cb1-8ab2-9ca6f3cacf9b"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("dff4d3f7-8902-4cb1-9e95-836f5db6da40"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("ff34c516-dfb8-40b1-a381-58d80209563d"));

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "CONTACTS",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "CONTACTS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CONTACTS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ContactCreatorID",
                table: "CONTACTS",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "CONTACTS",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "CONTACTS",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CONTACTS",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "ContactCreatorID",
                table: "CONTACTS",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("280e236d-aecc-4535-8f12-e32c9f5b8aca"), "Proposal" },
                    { new Guid("91185bb8-e1dc-4086-84c0-1bd262d49952"), "Sales Closing" },
                    { new Guid("a73e3e80-1ca1-4184-b42c-117e2683edca"), "Presentation" },
                    { new Guid("b334d4f6-461b-499b-84de-2b24aaebb2cf"), "Fact-Find" },
                    { new Guid("d0b463fd-9886-4c79-83a6-5068bdd27f49"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8792a412-a1d5-4b4a-919c-7327f14780e1"), "9b112166-f6df-48e7-abe6-babe36c6a7bd", "User", null },
                    { new Guid("fa61d82e-a3fc-4271-a880-06ca42ed294e"), "4ae98d4d-764f-4cab-8d09-079b45dfc94c", "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("775b50f9-b147-4b01-a82c-c897506603c7"), 0, "PJ Lhuiller", "07390163-46bd-4933-82c8-ed10f23ff23f", new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, null, null, "AQAAAAEAACcQAAAAEDDKlDt0Lv8dYz9P4aX2S/7RW5tyktxVFMVTd38sVwBD9/xyScvYKNocXJ1AVAkosg==", null, true, "", false, "su@crms.com" },
                    { new Guid("a65582f0-df4b-4204-8b07-704e66360daf"), 0, "PJ Lhuiller", "87c0312e-d36b-4722-afa6-38756a8aeca2", new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, null, null, "AQAAAAEAACcQAAAAEC8ilH7gsb+SuuHli9X+m8nKpVIviKqvZB3wMPHOoiLlymb+WDLyL0NgoEgoBIS+BA==", null, true, "", false, "user@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("1bd4b881-b780-467f-8f67-935ed8e8a6d9"), "Facebook" },
                    { new Guid("3be13dc5-2519-4b3c-81e1-1f996749fdbc"), "Email" },
                    { new Guid("3f59417e-0699-423b-a4fc-2ed96d4fb379"), "Phone Call" },
                    { new Guid("5782af8a-a74c-43ce-99fb-bdb8c4c0c209"), "WhatsApp" },
                    { new Guid("5abde515-a1d5-49e0-b8ab-17d5baed2a93"), "Test Message" },
                    { new Guid("74f40398-8459-4f42-900b-2f77fea12e9d"), "Others" },
                    { new Guid("9436869e-79c5-4f8d-9685-ea1010815e88"), "Line" },
                    { new Guid("e1f23061-ee21-42ab-bc10-ea3d154e9f55"), "Instagram" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("59ab2491-a778-4777-a035-3419c4bc52eb"), "Read but no response" },
                    { new Guid("5df580a9-fe4e-4165-9614-a787c6b8db84"), "Simple Response" },
                    { new Guid("db61e122-d0d7-405a-a2c6-06b6af18a14b"), "Not Read" },
                    { new Guid("f9ff0128-6839-4c4e-814f-d9246e52f2c7"), "Good Engagement" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("3dfb98b4-810c-43e8-9e0c-6ab301472378"), "Discount" },
                    { new Guid("546a1ba0-bb7c-44f2-aec8-bb2831959ad5"), "Birthday" },
                    { new Guid("7b8d16e5-f16b-4ace-9ce5-c71d26bf7a1d"), "New Product" },
                    { new Guid("7e861260-be53-4acf-affb-24339d4ba04d"), "Holiday" },
                    { new Guid("bf24de0b-968f-4ffd-99fa-808b2f199b20"), "Congratulations" },
                    { new Guid("f4cb8f9a-40b0-444d-bad2-23939b249091"), "Anniversary" },
                    { new Guid("f69b6225-422a-481b-86f4-08e2e36dcde3"), "Others" },
                    { new Guid("fab25155-bdd9-4935-a2ee-7d38e5a0642b"), "Company News" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("177bb019-dc15-4b89-8960-e3fe98bfc687"), "Social Media" },
                    { new Guid("308168e8-cd74-478c-a735-11746def6c83"), "Friend" },
                    { new Guid("404be604-0f5a-4320-ab98-0080513cbeea"), "Webinar" },
                    { new Guid("7c6417cc-6271-4ce3-a456-efaae122c138"), "Compony-Generated" },
                    { new Guid("a9698b4f-b1fd-4f98-a1c6-8b270bcfb17f"), "Others" },
                    { new Guid("ee87c2ed-7896-49cc-9b39-2c0e23b6b31c"), "Referral" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("5ca59b0e-2349-4b44-b5f9-23aae1e1bd84"), "Met" },
                    { new Guid("5d5ca464-24eb-4b57-886d-de5f0f50e054"), "Policy Issued" },
                    { new Guid("930d6e6f-740f-4190-a41c-3a95290d9403"), "Contacted" },
                    { new Guid("b3bad378-34a8-4cb1-8ab2-9ca6f3cacf9b"), "Lead is Dead" },
                    { new Guid("dff4d3f7-8902-4cb1-9e95-836f5db6da40"), "Application Submitted" },
                    { new Guid("ff34c516-dfb8-40b1-a381-58d80209563d"), "Proposal Generated" }
                });
        }
    }
}
