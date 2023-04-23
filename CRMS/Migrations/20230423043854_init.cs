using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APPOINTMENT_PURPOSES",
                columns: table => new
                {
                    Purpose_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurposeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPOINTMENT_PURPOSES", x => x.Purpose_Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: table => new
                {
                    CommunicationMethod_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommunicationMethodName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENGAGEMENT_COMMUNICATION METHODS", x => x.CommunicationMethod_Id);
                });

            migrationBuilder.CreateTable(
                name: "ENGAGEMENT_EFFECTIVITY",
                columns: table => new
                {
                    Effectivity_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Effectivity_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENGAGEMENT_EFFECTIVITY", x => x.Effectivity_Id);
                });

            migrationBuilder.CreateTable(
                name: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: table => new
                {
                    EType_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EngagementName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENGAGEMENT_ENGAGEMENT-TYPES", x => x.EType_Id);
                });

            migrationBuilder.CreateTable(
                name: "LEADS_SOURCES",
                columns: table => new
                {
                    Source_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LEADS_SOURCES", x => x.Source_Id);
                });

            migrationBuilder.CreateTable(
                name: "LEADS_STATUSES",
                columns: table => new
                {
                    LeadStatus_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeadStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LEADS_STATUSES", x => x.LeadStatus_Id);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTS",
                columns: table => new
                {
                    Product_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Benefits = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTS", x => x.Product_Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CONTACTS",
                columns: table => new
                {
                    Contact_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactOwnerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateAssigned = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactCreatorID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTACTS", x => x.Contact_Id);
                    table.ForeignKey(
                        name: "FK_ContactCreator",
                        column: x => x.ContactCreatorID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContactOwner",
                        column: x => x.ContactOwnerID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContactUpdater",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "APPOINTMENTS",
                columns: table => new
                {
                    Appointment_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Appointment_DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchedStatus = table.Column<int>(type: "int", nullable: false),
                    PurposeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPOINTMENTS", x => x.Appointment_Id);
                    table.ForeignKey(
                        name: "FK_AppointmentCreator",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentProspect",
                        column: x => x.ContactId,
                        principalTable: "CONTACTS",
                        principalColumn: "Contact_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentPurpose",
                        column: x => x.PurposeId,
                        principalTable: "APPOINTMENT_PURPOSES",
                        principalColumn: "Purpose_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ENGAGEMENTS",
                columns: table => new
                {
                    Engagement_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Engagement_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Engagement_Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ETypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EffectivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommsMethodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENGAGEMENTS", x => x.Engagement_Id);
                    table.ForeignKey(
                        name: "FK_CommunicationMethod",
                        column: x => x.CommsMethodId,
                        principalTable: "ENGAGEMENT_COMMUNICATION METHODS",
                        principalColumn: "CommunicationMethod_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts",
                        column: x => x.ContactId,
                        principalTable: "CONTACTS",
                        principalColumn: "Contact_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Creator",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Effectivity",
                        column: x => x.EffectivityId,
                        principalTable: "ENGAGEMENT_EFFECTIVITY",
                        principalColumn: "Effectivity_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EngagementType",
                        column: x => x.ETypeId,
                        principalTable: "ENGAGEMENT_ENGAGEMENT-TYPES",
                        principalColumn: "EType_Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_LeadsProduct",
                        column: x => x.ProductId,
                        principalTable: "PRODUCTS",
                        principalColumn: "Product_Id",
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

            migrationBuilder.CreateTable(
                name: "ROLLING TRANSACTIONS",
                columns: table => new
                {
                    RollingTransactions_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransacationTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLLING TRANSACTIONS", x => x.RollingTransactions_ID);
                    table.ForeignKey(
                        name: "FK_TransactionsOfContact",
                        column: x => x.ContactId,
                        principalTable: "CONTACTS",
                        principalColumn: "Contact_Id");
                });

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("19295bc9-4ebc-41d3-ba7c-93e97e50300b"), "Sales Closing" },
                    { new Guid("4de11577-97e5-411b-a3fd-f38c637a7ea1"), "Others" },
                    { new Guid("7e097194-88c8-4603-8b2c-6b1fda44a94b"), "Fact-Find" },
                    { new Guid("8af78be5-9d77-4d98-9ad4-148804a43af6"), "Presentation" },
                    { new Guid("f01cceed-38f6-49be-a437-31eab4ca2cc8"), "Proposal" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("58bb07a5-b48a-4749-8e88-0a504d468859"), "d814fc7f-ef67-4bfc-8dca-625d789c3346", "User", "USER" },
                    { new Guid("c45c3c4f-f2e3-440f-8fb6-daab50828073"), "88c26811-b513-4b37-a23b-c6c514637436", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityAddress", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("a08cfa60-68a7-41a0-83b7-9c6fd33f8b0b"), 0, "General Trias", "e4c1eb2b-a30c-492a-a18a-798230025251", new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), "sbb@crms.com", true, "Steven", "Barris", true, null, "SBB@CRMS.COM", "SBB@CRMS.COM", "AQAAAAEAACcQAAAAEHsBbnRhStWeSVCOZPfoh9DirQcTqtU89ood05QnxbvqgrK7qYx5tKTkZTCoFfJhKA==", null, true, "", false, "sbb@crms.com" },
                    { new Guid("b49052f5-dffc-44e4-8092-23712fc0fccf"), 0, "Pasay", "d557b409-0cb4-47dc-ac94-eb0260e3510a", new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), "cgl@crms.com", true, "Charl", "Legista", true, null, "CGL@CRMS.COM", "CGL@CRMS.COM", "AQAAAAEAACcQAAAAEOSqO1hoGb6aigVzkHqjVzuaWULFXNe+X5EZdc+Y3t+oMiK6zq2nbcit8FuKmdwWHg==", null, true, "", false, "cgl@crms.com" },
                    { new Guid("d5311e93-cfc7-4463-8e94-8fdc4085546f"), 0, "Makati", "5cc7a742-2417-489a-a9ab-ef3d849048a7", new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "System", "Admin", true, null, "SU@CRMS.COM", "SYSADMIN", "AQAAAAEAACcQAAAAEIa/AjKxiItKhxGRXAsSavSLnXVG3X+PukOVZR+FDTnTiAIBhsszBMqXvI80IDBROg==", null, true, "", false, "SysAdmin" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("109178d1-9625-4f5a-a900-d81f29655f0a"), "WhatsApp" },
                    { new Guid("3b64402f-a2bb-4968-8e68-9a1a768182f3"), "Email" },
                    { new Guid("4ee8f2a9-13d1-4d9b-b04d-a5e8274b4f58"), "Others" },
                    { new Guid("65a4d865-33a4-4c37-a265-fdd9a0560db6"), "Facebook" },
                    { new Guid("83d29e16-7ce5-49bf-b487-d90c23d8d4e0"), "Test Message" },
                    { new Guid("d1b9e376-0089-4a65-9e7b-f3fbd235bf47"), "Line" },
                    { new Guid("f210638e-3e95-49ab-9bf4-f999ce3c3dfd"), "Instagram" },
                    { new Guid("f75f329f-f7df-4197-9485-f3565bdc173b"), "Phone Call" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("17a8fde8-f643-46f3-a6cf-d251b4bbd47b"), "Simple Response" },
                    { new Guid("3007a986-afd5-4103-a6d0-0dcae3b71831"), "Good Engagement" },
                    { new Guid("37cc2e45-bbf3-481c-94c3-6ee10dfa4afc"), "Read but no response" },
                    { new Guid("b864aba8-4cf1-47c3-9df1-8043ee940f43"), "Not Read" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("78afca48-e145-4e4a-afe1-1e725b9801b3"), "New Product" },
                    { new Guid("7f88b21e-33ef-4ca3-b731-c63d1ed9852c"), "Others" },
                    { new Guid("8d161b70-5765-4e62-baeb-0d660f276bba"), "Anniversary" },
                    { new Guid("b7518984-0799-4484-ad7d-b7fd2beb9931"), "Company News" },
                    { new Guid("bc1218da-eb90-4531-a989-4a5c5f3ce643"), "Congratulations" },
                    { new Guid("d250ccc3-e495-451e-99be-b4c3a4fad626"), "Discount" },
                    { new Guid("e8486d6d-b7b4-4574-be94-4dc618891f83"), "Birthday" },
                    { new Guid("ffba5d44-6ea4-4cd2-9893-a58b1d6d460a"), "Holiday" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("03a0a227-c464-4f8b-a8ba-cbec2435c6ca"), "Referral" },
                    { new Guid("72d8a277-00f7-4286-8c08-463f143e57bb"), "Webinar" },
                    { new Guid("97b91743-9090-4f05-a531-7e19069a20c5"), "Friend" },
                    { new Guid("a131c28a-1581-4b21-8aad-c6372729df8d"), "Others" },
                    { new Guid("d06a5190-6278-4fb6-bc09-71c62e575e04"), "Social Media" },
                    { new Guid("f4352ea1-d4a5-4bfe-b176-a5566ffb7717"), "Company-Generated" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("07a95866-2c7f-489c-a7f8-51b89dd57b30"), "Contacted" },
                    { new Guid("23515de1-d827-42f2-b60a-85fa3f4fc595"), "Proposal Generated" },
                    { new Guid("43cd22a5-efde-44f3-b7fa-9c2788a928a0"), "Application Submitted" },
                    { new Guid("4e7d7b17-8253-4729-bbe6-fced79833fd1"), "Met" },
                    { new Guid("a390d9b5-b329-4322-b46d-d6fcbb4f6803"), "Policy Issued" },
                    { new Guid("c3c1048c-a22b-4901-916f-73791280f763"), "Lead is Dead" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("c45c3c4f-f2e3-440f-8fb6-daab50828073"), new Guid("d5311e93-cfc7-4463-8e94-8fdc4085546f") });

            migrationBuilder.CreateIndex(
                name: "IX_APPOINTMENTS_ContactId",
                table: "APPOINTMENTS",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_APPOINTMENTS_CreatedBy",
                table: "APPOINTMENTS",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_APPOINTMENTS_PurposeId",
                table: "APPOINTMENTS",
                column: "PurposeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CONTACTS_ContactCreatorID",
                table: "CONTACTS",
                column: "ContactCreatorID");

            migrationBuilder.CreateIndex(
                name: "IX_CONTACTS_ContactOwnerID",
                table: "CONTACTS",
                column: "ContactOwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_CONTACTS_Email",
                table: "CONTACTS",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CONTACTS_UpdatedBy",
                table: "CONTACTS",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ENGAGEMENTS_CommsMethodId",
                table: "ENGAGEMENTS",
                column: "CommsMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_ENGAGEMENTS_ContactId",
                table: "ENGAGEMENTS",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_ENGAGEMENTS_CreatedById",
                table: "ENGAGEMENTS",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ENGAGEMENTS_EffectivityId",
                table: "ENGAGEMENTS",
                column: "EffectivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ENGAGEMENTS_ETypeId",
                table: "ENGAGEMENTS",
                column: "ETypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LEADS_CreatedBy",
                table: "LEADS",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LEADS_LeadSourceId",
                table: "LEADS",
                column: "LeadSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_LEADS_ProductId",
                table: "LEADS",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_LEADS_ProspectId",
                table: "LEADS",
                column: "ProspectId");

            migrationBuilder.CreateIndex(
                name: "IX_LEADS_StatusId",
                table: "LEADS",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ROLLING TRANSACTIONS_ContactId",
                table: "ROLLING TRANSACTIONS",
                column: "ContactId",
                unique: true,
                filter: "[ContactId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APPOINTMENTS");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ENGAGEMENTS");

            migrationBuilder.DropTable(
                name: "LEADS");

            migrationBuilder.DropTable(
                name: "ROLLING TRANSACTIONS");

            migrationBuilder.DropTable(
                name: "APPOINTMENT_PURPOSES");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ENGAGEMENT_COMMUNICATION METHODS");

            migrationBuilder.DropTable(
                name: "ENGAGEMENT_EFFECTIVITY");

            migrationBuilder.DropTable(
                name: "ENGAGEMENT_ENGAGEMENT-TYPES");

            migrationBuilder.DropTable(
                name: "PRODUCTS");

            migrationBuilder.DropTable(
                name: "LEADS_SOURCES");

            migrationBuilder.DropTable(
                name: "LEADS_STATUSES");

            migrationBuilder.DropTable(
                name: "CONTACTS");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
