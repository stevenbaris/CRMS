using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class records_leads : Migration
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

            migrationBuilder.CreateTable(
                name: "LEADS",
                columns: table => new
                {
                    Leads_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Leads_DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrefContactMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrefContactDay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrefContactTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProspectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeadSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LEADS", x => x.Leads_Id);
                    table.ForeignKey(
                        name: "FK_LeadsCreator",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadsProspect",
                        column: x => x.ProspectId,
                        principalTable: "CONTACTS",
                        principalColumn: "Contact_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadsSource",
                        column: x => x.LeadSourceId,
                        principalTable: "LEADS_SOURCES",
                        principalColumn: "Source_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadsStatus",
                        column: x => x.StatusId,
                        principalTable: "LEADS_STATUSES",
                        principalColumn: "LeadStatus_Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LEADS_CreatedBy",
                table: "LEADS",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LEADS_LeadSourceId",
                table: "LEADS",
                column: "LeadSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_LEADS_ProspectId",
                table: "LEADS",
                column: "ProspectId");

            migrationBuilder.CreateIndex(
                name: "IX_LEADS_StatusId",
                table: "LEADS",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LEADS");

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
