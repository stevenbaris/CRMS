using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class addedProductsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("41228384-e3f8-4262-bce3-29a2bfcf2184"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("5a20cc0a-c08a-4ad3-af60-34f90dae28a5"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("ef5f0c6f-13e0-4afe-bc74-d413bf06b957"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("f053d0c1-89df-402f-8653-8df552a021d0"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("f3109f45-38e3-46ed-a354-d02cc7a87a6d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9da17b33-3bd1-4b80-895a-7013029048ad"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3f89c180-6c2b-4b9e-90ef-27699bd419cd"), new Guid("9cf30f3d-cf3a-4380-97a1-11b90e51ee3c") });

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("226ee897-ffb0-4da5-8496-4d964a01c662"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("c6301106-b64c-41a2-b5cf-6daecec912db"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("c931f1bb-128a-4668-a01e-ceca9344bca0"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("180b0185-3a36-4c57-a2fd-832875cf9ff5"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("2bf7c7fc-ceee-4798-98eb-bf6e6c39efad"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("320b3134-4045-462e-9008-9eebada89818"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("46785ae7-d8b7-4897-b34e-811ca9be2a45"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("62e3258a-ad0f-4aca-bce4-78105ead0411"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("cbf939c3-2f64-4df8-b28f-ab4e80276d06"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("d26077d7-1b2b-4408-8bb1-839cf2c08b31"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("e8e47d6f-bec2-4d84-bcc5-d2c8b3cb0032"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("02863c2e-7023-4499-b3e3-cab73e121c37"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("2848552c-49da-4887-9c7d-71c888865f75"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("754fdd10-3c03-4ac8-866f-247085861747"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("936e0886-cfc5-439e-8fda-e75c3fc8a775"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("0402c92c-4687-4c64-a31d-43a1e34de5ff"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("19cbea79-1979-41bf-bb9b-4a364c6ba73a"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("28bda113-b507-45c8-ab74-797f72d1c501"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("70295121-2d78-4842-819c-8aa5fe068934"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("ceef13fe-549d-48a6-a5c1-1df29db224e0"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("cfcc3043-8a15-4b48-9049-decda517dcd2"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("e8809712-c63e-4826-b4bd-60b62e3e0b54"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("f2051c37-e3ca-4556-a00f-d2c5d7af328f"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("12874ef1-58d7-4323-a3c7-9b43bdec4464"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("1dedce90-8118-43dc-bf47-efdd5c13adb0"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("3a4f702a-1d0e-4a32-b7c5-ba6a50274a81"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("5413cb73-b2ad-4f77-a23f-a1a2c469a3ca"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("ad7e5402-1ffd-41ac-a979-f1c8aac887e3"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("f8f81864-79fe-4003-847e-1463b8e8bad2"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("35bc38d7-6af1-4595-8994-bf1e0272cf4f"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("681f2506-6cc2-4e3a-a2b3-55ea97fc7649"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("86013ffa-c100-4041-b76a-c8f1b6d63221"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("952ead42-9668-412c-8bb6-aa45c9017776"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("d574f87b-75dd-4549-af80-e2aedc3b9cb2"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("e54a2cf3-a779-41ed-b798-74969b788853"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3f89c180-6c2b-4b9e-90ef-27699bd419cd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9cf30f3d-cf3a-4380-97a1-11b90e51ee3c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a226f636-d8ba-49d2-8e33-b5f4b752e3e2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f5ac9055-835f-44a3-82fe-2cbc72137772"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("41228384-e3f8-4262-bce3-29a2bfcf2184"), "Fact-Find" },
                    { new Guid("5a20cc0a-c08a-4ad3-af60-34f90dae28a5"), "Proposal" },
                    { new Guid("ef5f0c6f-13e0-4afe-bc74-d413bf06b957"), "Presentation" },
                    { new Guid("f053d0c1-89df-402f-8653-8df552a021d0"), "Sales Closing" },
                    { new Guid("f3109f45-38e3-46ed-a354-d02cc7a87a6d"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("3f89c180-6c2b-4b9e-90ef-27699bd419cd"), "ea1580e3-cfd4-4375-9538-a2c81458c55a", "Admin", "ADMIN" },
                    { new Guid("9da17b33-3bd1-4b80-895a-7013029048ad"), "c569e2f0-0547-4469-a89d-57a346bd73ba", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityAddress", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("9cf30f3d-cf3a-4380-97a1-11b90e51ee3c"), 0, "Makati", "f7342abb-7002-4f41-ae6b-2f05aa6b1a65", new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEIE4HFDOfgz3DBLo+S5/XLgA4nWYh6Tojj9yPL6WUYV5xRnYoTiepKG4Jc3t2fBB0Q==", null, true, "", false, "su@crms.com" },
                    { new Guid("a226f636-d8ba-49d2-8e33-b5f4b752e3e2"), 0, "Makati", "66aaedb4-f884-4bfd-bbe7-3d93cb37bbe9", new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEMWI3MaO8kIhFVqx+CwNgJXfLesHWaXIChwafCJwXaMZ3iXRki6SYHuty7pUy5ZUDA==", null, true, "", false, "user@crms.com" },
                    { new Guid("f5ac9055-835f-44a3-82fe-2cbc72137772"), 0, "Makati", "aa6ee692-6142-43cc-8182-69aa82e0bcd7", new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "sys@crms.com", true, "SYSTEM", "CRMS", true, null, "SYS@CRMS.COM", "SYSTEM", "AQAAAAEAACcQAAAAEH1Be7ixodyW1zKyMkoCEkT3IIJmQGq1vTC/KDh9qUc11DSR3ZuGKEKBEAr31IimPw==", null, true, "", false, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("180b0185-3a36-4c57-a2fd-832875cf9ff5"), "WhatsApp" },
                    { new Guid("2bf7c7fc-ceee-4798-98eb-bf6e6c39efad"), "Facebook" },
                    { new Guid("320b3134-4045-462e-9008-9eebada89818"), "Others" },
                    { new Guid("46785ae7-d8b7-4897-b34e-811ca9be2a45"), "Instagram" },
                    { new Guid("62e3258a-ad0f-4aca-bce4-78105ead0411"), "Test Message" },
                    { new Guid("cbf939c3-2f64-4df8-b28f-ab4e80276d06"), "Phone Call" },
                    { new Guid("d26077d7-1b2b-4408-8bb1-839cf2c08b31"), "Line" },
                    { new Guid("e8e47d6f-bec2-4d84-bcc5-d2c8b3cb0032"), "Email" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("02863c2e-7023-4499-b3e3-cab73e121c37"), "Read but no response" },
                    { new Guid("2848552c-49da-4887-9c7d-71c888865f75"), "Simple Response" },
                    { new Guid("754fdd10-3c03-4ac8-866f-247085861747"), "Good Engagement" },
                    { new Guid("936e0886-cfc5-439e-8fda-e75c3fc8a775"), "Not Read" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("0402c92c-4687-4c64-a31d-43a1e34de5ff"), "Company News" },
                    { new Guid("19cbea79-1979-41bf-bb9b-4a364c6ba73a"), "Others" },
                    { new Guid("28bda113-b507-45c8-ab74-797f72d1c501"), "Anniversary" },
                    { new Guid("70295121-2d78-4842-819c-8aa5fe068934"), "Holiday" },
                    { new Guid("ceef13fe-549d-48a6-a5c1-1df29db224e0"), "Birthday" },
                    { new Guid("cfcc3043-8a15-4b48-9049-decda517dcd2"), "Congratulations" },
                    { new Guid("e8809712-c63e-4826-b4bd-60b62e3e0b54"), "Discount" },
                    { new Guid("f2051c37-e3ca-4556-a00f-d2c5d7af328f"), "New Product" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("12874ef1-58d7-4323-a3c7-9b43bdec4464"), "Compony-Generated" },
                    { new Guid("1dedce90-8118-43dc-bf47-efdd5c13adb0"), "Social Media" },
                    { new Guid("3a4f702a-1d0e-4a32-b7c5-ba6a50274a81"), "Friend" },
                    { new Guid("5413cb73-b2ad-4f77-a23f-a1a2c469a3ca"), "Others" },
                    { new Guid("ad7e5402-1ffd-41ac-a979-f1c8aac887e3"), "Referral" },
                    { new Guid("f8f81864-79fe-4003-847e-1463b8e8bad2"), "Webinar" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("35bc38d7-6af1-4595-8994-bf1e0272cf4f"), "Lead is Dead" },
                    { new Guid("681f2506-6cc2-4e3a-a2b3-55ea97fc7649"), "Proposal Generated" },
                    { new Guid("86013ffa-c100-4041-b76a-c8f1b6d63221"), "Application Submitted" },
                    { new Guid("952ead42-9668-412c-8bb6-aa45c9017776"), "Contacted" },
                    { new Guid("d574f87b-75dd-4549-af80-e2aedc3b9cb2"), "Met" },
                    { new Guid("e54a2cf3-a779-41ed-b798-74969b788853"), "Policy Issued" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("3f89c180-6c2b-4b9e-90ef-27699bd419cd"), new Guid("9cf30f3d-cf3a-4380-97a1-11b90e51ee3c") });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "UpdateDate", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("226ee897-ffb0-4da5-8496-4d964a01c662"), new Guid("9cf30f3d-cf3a-4380-97a1-11b90e51ee3c"), new Guid("a226f636-d8ba-49d2-8e33-b5f4b752e3e2"), new DateTime(2023, 4, 11, 19, 40, 32, 323, DateTimeKind.Local).AddTicks(503), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 19, 40, 32, 323, DateTimeKind.Local).AddTicks(472), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789", new DateTime(2023, 4, 16, 19, 40, 32, 323, DateTimeKind.Local).AddTicks(503), new Guid("f5ac9055-835f-44a3-82fe-2cbc72137772") },
                    { new Guid("c6301106-b64c-41a2-b5cf-6daecec912db"), new Guid("a226f636-d8ba-49d2-8e33-b5f4b752e3e2"), new Guid("a226f636-d8ba-49d2-8e33-b5f4b752e3e2"), new DateTime(2023, 4, 13, 19, 40, 32, 323, DateTimeKind.Local).AddTicks(517), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 19, 40, 32, 323, DateTimeKind.Local).AddTicks(513), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321", new DateTime(2023, 4, 16, 19, 40, 32, 323, DateTimeKind.Local).AddTicks(519), new Guid("f5ac9055-835f-44a3-82fe-2cbc72137772") },
                    { new Guid("c931f1bb-128a-4668-a01e-ceca9344bca0"), new Guid("9cf30f3d-cf3a-4380-97a1-11b90e51ee3c"), null, new DateTime(2023, 4, 16, 19, 40, 32, 323, DateTimeKind.Local).AddTicks(448), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812", new DateTime(2023, 4, 16, 19, 40, 32, 323, DateTimeKind.Local).AddTicks(449), new Guid("f5ac9055-835f-44a3-82fe-2cbc72137772") }
                });
        }
    }
}
