using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class AspUserRolesEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUserRole<string>");

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
                    { new Guid("25e4728e-a8f3-4466-8c29-a6a383479585"), "Presentation" },
                    { new Guid("5eb69a76-c5dd-4822-a56e-82fdd868a93b"), "Others" },
                    { new Guid("bcfab40d-0598-452f-beed-48359e35b497"), "Proposal" },
                    { new Guid("da99752d-08d9-4ef0-a6e4-ce487259a1fb"), "Fact-Find" },
                    { new Guid("e0d02e62-546b-4b03-a6d8-16ccf0aa5343"), "Sales Closing" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("22077764-7261-4755-8265-d923ae96d0da"), "2d5e7ccc-0d38-46ac-b0d4-27f4fd5bd1e5", "User", "USER" },
                    { new Guid("8f15d049-10a4-45e8-b47c-5781de36b76c"), "4067af35-7b5f-4359-ba3e-39d4319eafcf", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3b547b7b-f063-44b9-b8ba-856c1deddc41"), 0, "PJ Lhuiller", "ce264be7-91ba-487b-91a0-677395807962", new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEEhSry6yr6Lb4Es+v2ihtBkh3Ap54ieMkwGs0UtkBYnfx3iClOcI/x+4iO498wiCSQ==", null, true, "", false, "user@crms.com" },
                    { new Guid("84d3ddf2-bd16-4a62-994c-fe1d5aba3fe1"), 0, "PJ Lhuiller", "550845de-7737-44e3-a3f4-b9a0b877f3a9", new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEFEiwAD5xRm802wWM6u3bhwiIJbuNxlamzO29tuENHvxHFSau4SiiqqZ7sEypghojw==", null, true, "", false, "su@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("16ef823e-e015-4551-9bc0-9a9826611f35"), "Email" },
                    { new Guid("2a1d81f5-ba15-479d-bf59-f39538525a8f"), "Test Message" },
                    { new Guid("57c1a456-e15a-4f84-acc4-d75786abb659"), "Facebook" },
                    { new Guid("78d3accc-d07d-4635-a20f-25b8aa635ce6"), "Others" },
                    { new Guid("af28c14c-9ca9-4b1f-bc7b-444a59180d02"), "WhatsApp" },
                    { new Guid("d15cef8f-35c5-4d4d-9186-a2d9300c6c33"), "Line" },
                    { new Guid("e6f76b03-fa87-4cf2-85f4-b266148e1cee"), "Instagram" },
                    { new Guid("ed493ee1-6d49-4471-a5f1-8b3580a79f2c"), "Phone Call" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("1e138c9d-3a4e-49cf-b538-258c2b756d03"), "Simple Response" },
                    { new Guid("29107401-13af-4681-bb13-b27ea66816f7"), "Read but no response" },
                    { new Guid("72308380-7145-4f34-b9db-4183d53fa697"), "Good Engagement" },
                    { new Guid("74c620e9-f4bb-4c76-80cc-22ffef60e3f1"), "Not Read" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("04e9b149-4cfc-4e2b-9160-3caf0f08af7d"), "Company News" },
                    { new Guid("0adcca05-230a-4342-8f90-89caefb87396"), "Congratulations" },
                    { new Guid("28b0aef6-a9b7-4590-a0c5-0280e55eebc5"), "Others" },
                    { new Guid("361adbbc-31e1-4614-a03e-6df584b4e2e4"), "Holiday" },
                    { new Guid("364afaed-7310-4305-93dc-4e989d665868"), "Birthday" },
                    { new Guid("a28b47ba-505d-42ef-ada2-572ffa5c01bd"), "Discount" },
                    { new Guid("bf273959-811f-4bb7-9009-8d696180cb7a"), "Anniversary" },
                    { new Guid("cb1d89d5-6372-4a88-b000-f103e5246205"), "New Product" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("25c9a3b6-3e71-462d-abc5-59b464fa41e2"), "Webinar" },
                    { new Guid("44d5b7de-b1a4-4d21-bc73-7d422296b723"), "Compony-Generated" },
                    { new Guid("4ad90723-5544-42da-8790-5332fdcdf988"), "Social Media" },
                    { new Guid("6d959845-173c-4689-88d0-f2b240901f2e"), "Referral" },
                    { new Guid("7552d403-bccc-470c-b476-0e94126435a1"), "Friend" },
                    { new Guid("cc064b8d-8379-4eef-a5a8-afa70fb095ee"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("30e5d123-c2e2-434d-a0b8-ffa48546991f"), "Contacted" },
                    { new Guid("3675979a-8589-4985-90f5-7783aaba8076"), "Policy Issued" },
                    { new Guid("7eefe913-5603-470b-9172-40cbcb0db350"), "Met" },
                    { new Guid("87304a95-0848-4f24-b977-680fa4ead45e"), "Lead is Dead" },
                    { new Guid("be745c28-48e7-4a4e-83f3-8c084f4cc1c4"), "Proposal Generated" },
                    { new Guid("fa4e7be5-3311-4761-a9e1-98362cfa80e0"), "Application Submitted" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8f15d049-10a4-45e8-b47c-5781de36b76c"), new Guid("84d3ddf2-bd16-4a62-994c-fe1d5aba3fe1") });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("83a8aed0-5998-4779-a0ef-6a70b51a72d4"), new Guid("84d3ddf2-bd16-4a62-994c-fe1d5aba3fe1"), null, new DateTime(2023, 4, 8, 18, 24, 46, 86, DateTimeKind.Utc).AddTicks(1736), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812" },
                    { new Guid("ad50001d-1fd0-4534-9508-29e80287c176"), new Guid("3b547b7b-f063-44b9-b8ba-856c1deddc41"), new Guid("3b547b7b-f063-44b9-b8ba-856c1deddc41"), new DateTime(2023, 4, 5, 18, 24, 46, 86, DateTimeKind.Utc).AddTicks(1762), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 18, 24, 46, 86, DateTimeKind.Utc).AddTicks(1761), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321" },
                    { new Guid("d2911a8d-c650-4141-94a5-fbf705a49cf1"), new Guid("84d3ddf2-bd16-4a62-994c-fe1d5aba3fe1"), new Guid("3b547b7b-f063-44b9-b8ba-856c1deddc41"), new DateTime(2023, 4, 3, 18, 24, 46, 86, DateTimeKind.Utc).AddTicks(1756), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 18, 24, 46, 86, DateTimeKind.Utc).AddTicks(1744), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("25e4728e-a8f3-4466-8c29-a6a383479585"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("5eb69a76-c5dd-4822-a56e-82fdd868a93b"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("bcfab40d-0598-452f-beed-48359e35b497"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("da99752d-08d9-4ef0-a6e4-ce487259a1fb"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("e0d02e62-546b-4b03-a6d8-16ccf0aa5343"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("22077764-7261-4755-8265-d923ae96d0da"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8f15d049-10a4-45e8-b47c-5781de36b76c"), new Guid("84d3ddf2-bd16-4a62-994c-fe1d5aba3fe1") });

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("83a8aed0-5998-4779-a0ef-6a70b51a72d4"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("ad50001d-1fd0-4534-9508-29e80287c176"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("d2911a8d-c650-4141-94a5-fbf705a49cf1"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("16ef823e-e015-4551-9bc0-9a9826611f35"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("2a1d81f5-ba15-479d-bf59-f39538525a8f"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("57c1a456-e15a-4f84-acc4-d75786abb659"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("78d3accc-d07d-4635-a20f-25b8aa635ce6"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("af28c14c-9ca9-4b1f-bc7b-444a59180d02"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("d15cef8f-35c5-4d4d-9186-a2d9300c6c33"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("e6f76b03-fa87-4cf2-85f4-b266148e1cee"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("ed493ee1-6d49-4471-a5f1-8b3580a79f2c"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("1e138c9d-3a4e-49cf-b538-258c2b756d03"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("29107401-13af-4681-bb13-b27ea66816f7"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("72308380-7145-4f34-b9db-4183d53fa697"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("74c620e9-f4bb-4c76-80cc-22ffef60e3f1"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("04e9b149-4cfc-4e2b-9160-3caf0f08af7d"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("0adcca05-230a-4342-8f90-89caefb87396"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("28b0aef6-a9b7-4590-a0c5-0280e55eebc5"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("361adbbc-31e1-4614-a03e-6df584b4e2e4"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("364afaed-7310-4305-93dc-4e989d665868"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("a28b47ba-505d-42ef-ada2-572ffa5c01bd"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("bf273959-811f-4bb7-9009-8d696180cb7a"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("cb1d89d5-6372-4a88-b000-f103e5246205"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("25c9a3b6-3e71-462d-abc5-59b464fa41e2"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("44d5b7de-b1a4-4d21-bc73-7d422296b723"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("4ad90723-5544-42da-8790-5332fdcdf988"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("6d959845-173c-4689-88d0-f2b240901f2e"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("7552d403-bccc-470c-b476-0e94126435a1"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("cc064b8d-8379-4eef-a5a8-afa70fb095ee"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("30e5d123-c2e2-434d-a0b8-ffa48546991f"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("3675979a-8589-4985-90f5-7783aaba8076"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("7eefe913-5603-470b-9172-40cbcb0db350"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("87304a95-0848-4f24-b977-680fa4ead45e"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("be745c28-48e7-4a4e-83f3-8c084f4cc1c4"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("fa4e7be5-3311-4761-a9e1-98362cfa80e0"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8f15d049-10a4-45e8-b47c-5781de36b76c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b547b7b-f063-44b9-b8ba-856c1deddc41"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("84d3ddf2-bd16-4a62-994c-fe1d5aba3fe1"));

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<string>",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
                });

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
                table: "IdentityUserRole<string>",
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
    }
}
