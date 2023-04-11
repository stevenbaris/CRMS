using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class AddUserRoleString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("5667a935-b84c-46a1-be24-90c05ad13081"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("b906cf3e-72b6-4a6e-ab1b-710a6c70c31f"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("c43d6b05-eb68-4ea7-a0ab-52f1712cb1ad"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("c5c971a9-b618-4d18-a1e3-8272fea3441a"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("fea968db-4a53-497f-8a2c-d653b3fb61d8"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("050e064d-eb9d-4ab1-bef2-e4c99ee8bdb8"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7819a549-24e1-454c-86f3-11ac412c19bb"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("293d6420-d2ff-450f-a21e-9503211138f6"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("58e481f2-b31f-4c1e-a764-1ae91186cac1"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("83899261-747d-469b-939f-6ae15c053f52"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("2387a0e1-e8bd-4ae2-9c01-5caebf040eb0"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("2c19dd5b-053e-4078-9151-0cfd35036616"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("554c590b-65ef-4649-b645-0afc2b355d16"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("7719b700-d6ae-4f97-ba7c-ba5a37b45a5b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("805558bd-cd50-4686-8ab9-6b41d49947ed"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("ad623cea-a6f0-4d98-a7fa-2b6bd0f23c6b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("c1e92c09-eae0-41c6-93c6-5ee18a092436"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("e481e143-1bd8-4793-bb01-ac473da6932c"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("67100d4a-7ec2-472a-a1c1-703365389369"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("870d075d-c11b-444b-9200-461937192fd7"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("fba925d4-5eb2-4497-9b9b-bc8a206d8707"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("fc07be11-8b54-4cef-b4a7-4c3551b8d033"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("275630d5-e780-4413-bf40-5bad0e1f2f98"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("5232f197-a907-4338-b0e5-4ec0c5418e9c"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("58a54e57-163d-4b8b-a639-cdc14bf396c2"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("b1883adc-a8d3-440a-9f79-6ef2a9cb7b61"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("ba6e4790-5c78-4370-b7d6-420dedf0cb37"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("e959f000-65c2-46f9-9863-ba4d10daa5b2"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("ea04ba2e-466a-49fc-828d-238388ab6db4"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("ec7a18bb-e294-4bb1-a75d-aeba7e5a08e8"));

            migrationBuilder.DeleteData(
                table: "IdentityUserRole<string>",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "050e064d-eb9d-4ab1-bef2-e4c99ee8bdb8", "7c89c4fc-377e-4ea8-a57a-b3a04cb1330a" });

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("1be00f90-3c2d-4cb5-915a-929936c211bf"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("6206a754-20fa-4fc6-a57c-f6a842ab7b20"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("76da112e-efa9-4a69-8fe3-20a80acd329f"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("b83bd81a-47da-4abf-92ef-42f4c197592b"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("c9459159-0e2c-4251-a22e-f629337ef3e2"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("f3ac8813-4602-43c8-a770-85c23e6578d8"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("131f88b1-653d-4c5e-a091-f0e26b3c5253"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("1eb03cad-f10f-43c7-8c07-a47196430f7c"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("20c802bd-5b0b-445d-ad29-c440859e73da"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("75762f60-5036-4783-bf0e-b15c19d4e5b2"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("839cd8c0-4cae-491a-9035-c9c4cb7b2d42"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("b5f8a73a-ddb2-46be-b6fb-a0898b96b309"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c89c4fc-377e-4ea8-a57a-b3a04cb1330a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("956498a8-bd27-42a0-8865-d1ee64376547"));

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("287b224d-1afb-448f-9d5b-f1baca2fd55e"), "Presentation" },
                    { new Guid("7e654486-62b0-42b2-806d-b9b83515f7a0"), "Proposal" },
                    { new Guid("83156863-8572-43bb-b8a1-00c906213b3e"), "Fact-Find" },
                    { new Guid("90f73911-4761-492f-a2c1-155d88a318bf"), "Sales Closing" },
                    { new Guid("d790234f-55a2-46ec-ae23-146fe952d786"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("7df2293d-9d75-4b3d-86a4-630b60fd9a28"), "76529f0d-eb9a-4a96-9a22-aff059f5c37b", "User", "USER" },
                    { new Guid("8c18668a-19de-4ee1-8784-818af54fff48"), "3f3530fc-3be7-4096-827a-be2b0df27cc1", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("8a03c552-e0b2-4699-ad78-efd8eeb585da"), 0, "PJ Lhuiller", "0dbabf69-859f-47aa-9bbb-30f77c64c054", new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEJy+x8yXkE7ypjaT1Kjc98KXa2gHvDSQuxbR5N0MShWASoT2KjshRLEW0buluJlVng==", null, true, "", false, "su@crms.com" },
                    { new Guid("f82ab0d7-f354-4382-bb66-bbf9b60400f9"), 0, "PJ Lhuiller", "51777cc8-ee04-4a07-a7e2-7837df152010", new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEBLilheFVlPGw8aEqm7lCM9gLdXQlT0AfRIkLjvEWiGIoGIYjfQs5U/szGTB1YSz5g==", null, true, "", false, "user@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("21095efa-ef9b-454d-b07a-1363abf1ac10"), "Email" },
                    { new Guid("5fdd5789-a6a5-488b-990e-257ede0f7be2"), "Facebook" },
                    { new Guid("600915c6-a173-4057-8129-056cf0dad68d"), "Others" },
                    { new Guid("81a3cb44-4e7e-4537-a4ca-51611ec6a4a2"), "Test Message" },
                    { new Guid("951feaf7-c412-40db-b516-548e2aaab558"), "Instagram" },
                    { new Guid("c68e3bc7-06e0-477b-b774-97a104dd7712"), "Line" },
                    { new Guid("c9eae780-da9e-4d49-ab70-f82783c1dce2"), "WhatsApp" },
                    { new Guid("e46c72df-fd7d-4e55-81f0-0d4443a93666"), "Phone Call" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("247b086b-89a5-4c57-8d8a-bd19ba66bb90"), "Read but no response" },
                    { new Guid("28e69ec2-478a-4ce2-bd23-6812e0e218b8"), "Good Engagement" },
                    { new Guid("cfee5e7a-9efa-44f3-ad65-90443c9399ff"), "Not Read" },
                    { new Guid("d4ed25d4-453b-4cb8-abab-92af073f3773"), "Simple Response" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("05528e97-4003-41b0-a50e-16e318f69c1c"), "Birthday" },
                    { new Guid("1501b2a7-f0e1-43d8-be5a-cc712ceb8000"), "Company News" },
                    { new Guid("3c25cd37-69eb-42fb-8f95-b2d2465ed137"), "Discount" },
                    { new Guid("604faccf-6419-47cd-bc16-ebfa0e7fd7b6"), "New Product" },
                    { new Guid("67280100-7225-4d1a-a6fb-8ccb6b614b1a"), "Congratulations" },
                    { new Guid("b0a1dca0-356f-4ce9-b745-203abc6db958"), "Holiday" },
                    { new Guid("e212682b-d13a-472a-aa1f-7de8ce493182"), "Others" },
                    { new Guid("eb46faa3-2aa8-4a74-8047-d2b75207b011"), "Anniversary" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8c18668a-19de-4ee1-8784-818af54fff48", "8a03c552-e0b2-4699-ad78-efd8eeb585da" });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("05f5a6fc-535a-441e-abde-c28fe352292a"), "Social Media" },
                    { new Guid("3ab3d25f-6873-40f4-a87e-aa483f010fdf"), "Others" },
                    { new Guid("4a303a1d-f195-4e45-b318-d0d7914c478d"), "Compony-Generated" },
                    { new Guid("5d9fd7d0-46c0-4882-9ef7-a9a68622818f"), "Referral" },
                    { new Guid("86591cc6-8faf-407b-9116-ee0dec61cc73"), "Webinar" },
                    { new Guid("98fb85d9-77fb-4b5d-ad13-8f1228502589"), "Friend" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("2c67ad68-ef1b-4ce6-a2a9-531a6db66cb9"), "Proposal Generated" },
                    { new Guid("46316598-f3f5-426b-9d07-d4c3e8fec23f"), "Lead is Dead" },
                    { new Guid("6e3385a7-6863-47db-a336-0179d673deef"), "Contacted" },
                    { new Guid("b20726f9-cc7a-4d1b-9959-a18a8a2e85f8"), "Policy Issued" },
                    { new Guid("e1dad3a6-e170-4939-9c40-0b8855b3c5b2"), "Met" },
                    { new Guid("e836d4b7-922d-4ae0-8a7f-ef0a2d1c42d0"), "Application Submitted" }
                });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("2b33d0c7-3a5c-46f6-b5a9-957741f4e4b8"), new Guid("f82ab0d7-f354-4382-bb66-bbf9b60400f9"), new Guid("f82ab0d7-f354-4382-bb66-bbf9b60400f9"), new DateTime(2023, 4, 5, 18, 19, 10, 878, DateTimeKind.Utc).AddTicks(6636), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 18, 19, 10, 878, DateTimeKind.Utc).AddTicks(6635), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321" });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("7481c36e-35e7-4478-974a-e1a8e7563c20"), new Guid("8a03c552-e0b2-4699-ad78-efd8eeb585da"), null, new DateTime(2023, 4, 8, 18, 19, 10, 878, DateTimeKind.Utc).AddTicks(6618), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812" });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("8618966e-ba3a-4712-8f8b-9f0b8857078a"), new Guid("8a03c552-e0b2-4699-ad78-efd8eeb585da"), new Guid("f82ab0d7-f354-4382-bb66-bbf9b60400f9"), new DateTime(2023, 4, 3, 18, 19, 10, 878, DateTimeKind.Utc).AddTicks(6632), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 18, 19, 10, 878, DateTimeKind.Utc).AddTicks(6624), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("287b224d-1afb-448f-9d5b-f1baca2fd55e"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("7e654486-62b0-42b2-806d-b9b83515f7a0"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("83156863-8572-43bb-b8a1-00c906213b3e"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("90f73911-4761-492f-a2c1-155d88a318bf"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("d790234f-55a2-46ec-ae23-146fe952d786"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7df2293d-9d75-4b3d-86a4-630b60fd9a28"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8c18668a-19de-4ee1-8784-818af54fff48"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("2b33d0c7-3a5c-46f6-b5a9-957741f4e4b8"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("7481c36e-35e7-4478-974a-e1a8e7563c20"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("8618966e-ba3a-4712-8f8b-9f0b8857078a"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("21095efa-ef9b-454d-b07a-1363abf1ac10"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("5fdd5789-a6a5-488b-990e-257ede0f7be2"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("600915c6-a173-4057-8129-056cf0dad68d"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("81a3cb44-4e7e-4537-a4ca-51611ec6a4a2"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("951feaf7-c412-40db-b516-548e2aaab558"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("c68e3bc7-06e0-477b-b774-97a104dd7712"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("c9eae780-da9e-4d49-ab70-f82783c1dce2"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("e46c72df-fd7d-4e55-81f0-0d4443a93666"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("247b086b-89a5-4c57-8d8a-bd19ba66bb90"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("28e69ec2-478a-4ce2-bd23-6812e0e218b8"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("cfee5e7a-9efa-44f3-ad65-90443c9399ff"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("d4ed25d4-453b-4cb8-abab-92af073f3773"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("05528e97-4003-41b0-a50e-16e318f69c1c"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("1501b2a7-f0e1-43d8-be5a-cc712ceb8000"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("3c25cd37-69eb-42fb-8f95-b2d2465ed137"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("604faccf-6419-47cd-bc16-ebfa0e7fd7b6"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("67280100-7225-4d1a-a6fb-8ccb6b614b1a"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("b0a1dca0-356f-4ce9-b745-203abc6db958"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("e212682b-d13a-472a-aa1f-7de8ce493182"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("eb46faa3-2aa8-4a74-8047-d2b75207b011"));

            migrationBuilder.DeleteData(
                table: "IdentityUserRole<string>",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8c18668a-19de-4ee1-8784-818af54fff48", "8a03c552-e0b2-4699-ad78-efd8eeb585da" });

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("05f5a6fc-535a-441e-abde-c28fe352292a"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("3ab3d25f-6873-40f4-a87e-aa483f010fdf"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("4a303a1d-f195-4e45-b318-d0d7914c478d"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("5d9fd7d0-46c0-4882-9ef7-a9a68622818f"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("86591cc6-8faf-407b-9116-ee0dec61cc73"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("98fb85d9-77fb-4b5d-ad13-8f1228502589"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("2c67ad68-ef1b-4ce6-a2a9-531a6db66cb9"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("46316598-f3f5-426b-9d07-d4c3e8fec23f"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("6e3385a7-6863-47db-a336-0179d673deef"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("b20726f9-cc7a-4d1b-9959-a18a8a2e85f8"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("e1dad3a6-e170-4939-9c40-0b8855b3c5b2"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("e836d4b7-922d-4ae0-8a7f-ef0a2d1c42d0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a03c552-e0b2-4699-ad78-efd8eeb585da"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f82ab0d7-f354-4382-bb66-bbf9b60400f9"));

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("5667a935-b84c-46a1-be24-90c05ad13081"), "Presentation" },
                    { new Guid("b906cf3e-72b6-4a6e-ab1b-710a6c70c31f"), "Others" },
                    { new Guid("c43d6b05-eb68-4ea7-a0ab-52f1712cb1ad"), "Proposal" },
                    { new Guid("c5c971a9-b618-4d18-a1e3-8272fea3441a"), "Fact-Find" },
                    { new Guid("fea968db-4a53-497f-8a2c-d653b3fb61d8"), "Sales Closing" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("050e064d-eb9d-4ab1-bef2-e4c99ee8bdb8"), "02d0dcc6-8ca3-44e8-9277-f45db323df95", "Admin", "ADMIN" },
                    { new Guid("7819a549-24e1-454c-86f3-11ac412c19bb"), "bbbdd575-3655-4f63-a058-32dff5fe6fab", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("7c89c4fc-377e-4ea8-a57a-b3a04cb1330a"), 0, "PJ Lhuiller", "a2d8ef80-7fd4-46fb-b4d6-b2bb9e696919", new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAECeXlCf8MdKwg/OdE6f5XTl+Go+Y2UD+2cIXOMLupVjpxhdD5eXV8t73wiSA8fcSZA==", null, true, "", false, "su@crms.com" },
                    { new Guid("956498a8-bd27-42a0-8865-d1ee64376547"), 0, "PJ Lhuiller", "d9d30256-08f1-4acc-9a00-86afd2b96b49", new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEEmbGVx6FZ9C5dmdPYTdza/RO4/YBdnmiA2plrLnkfJ52xe1Dh4pFMPdzhTjIu1/tQ==", null, true, "", false, "user@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("2387a0e1-e8bd-4ae2-9c01-5caebf040eb0"), "Others" },
                    { new Guid("2c19dd5b-053e-4078-9151-0cfd35036616"), "Facebook" },
                    { new Guid("554c590b-65ef-4649-b645-0afc2b355d16"), "Instagram" },
                    { new Guid("7719b700-d6ae-4f97-ba7c-ba5a37b45a5b"), "Phone Call" },
                    { new Guid("805558bd-cd50-4686-8ab9-6b41d49947ed"), "Test Message" },
                    { new Guid("ad623cea-a6f0-4d98-a7fa-2b6bd0f23c6b"), "Line" },
                    { new Guid("c1e92c09-eae0-41c6-93c6-5ee18a092436"), "Email" },
                    { new Guid("e481e143-1bd8-4793-bb01-ac473da6932c"), "WhatsApp" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("67100d4a-7ec2-472a-a1c1-703365389369"), "Read but no response" },
                    { new Guid("870d075d-c11b-444b-9200-461937192fd7"), "Not Read" },
                    { new Guid("fba925d4-5eb2-4497-9b9b-bc8a206d8707"), "Good Engagement" },
                    { new Guid("fc07be11-8b54-4cef-b4a7-4c3551b8d033"), "Simple Response" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("275630d5-e780-4413-bf40-5bad0e1f2f98"), "Birthday" },
                    { new Guid("5232f197-a907-4338-b0e5-4ec0c5418e9c"), "Anniversary" },
                    { new Guid("58a54e57-163d-4b8b-a639-cdc14bf396c2"), "Congratulations" },
                    { new Guid("b1883adc-a8d3-440a-9f79-6ef2a9cb7b61"), "Discount" },
                    { new Guid("ba6e4790-5c78-4370-b7d6-420dedf0cb37"), "Company News" },
                    { new Guid("e959f000-65c2-46f9-9863-ba4d10daa5b2"), "Others" },
                    { new Guid("ea04ba2e-466a-49fc-828d-238388ab6db4"), "New Product" },
                    { new Guid("ec7a18bb-e294-4bb1-a75d-aeba7e5a08e8"), "Holiday" }
                });

            migrationBuilder.InsertData(
                table: "IdentityUserRole<string>",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "050e064d-eb9d-4ab1-bef2-e4c99ee8bdb8", "7c89c4fc-377e-4ea8-a57a-b3a04cb1330a" });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("1be00f90-3c2d-4cb5-915a-929936c211bf"), "Others" },
                    { new Guid("6206a754-20fa-4fc6-a57c-f6a842ab7b20"), "Friend" },
                    { new Guid("76da112e-efa9-4a69-8fe3-20a80acd329f"), "Compony-Generated" },
                    { new Guid("b83bd81a-47da-4abf-92ef-42f4c197592b"), "Referral" },
                    { new Guid("c9459159-0e2c-4251-a22e-f629337ef3e2"), "Webinar" },
                    { new Guid("f3ac8813-4602-43c8-a770-85c23e6578d8"), "Social Media" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("131f88b1-653d-4c5e-a091-f0e26b3c5253"), "Proposal Generated" },
                    { new Guid("1eb03cad-f10f-43c7-8c07-a47196430f7c"), "Met" },
                    { new Guid("20c802bd-5b0b-445d-ad29-c440859e73da"), "Lead is Dead" },
                    { new Guid("75762f60-5036-4783-bf0e-b15c19d4e5b2"), "Application Submitted" },
                    { new Guid("839cd8c0-4cae-491a-9035-c9c4cb7b2d42"), "Policy Issued" },
                    { new Guid("b5f8a73a-ddb2-46be-b6fb-a0898b96b309"), "Contacted" }
                });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("293d6420-d2ff-450f-a21e-9503211138f6"), new Guid("7c89c4fc-377e-4ea8-a57a-b3a04cb1330a"), new Guid("956498a8-bd27-42a0-8865-d1ee64376547"), new DateTime(2023, 4, 3, 18, 3, 43, 436, DateTimeKind.Utc).AddTicks(9134), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 18, 3, 43, 436, DateTimeKind.Utc).AddTicks(9129), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789" });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("58e481f2-b31f-4c1e-a764-1ae91186cac1"), new Guid("7c89c4fc-377e-4ea8-a57a-b3a04cb1330a"), null, new DateTime(2023, 4, 8, 18, 3, 43, 436, DateTimeKind.Utc).AddTicks(9049), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812" });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("83899261-747d-469b-939f-6ae15c053f52"), new Guid("956498a8-bd27-42a0-8865-d1ee64376547"), new Guid("956498a8-bd27-42a0-8865-d1ee64376547"), new DateTime(2023, 4, 5, 18, 3, 43, 436, DateTimeKind.Utc).AddTicks(9137), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 18, 3, 43, 436, DateTimeKind.Utc).AddTicks(9136), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321" });
        }
    }
}
