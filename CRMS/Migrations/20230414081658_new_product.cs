using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class new_product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("112f0ffb-73bc-429d-af08-44f61e314d7a"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("2be98237-5fd2-4c0c-96ef-c957f7476daa"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("632c46e7-15a7-4fa2-86b6-ba4e39211581"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("8c8e9517-4cbc-416b-a778-044e2cd0a130"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("cbd58f0c-e643-4bff-9c7c-d68ad377b186"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ec75ade8-2b70-48a9-bc0d-8b50b3f5277d"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0270cfd7-431a-445d-acbf-70f14a7ce3da"), new Guid("f9328731-c1d9-4261-aee8-97bc9e882395") });

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("0d58cca3-9950-429e-bdd2-cd38dbfd2d09"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("1cac2023-9516-4d56-a04a-0cf25f5becfe"));

            migrationBuilder.DeleteData(
                table: "CONTACTS",
                keyColumn: "Contact_Id",
                keyValue: new Guid("e3c5d2df-4bf0-4e5f-9cc8-d596b80cb0a3"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("0a5a0afe-adba-49ae-96c3-5292e344f70e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("23eebb60-6be7-476a-8f5c-e242748957ef"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("52e886e6-4d3f-4da3-b457-29699b9acc37"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("588030cc-b82a-4186-8dfa-4552e2ce7eff"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("887a8817-6292-467f-97aa-b3972c2b78b2"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("9207a9a2-36a7-4498-947a-6ac325328f51"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("97ce6732-1bb7-4500-bd04-6555ad2004a0"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("ed47b18f-dda4-4f30-b09d-94568cdecc9c"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("23df6c3d-0e15-4b10-a76f-8c34ea52ecd9"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("a2e7bc6d-bf01-406e-b108-c16a16c27dbb"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("b6455330-34b6-4e6c-bd1b-64488162ae48"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("b66a0bd9-a659-4615-bfb2-010bcab31fed"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("15342ef8-055c-495a-800b-646c20e9c437"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("1c865537-3674-496d-9cdd-fa3617ec62fc"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("31c4b94d-7756-4862-8895-f9b5d5dba105"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("41018317-a382-4518-8e97-ff9356a6b48d"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("55c9756d-cc2a-49df-9ab7-e23903e8d86b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("6a50cf61-33b7-4f89-b4f5-b6607bfe823d"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("6c4f15d5-ba7b-46bc-800c-e93d809b5570"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("fbbb8497-95dc-46be-924f-70788ddf814e"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("45292a53-127e-410f-bd0e-567440656db0"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("45fe67e0-18e3-4969-926c-5ed43f8c4532"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("5301480b-6f4f-4432-94fc-dc2cb55ba4ed"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("699bc871-4fa2-4c32-ab5c-7081fcbc906d"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("819c8984-0925-46d9-8983-c80fbba5cd91"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("cb620386-2bfa-4b39-894b-22c87a61c352"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("1af784cf-46b8-42c4-8333-9c61bd00a6ed"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("1e3c7651-4369-4882-958f-c24e9c7a3be1"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("272ca292-8911-4fd4-b6da-99ddedf51f30"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("2f1cb6e5-a221-4793-b0cb-2a2db135b646"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("8d9e0e32-8119-46eb-b61c-a363c48d52e0"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("ee8bc28a-d95a-40d0-bcc2-b8e20170c6ec"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0270cfd7-431a-445d-acbf-70f14a7ce3da"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("adf24f81-5b31-46f6-8d07-0adf3bdd2c4f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f9328731-c1d9-4261-aee8-97bc9e882395"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "LEADS",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_LEADS_ProductId",
                table: "LEADS",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsProduct",
                table: "LEADS",
                column: "ProductId",
                principalTable: "PRODUCTS",
                principalColumn: "Product_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadsProduct",
                table: "LEADS");

            migrationBuilder.DropTable(
                name: "PRODUCTS");

            migrationBuilder.DropIndex(
                name: "IX_LEADS_ProductId",
                table: "LEADS");

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

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "LEADS");

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("112f0ffb-73bc-429d-af08-44f61e314d7a"), "Presentation" },
                    { new Guid("2be98237-5fd2-4c0c-96ef-c957f7476daa"), "Proposal" },
                    { new Guid("632c46e7-15a7-4fa2-86b6-ba4e39211581"), "Others" },
                    { new Guid("8c8e9517-4cbc-416b-a778-044e2cd0a130"), "Sales Closing" },
                    { new Guid("cbd58f0c-e643-4bff-9c7c-d68ad377b186"), "Fact-Find" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0270cfd7-431a-445d-acbf-70f14a7ce3da"), "00046a75-9ee2-4876-b015-1dcfceeedd12", "Admin", "ADMIN" },
                    { new Guid("ec75ade8-2b70-48a9-bc0d-8b50b3f5277d"), "8a3f7ab1-d124-4cb8-b7b4-5d8a0d891958", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("adf24f81-5b31-46f6-8d07-0adf3bdd2c4f"), 0, "PJ Lhuiller", "70090132-ddc1-432a-a0c5-9b3a44e52925", new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEBBO27Byqq8HpwAt+sTP71Ze8jeZ+4HX/AXwEH8P7elFIpduNGc6NVG8pxCVvemBow==", null, true, "", false, "user@crms.com" },
                    { new Guid("f9328731-c1d9-4261-aee8-97bc9e882395"), 0, "PJ Lhuiller", "d31c016d-1662-4825-a570-07ae9aa8c554", new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEEaRkDBtjWAhDgHlBzigmhXVQL2IyvI6iW99xEoAs6x+l5bGPLyJkjQ07y6ajEXCkg==", null, true, "", false, "su@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("0a5a0afe-adba-49ae-96c3-5292e344f70e"), "Email" },
                    { new Guid("23eebb60-6be7-476a-8f5c-e242748957ef"), "WhatsApp" },
                    { new Guid("52e886e6-4d3f-4da3-b457-29699b9acc37"), "Test Message" },
                    { new Guid("588030cc-b82a-4186-8dfa-4552e2ce7eff"), "Others" },
                    { new Guid("887a8817-6292-467f-97aa-b3972c2b78b2"), "Phone Call" },
                    { new Guid("9207a9a2-36a7-4498-947a-6ac325328f51"), "Facebook" },
                    { new Guid("97ce6732-1bb7-4500-bd04-6555ad2004a0"), "Line" },
                    { new Guid("ed47b18f-dda4-4f30-b09d-94568cdecc9c"), "Instagram" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("23df6c3d-0e15-4b10-a76f-8c34ea52ecd9"), "Simple Response" },
                    { new Guid("a2e7bc6d-bf01-406e-b108-c16a16c27dbb"), "Good Engagement" },
                    { new Guid("b6455330-34b6-4e6c-bd1b-64488162ae48"), "Not Read" },
                    { new Guid("b66a0bd9-a659-4615-bfb2-010bcab31fed"), "Read but no response" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("15342ef8-055c-495a-800b-646c20e9c437"), "Holiday" },
                    { new Guid("1c865537-3674-496d-9cdd-fa3617ec62fc"), "New Product" },
                    { new Guid("31c4b94d-7756-4862-8895-f9b5d5dba105"), "Anniversary" },
                    { new Guid("41018317-a382-4518-8e97-ff9356a6b48d"), "Company News" },
                    { new Guid("55c9756d-cc2a-49df-9ab7-e23903e8d86b"), "Birthday" },
                    { new Guid("6a50cf61-33b7-4f89-b4f5-b6607bfe823d"), "Congratulations" },
                    { new Guid("6c4f15d5-ba7b-46bc-800c-e93d809b5570"), "Discount" },
                    { new Guid("fbbb8497-95dc-46be-924f-70788ddf814e"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("45292a53-127e-410f-bd0e-567440656db0"), "Social Media" },
                    { new Guid("45fe67e0-18e3-4969-926c-5ed43f8c4532"), "Compony-Generated" },
                    { new Guid("5301480b-6f4f-4432-94fc-dc2cb55ba4ed"), "Referral" },
                    { new Guid("699bc871-4fa2-4c32-ab5c-7081fcbc906d"), "Friend" },
                    { new Guid("819c8984-0925-46d9-8983-c80fbba5cd91"), "Others" },
                    { new Guid("cb620386-2bfa-4b39-894b-22c87a61c352"), "Webinar" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("1af784cf-46b8-42c4-8333-9c61bd00a6ed"), "Proposal Generated" },
                    { new Guid("1e3c7651-4369-4882-958f-c24e9c7a3be1"), "Contacted" },
                    { new Guid("272ca292-8911-4fd4-b6da-99ddedf51f30"), "Application Submitted" },
                    { new Guid("2f1cb6e5-a221-4793-b0cb-2a2db135b646"), "Policy Issued" },
                    { new Guid("8d9e0e32-8119-46eb-b61c-a363c48d52e0"), "Met" },
                    { new Guid("ee8bc28a-d95a-40d0-bcc2-b8e20170c6ec"), "Lead is Dead" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("0270cfd7-431a-445d-acbf-70f14a7ce3da"), new Guid("f9328731-c1d9-4261-aee8-97bc9e882395") });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("0d58cca3-9950-429e-bdd2-cd38dbfd2d09"), new Guid("f9328731-c1d9-4261-aee8-97bc9e882395"), new Guid("adf24f81-5b31-46f6-8d07-0adf3bdd2c4f"), new DateTime(2023, 4, 9, 7, 13, 42, 293, DateTimeKind.Utc).AddTicks(9686), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 7, 13, 42, 293, DateTimeKind.Utc).AddTicks(9674), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789" },
                    { new Guid("1cac2023-9516-4d56-a04a-0cf25f5becfe"), new Guid("f9328731-c1d9-4261-aee8-97bc9e882395"), null, new DateTime(2023, 4, 14, 7, 13, 42, 293, DateTimeKind.Utc).AddTicks(9671), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812" },
                    { new Guid("e3c5d2df-4bf0-4e5f-9cc8-d596b80cb0a3"), new Guid("adf24f81-5b31-46f6-8d07-0adf3bdd2c4f"), new Guid("adf24f81-5b31-46f6-8d07-0adf3bdd2c4f"), new DateTime(2023, 4, 11, 7, 13, 42, 293, DateTimeKind.Utc).AddTicks(9689), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 7, 13, 42, 293, DateTimeKind.Utc).AddTicks(9688), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321" }
                });
        }
    }
}
