using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class AddedSeedForSystemUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("3f43fd45-d33b-40de-a76b-b9fff8746e40"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("4bb2b44c-2eba-4b86-8c83-fa03203e99cd"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("833c5c52-7a96-4093-833a-13a6c261c7b5"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("96e9b481-3fc2-46c0-bfe7-61b19114b108"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("ef9fddbc-2daf-4844-8278-00aa0a944a9e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("57ada34e-61ad-4198-9022-ef59fe5a3ff5"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("83b60ffa-7c56-4d9f-8b01-1c5b51b6eba0"), new Guid("eb2a3620-e987-4d20-aebd-677ce35ee381") });

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("339b1364-289a-4e3c-a030-92aa414629af"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("4d8a837f-14c2-43ec-830b-7078fcf0de5e"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("f73874c8-465e-4e0a-a572-cfc8a9c892e2"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("38a3e506-8857-443e-b7da-8240a5dd13ff"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("4ed9f580-b0f1-4a97-a96b-5e2c81d65407"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("67fa3ed9-2040-4996-b731-2a080a699e53"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("7ea3917f-6bff-4e83-8af0-fb3ec74748b7"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("7f5914f1-0fed-4727-80a8-36004a5b4c67"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("9b9cc17e-1820-492b-96df-ec53fe5cb710"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("b22a9a76-9d25-4a91-95a3-9417e46d7bcb"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("be257324-0fc7-4a28-a39a-e0ccf7f5313b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("75b00347-7f6f-4c88-8da4-df9b36709508"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("ae9872e6-9113-46e0-b9ed-f60fcf0967e1"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("da322339-efda-4155-88a3-92ea5e177167"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("ea283e72-3a9d-48c2-b0f8-83ae67300c80"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("042a7ae1-1657-44b4-8dd6-c691a142d043"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("757b1137-4a04-4083-9f5d-809496c8fb94"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("88a85a8a-6f70-4e78-abaf-de0025482d03"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("af9642a7-b579-4257-b227-e17cdb059b17"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("c66ffe5d-8542-4be9-b2ff-084834578bf4"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("cea87af8-37e4-4fa4-9127-e4ae0bc1ec10"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("d42abfe7-6daa-4a5c-9186-d4b7ee41f01e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("fffc4bce-8836-4fbe-a9a0-1d15977d39d6"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("4bab5c80-928b-466f-b2fe-75dba618a194"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("4d682473-76f7-4e4c-9949-2dfeddccd72e"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("790ba781-6ebc-4b14-974a-e21b1a5d3e2a"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("906eb2b7-e542-4fb1-8843-1603bbfec86f"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("c1763c7f-f32a-4b29-9661-edc7a8dc103d"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("e1ef97c7-e561-4bc3-91dc-e4549dc0c6ec"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("1cef44d3-24f2-4da4-b2c5-1176e04b81cf"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("505f3543-8ce3-4068-9f5c-e4696defab41"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("73166078-703a-49cb-ab7f-c8988a7e4118"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("86ccffe8-4124-45b6-9535-11eaaea71cbe"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("a72742f1-f21e-4839-abdd-f790c61c5ccc"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("cb90b4c5-6224-49a1-81d7-c0c049c9358f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("83b60ffa-7c56-4d9f-8b01-1c5b51b6eba0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b305efa2-74c3-4fa8-923d-82704ef86928"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("eb2a3620-e987-4d20-aebd-677ce35ee381"));

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "AspNetUsers",
                newName: "CityAddress");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "CONTACTS",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "CONTACTS",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PRODUCTS",
                columns: table => new
                {
                    Product_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Benefits = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTS", x => x.Product_Id);
                });

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("5f0e03d9-2aad-42e8-b77e-d2384185dea9"), "Fact-Find" },
                    { new Guid("80415ec2-d795-4173-bba0-a396e2b60a43"), "Proposal" },
                    { new Guid("820f6348-cc4f-4f64-bfea-d64b53078857"), "Others" },
                    { new Guid("e8ba99eb-4a43-4f00-8bce-02d66b1089b9"), "Sales Closing" },
                    { new Guid("ee934792-9dc8-482b-8895-17028c4a88af"), "Presentation" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("200c4e80-7444-48c0-ab44-6875a973faed"), "5c968e28-78a5-41bd-9524-776201fcffc0", "User", "USER" },
                    { new Guid("5c68d433-c5f9-4388-8730-3077c621d8f4"), "486f99e8-2c19-49f1-82fc-4b5fa8a02384", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityAddress", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("047a8d65-09ce-49da-a97f-5caa499b2ced"), 0, "Makati", "3e84e75e-a2b5-4cbb-ab90-6c280e05c885", new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEKZhyHlkrhu1LDsAmIZXFVBYtS21ESMbk2+5X5KqulZpm+oUkH/I66qto/f9LbA6IA==", null, true, "", false, "su@crms.com" },
                    { new Guid("803705ab-b2b5-4f2b-97c7-619acba5c6b3"), 0, "Makati", "2cb782c8-c49e-442f-a411-2c408b0e79f2", new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "sys@crms.com", true, "SYSTEM", "CRMS", true, null, "SYS@CRMS.COM", "SYSTEM", "AQAAAAEAACcQAAAAEL8wXxMVOBkJqNaZqE9g2jthyt0e0TT9paRC8yuw0HqxwMxjwDQXUAy3n5L5P98GBg==", null, true, "", false, "SYSTEM" },
                    { new Guid("9aba3b55-9499-4247-90df-13c4a0861643"), 0, "Makati", "ca48fd85-a2ec-478c-b261-3c4f381f6f51", new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAENaNB6FPi9f8Sfczkspyl1bX65Q9RJ0bo+xqAxwiN79Rh4mCfPiWlhYUEaUXQpnwIQ==", null, true, "", false, "user@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("2c05b9ec-5bea-49de-b07b-d655f34c2160"), "WhatsApp" },
                    { new Guid("4b8dee10-67d4-4ec5-b8cc-434f75a44b88"), "Line" },
                    { new Guid("5655f79b-d7ba-4236-b69b-9db52c41c2ac"), "Test Message" },
                    { new Guid("838a4a95-05b2-4d32-9e0a-d11b49b0b1cf"), "Facebook" },
                    { new Guid("932015e1-45c9-481a-87c3-6893013cfac3"), "Phone Call" },
                    { new Guid("9c41cd5b-8056-4a01-92b5-20cd9e410d7d"), "Email" },
                    { new Guid("cdcbdca4-fd1c-47dd-8b1e-1814b325c472"), "Instagram" },
                    { new Guid("e094e23a-3b91-4298-82e5-20fcc73d4c36"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("4b7a3cfd-d011-40d1-b59c-199240868186"), "Not Read" },
                    { new Guid("61d2bb0b-ef12-4849-9005-6b0b905f0451"), "Good Engagement" },
                    { new Guid("e70f7e35-0ae0-47b1-92f7-01602ca09faf"), "Read but no response" },
                    { new Guid("fbb22c3b-436e-4b92-b80e-d91bdf7d51aa"), "Simple Response" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("15c02c9b-1dd2-4dce-b885-591cad664638"), "Holiday" },
                    { new Guid("31214d83-edbd-4d97-9984-48d800f8332a"), "Congratulations" },
                    { new Guid("577a2fcf-e07e-4461-86a2-1a786195fca3"), "Others" },
                    { new Guid("69697d69-bf1e-4725-bce2-4a3782409d43"), "Company News" },
                    { new Guid("962f1882-4b05-473a-bdf5-8874ebd7f4ad"), "Anniversary" },
                    { new Guid("9d97bf9f-2558-42c9-88a8-4611f6af3c22"), "New Product" },
                    { new Guid("e301ee70-a20c-4f1d-bf08-c4a230fc8ab7"), "Discount" },
                    { new Guid("e7db9660-07fb-45ab-bfa2-92f6e468cf03"), "Birthday" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("0c77e001-ce36-4d06-97c0-e71e0d8df307"), "Webinar" },
                    { new Guid("157d1687-b495-420d-8ab0-d61db7d5ff6d"), "Friend" },
                    { new Guid("37ad26ad-4e4e-4479-889c-1e60a1254457"), "Social Media" },
                    { new Guid("5c8c884a-caf8-4ccc-ab4f-99d06e18b941"), "Compony-Generated" },
                    { new Guid("bb067170-99d9-4879-9d7b-40bb186ae345"), "Others" },
                    { new Guid("f92631b1-f0ee-490f-b211-957169ca0277"), "Referral" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("3b2f74cf-d0b6-4083-9cf5-c2a6ac7a57b5"), "Met" },
                    { new Guid("513056b6-8482-447c-a0b9-ba4bc159c3d8"), "Policy Issued" },
                    { new Guid("9210807b-24f3-472d-9d67-88d67ac2bbae"), "Contacted" },
                    { new Guid("ccee7e45-07ba-425a-ac95-0c50e3bd0ae8"), "Proposal Generated" },
                    { new Guid("d48b9070-9644-423b-87f8-ebf97c049c1a"), "Application Submitted" },
                    { new Guid("f742ca0e-a818-4f04-8a81-b795c260a892"), "Lead is Dead" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("5c68d433-c5f9-4388-8730-3077c621d8f4"), new Guid("047a8d65-09ce-49da-a97f-5caa499b2ced") });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "UpdateDate", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0ab261b3-b47a-41df-aafa-d59fd4eb5b25"), new Guid("047a8d65-09ce-49da-a97f-5caa499b2ced"), new Guid("9aba3b55-9499-4247-90df-13c4a0861643"), new DateTime(2023, 4, 9, 16, 57, 20, 257, DateTimeKind.Local).AddTicks(7783), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 16, 57, 20, 257, DateTimeKind.Local).AddTicks(7775), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789", new DateTime(2023, 4, 14, 16, 57, 20, 257, DateTimeKind.Local).AddTicks(7783), new Guid("803705ab-b2b5-4f2b-97c7-619acba5c6b3") },
                    { new Guid("854af417-39cc-408a-8ea4-ed03e3e50955"), new Guid("9aba3b55-9499-4247-90df-13c4a0861643"), new Guid("9aba3b55-9499-4247-90df-13c4a0861643"), new DateTime(2023, 4, 11, 16, 57, 20, 257, DateTimeKind.Local).AddTicks(7788), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 16, 57, 20, 257, DateTimeKind.Local).AddTicks(7787), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321", new DateTime(2023, 4, 14, 16, 57, 20, 257, DateTimeKind.Local).AddTicks(7788), new Guid("803705ab-b2b5-4f2b-97c7-619acba5c6b3") },
                    { new Guid("b1a1a756-4b5d-4cf3-8544-32c03f4036ca"), new Guid("047a8d65-09ce-49da-a97f-5caa499b2ced"), null, new DateTime(2023, 4, 14, 16, 57, 20, 257, DateTimeKind.Local).AddTicks(7769), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812", new DateTime(2023, 4, 14, 16, 57, 20, 257, DateTimeKind.Local).AddTicks(7770), new Guid("803705ab-b2b5-4f2b-97c7-619acba5c6b3") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CONTACTS_UpdatedBy",
                table: "CONTACTS",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactUpdater",
                table: "CONTACTS",
                column: "UpdatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactUpdater",
                table: "CONTACTS");

            migrationBuilder.DropTable(
                name: "PRODUCTS");

            migrationBuilder.DropIndex(
                name: "IX_CONTACTS_UpdatedBy",
                table: "CONTACTS");

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("5f0e03d9-2aad-42e8-b77e-d2384185dea9"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("80415ec2-d795-4173-bba0-a396e2b60a43"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("820f6348-cc4f-4f64-bfea-d64b53078857"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("e8ba99eb-4a43-4f00-8bce-02d66b1089b9"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("ee934792-9dc8-482b-8895-17028c4a88af"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("200c4e80-7444-48c0-ab44-6875a973faed"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5c68d433-c5f9-4388-8730-3077c621d8f4"), new Guid("047a8d65-09ce-49da-a97f-5caa499b2ced") });

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("0ab261b3-b47a-41df-aafa-d59fd4eb5b25"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("854af417-39cc-408a-8ea4-ed03e3e50955"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("b1a1a756-4b5d-4cf3-8544-32c03f4036ca"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("2c05b9ec-5bea-49de-b07b-d655f34c2160"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("4b8dee10-67d4-4ec5-b8cc-434f75a44b88"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("5655f79b-d7ba-4236-b69b-9db52c41c2ac"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("838a4a95-05b2-4d32-9e0a-d11b49b0b1cf"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("932015e1-45c9-481a-87c3-6893013cfac3"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("9c41cd5b-8056-4a01-92b5-20cd9e410d7d"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("cdcbdca4-fd1c-47dd-8b1e-1814b325c472"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("e094e23a-3b91-4298-82e5-20fcc73d4c36"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("4b7a3cfd-d011-40d1-b59c-199240868186"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("61d2bb0b-ef12-4849-9005-6b0b905f0451"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("e70f7e35-0ae0-47b1-92f7-01602ca09faf"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("fbb22c3b-436e-4b92-b80e-d91bdf7d51aa"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("15c02c9b-1dd2-4dce-b885-591cad664638"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("31214d83-edbd-4d97-9984-48d800f8332a"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("577a2fcf-e07e-4461-86a2-1a786195fca3"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("69697d69-bf1e-4725-bce2-4a3782409d43"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("962f1882-4b05-473a-bdf5-8874ebd7f4ad"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("9d97bf9f-2558-42c9-88a8-4611f6af3c22"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("e301ee70-a20c-4f1d-bf08-c4a230fc8ab7"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("e7db9660-07fb-45ab-bfa2-92f6e468cf03"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("0c77e001-ce36-4d06-97c0-e71e0d8df307"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("157d1687-b495-420d-8ab0-d61db7d5ff6d"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("37ad26ad-4e4e-4479-889c-1e60a1254457"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("5c8c884a-caf8-4ccc-ab4f-99d06e18b941"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("bb067170-99d9-4879-9d7b-40bb186ae345"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("f92631b1-f0ee-490f-b211-957169ca0277"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("3b2f74cf-d0b6-4083-9cf5-c2a6ac7a57b5"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("513056b6-8482-447c-a0b9-ba4bc159c3d8"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("9210807b-24f3-472d-9d67-88d67ac2bbae"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("ccee7e45-07ba-425a-ac95-0c50e3bd0ae8"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("d48b9070-9644-423b-87f8-ebf97c049c1a"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("f742ca0e-a818-4f04-8a81-b795c260a892"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5c68d433-c5f9-4388-8730-3077c621d8f4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("047a8d65-09ce-49da-a97f-5caa499b2ced"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("803705ab-b2b5-4f2b-97c7-619acba5c6b3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9aba3b55-9499-4247-90df-13c4a0861643"));

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "CONTACTS");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "CONTACTS");

            migrationBuilder.RenameColumn(
                name: "CityAddress",
                table: "AspNetUsers",
                newName: "Address");

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("3f43fd45-d33b-40de-a76b-b9fff8746e40"), "Presentation" },
                    { new Guid("4bb2b44c-2eba-4b86-8c83-fa03203e99cd"), "Fact-Find" },
                    { new Guid("833c5c52-7a96-4093-833a-13a6c261c7b5"), "Others" },
                    { new Guid("96e9b481-3fc2-46c0-bfe7-61b19114b108"), "Proposal" },
                    { new Guid("ef9fddbc-2daf-4844-8278-00aa0a944a9e"), "Sales Closing" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("57ada34e-61ad-4198-9022-ef59fe5a3ff5"), "cf30eeab-1a01-4ddd-9889-cbbd49fe08de", "User", "USER" },
                    { new Guid("83b60ffa-7c56-4d9f-8b01-1c5b51b6eba0"), "d9c3ecb9-1c1a-441b-8b8f-9a213d0338dd", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("b305efa2-74c3-4fa8-923d-82704ef86928"), 0, "PJ Lhuiller", "d66df6b5-bd02-4b80-a5dd-017d096c52e5", new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEMyZDBVo2W4sswoOg++l4BycyBNEXJTO8JcMFI+wKj01/opqNvFoF/Nwh/G4+dPBXA==", null, true, "", false, "user@crms.com" },
                    { new Guid("eb2a3620-e987-4d20-aebd-677ce35ee381"), 0, "PJ Lhuiller", "0af21859-34f6-441c-8d08-ee04a199ef73", new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEMpw3U+T+4gSam8htYQAwDrURQ0s+3XDn3clxs1s1b8H4obad/m9RbCRP310CpJwAQ==", null, true, "", false, "su@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("38a3e506-8857-443e-b7da-8240a5dd13ff"), "Facebook" },
                    { new Guid("4ed9f580-b0f1-4a97-a96b-5e2c81d65407"), "Phone Call" },
                    { new Guid("67fa3ed9-2040-4996-b731-2a080a699e53"), "WhatsApp" },
                    { new Guid("7ea3917f-6bff-4e83-8af0-fb3ec74748b7"), "Others" },
                    { new Guid("7f5914f1-0fed-4727-80a8-36004a5b4c67"), "Email" },
                    { new Guid("9b9cc17e-1820-492b-96df-ec53fe5cb710"), "Instagram" },
                    { new Guid("b22a9a76-9d25-4a91-95a3-9417e46d7bcb"), "Test Message" },
                    { new Guid("be257324-0fc7-4a28-a39a-e0ccf7f5313b"), "Line" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("75b00347-7f6f-4c88-8da4-df9b36709508"), "Good Engagement" },
                    { new Guid("ae9872e6-9113-46e0-b9ed-f60fcf0967e1"), "Simple Response" },
                    { new Guid("da322339-efda-4155-88a3-92ea5e177167"), "Read but no response" },
                    { new Guid("ea283e72-3a9d-48c2-b0f8-83ae67300c80"), "Not Read" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("042a7ae1-1657-44b4-8dd6-c691a142d043"), "Holiday" },
                    { new Guid("757b1137-4a04-4083-9f5d-809496c8fb94"), "New Product" },
                    { new Guid("88a85a8a-6f70-4e78-abaf-de0025482d03"), "Birthday" },
                    { new Guid("af9642a7-b579-4257-b227-e17cdb059b17"), "Anniversary" },
                    { new Guid("c66ffe5d-8542-4be9-b2ff-084834578bf4"), "Congratulations" },
                    { new Guid("cea87af8-37e4-4fa4-9127-e4ae0bc1ec10"), "Others" },
                    { new Guid("d42abfe7-6daa-4a5c-9186-d4b7ee41f01e"), "Company News" },
                    { new Guid("fffc4bce-8836-4fbe-a9a0-1d15977d39d6"), "Discount" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("4bab5c80-928b-466f-b2fe-75dba618a194"), "Webinar" },
                    { new Guid("4d682473-76f7-4e4c-9949-2dfeddccd72e"), "Friend" },
                    { new Guid("790ba781-6ebc-4b14-974a-e21b1a5d3e2a"), "Referral" },
                    { new Guid("906eb2b7-e542-4fb1-8843-1603bbfec86f"), "Compony-Generated" },
                    { new Guid("c1763c7f-f32a-4b29-9661-edc7a8dc103d"), "Social Media" },
                    { new Guid("e1ef97c7-e561-4bc3-91dc-e4549dc0c6ec"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("1cef44d3-24f2-4da4-b2c5-1176e04b81cf"), "Proposal Generated" },
                    { new Guid("505f3543-8ce3-4068-9f5c-e4696defab41"), "Contacted" },
                    { new Guid("73166078-703a-49cb-ab7f-c8988a7e4118"), "Met" },
                    { new Guid("86ccffe8-4124-45b6-9535-11eaaea71cbe"), "Lead is Dead" },
                    { new Guid("a72742f1-f21e-4839-abdd-f790c61c5ccc"), "Application Submitted" },
                    { new Guid("cb90b4c5-6224-49a1-81d7-c0c049c9358f"), "Policy Issued" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("83b60ffa-7c56-4d9f-8b01-1c5b51b6eba0"), new Guid("eb2a3620-e987-4d20-aebd-677ce35ee381") });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("339b1364-289a-4e3c-a030-92aa414629af"), new Guid("b305efa2-74c3-4fa8-923d-82704ef86928"), new Guid("b305efa2-74c3-4fa8-923d-82704ef86928"), new DateTime(2023, 4, 11, 2, 19, 3, 142, DateTimeKind.Utc).AddTicks(4331), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 2, 19, 3, 142, DateTimeKind.Utc).AddTicks(4330), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321" },
                    { new Guid("4d8a837f-14c2-43ec-830b-7078fcf0de5e"), new Guid("eb2a3620-e987-4d20-aebd-677ce35ee381"), null, new DateTime(2023, 4, 14, 2, 19, 3, 142, DateTimeKind.Utc).AddTicks(4304), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812" },
                    { new Guid("f73874c8-465e-4e0a-a572-cfc8a9c892e2"), new Guid("eb2a3620-e987-4d20-aebd-677ce35ee381"), new Guid("b305efa2-74c3-4fa8-923d-82704ef86928"), new DateTime(2023, 4, 9, 2, 19, 3, 142, DateTimeKind.Utc).AddTicks(4325), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 2, 19, 3, 142, DateTimeKind.Utc).AddTicks(4315), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789" }
                });
        }
    }
}
