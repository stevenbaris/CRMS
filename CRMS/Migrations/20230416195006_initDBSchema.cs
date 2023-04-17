using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class initDBSchema : Migration
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
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactOwnerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateAssigned = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactCreatorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "PRODUCTS",
                columns: table => new
                {
                    Product_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Benefits = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdaterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTS", x => x.Product_Id);
                    table.ForeignKey(
                        name: "FK_PRODUCTS_AspNetUsers_UpdaterId",
                        column: x => x.UpdaterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("27e12145-648f-42bd-a07d-061fb3b7a6a7"), "Fact-Find" },
                    { new Guid("98b4e42b-29ea-41b4-a708-a12e4d557e95"), "Sales Closing" },
                    { new Guid("a7363c54-3d12-4489-940d-bc37ceb557e1"), "Others" },
                    { new Guid("a7495e8a-edd8-4fe8-81b0-77e27b3334aa"), "Presentation" },
                    { new Guid("b0f2ffee-4b24-46ab-b7e1-c0dae2535650"), "Proposal" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2f27f58a-382d-42d6-8e7e-c3f64dea0b9a"), "5144952b-5cad-4be8-b514-c9e2bd42e574", "Admin", "ADMIN" },
                    { new Guid("3e76ae20-2614-4b40-a962-f55555087bae"), "44ce48c0-b315-44fb-a737-936a24f458e4", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityAddress", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0cd247a9-1ffe-4701-98b2-59f8d914d428"), 0, "Makati", "182eb692-3faa-4f99-a626-8c11b493fdc0", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEBoZy2FRB7dOSupsrc2KeVLq9J7C0/06qLyZXChFEIIzYh0OQmM4CrH203MffzOXPw==", null, true, "", false, "su@crms.com" },
                    { new Guid("0de1f25e-9466-4e0f-8ee8-e31342a61ae3"), 0, "Makati", "34d8ad02-0348-477e-84e1-d32f0c897a80", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEFhbEu/dg3Tuhn4ruNH5tGS7vkMyGmIx/HF5AD21KfFtJvlNzBy/AZh8foHyGZoFgQ==", null, true, "", false, "user@crms.com" },
                    { new Guid("be8108c2-10df-4a36-94d0-28c59ba26f6f"), 0, "Makati", "75e25c42-d642-4eab-a82d-3ae8a84df889", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "sys@crms.com", true, "SYSTEM", "CRMS", true, null, "SYS@CRMS.COM", "SYSTEM", "AQAAAAEAACcQAAAAEIGXEQUF0kNDifPMKLs/793vOBa8RQtp8nLsbhZBnbEt3E/HfcZaAk9qsmnZC7FUmg==", null, true, "", false, "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("49910645-e8bb-4477-bcf5-6961c76ee9aa"), "WhatsApp" },
                    { new Guid("5712d76f-3b52-49eb-953b-86a35885c1ca"), "Instagram" },
                    { new Guid("751811bb-dd5f-49b7-bee3-e79d7e031957"), "Test Message" },
                    { new Guid("7a158181-2cb7-4027-93df-88fd0e7af42e"), "Email" },
                    { new Guid("a43a2215-cadd-4329-8f0f-0e3cf2975a1a"), "Facebook" },
                    { new Guid("a9501733-b1e8-4262-b736-8c2ccfbd82de"), "Line" },
                    { new Guid("d1d9438b-ab8b-4916-8234-9be248c0075f"), "Others" },
                    { new Guid("f5c2a3ee-68fc-4829-814a-0e4d68eaf8a2"), "Phone Call" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("1b337aa3-8b2b-4f6b-94bc-e8e96fe3f1e9"), "Not Read" },
                    { new Guid("1c0d88fe-7b56-4d53-8b4a-ad41ae912961"), "Good Engagement" },
                    { new Guid("3f429b6f-33e2-4ffc-99df-81f6cf645009"), "Read but no response" },
                    { new Guid("facb73ff-5526-40ca-be28-fdc4ca7f6728"), "Simple Response" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("0de31afd-d659-4c1a-a8cd-5c27fb19a360"), "Discount" },
                    { new Guid("1550ba58-0d8d-4153-962a-c5093db7c1b2"), "New Product" },
                    { new Guid("1b36ae57-6621-40ea-812c-b5116182d8c9"), "Congratulations" },
                    { new Guid("5e9cbdb7-2823-4ed4-b2fe-cbc0475c5d17"), "Anniversary" },
                    { new Guid("69baf32f-ac19-4b94-b187-f5c16a3f5b0c"), "Company News" },
                    { new Guid("b68cd17a-b0f2-4a98-8a4e-2996e37b9d8c"), "Birthday" },
                    { new Guid("c47497f7-566b-4f0e-9eb5-f1f4860f11f8"), "Holiday" },
                    { new Guid("ebd43c84-b692-4cee-a81b-d02ec9767f68"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("2a8d07ca-48df-49d9-a99f-016b5460d3f1"), "Others" },
                    { new Guid("344c3cf8-dd11-4be7-a038-1b9b1c6d6225"), "Social Media" },
                    { new Guid("432c211e-8d3d-424a-bcd9-944c6a19722c"), "Webinar" },
                    { new Guid("7788bb4d-3421-4c45-bfe7-8d5c439788c9"), "Compony-Generated" },
                    { new Guid("bd6cd130-a965-435c-917b-70ae35eb9648"), "Referral" },
                    { new Guid("f5ff4166-2ca9-4438-815f-7f8e85698ae8"), "Friend" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("073406cc-5829-4510-97e5-49642b5b01b8"), "Contacted" },
                    { new Guid("4016a6f4-9688-4ce3-adbd-54801ab95b98"), "Proposal Generated" },
                    { new Guid("bae12886-507d-466f-8928-7469680d821d"), "Policy Issued" },
                    { new Guid("bf6676b5-4c03-402c-a5ec-849b8a32f2bf"), "Lead is Dead" },
                    { new Guid("c5aa33a2-cce6-4455-874b-c195160c320b"), "Application Submitted" },
                    { new Guid("c87edbd6-bbbf-4bb0-aca7-2c62bf8c85c0"), "Met" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("2f27f58a-382d-42d6-8e7e-c3f64dea0b9a"), new Guid("0cd247a9-1ffe-4701-98b2-59f8d914d428") });

            migrationBuilder.InsertData(
                table: "CONTACTS",
                columns: new[] { "Contact_Id", "ContactCreatorID", "ContactOwnerID", "CreateDate", "DOB", "DateAssigned", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "UpdateDate", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("27e4f7e4-e9c3-48af-8645-e9c4e5a30b4c"), new Guid("0de1f25e-9466-4e0f-8ee8-e31342a61ae3"), new Guid("0de1f25e-9466-4e0f-8ee8-e31342a61ae3"), new DateTime(2023, 4, 14, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5644), new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5642), "cust.no1@gmail.com", "Customer", 1, "Number1", "09987654321", new DateTime(2023, 4, 17, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5644), new Guid("be8108c2-10df-4a36-94d0-28c59ba26f6f") },
                    { new Guid("6766a803-0936-4316-b4ae-202509af9329"), new Guid("0cd247a9-1ffe-4701-98b2-59f8d914d428"), new Guid("0de1f25e-9466-4e0f-8ee8-e31342a61ae3"), new DateTime(2023, 4, 12, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5632), new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5623), "steven.baris14@gmail.com", "Steven", 0, "Baris", "09123456789", new DateTime(2023, 4, 17, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5633), new Guid("be8108c2-10df-4a36-94d0-28c59ba26f6f") },
                    { new Guid("a7710c8e-6a00-4f5d-b647-1b707210e83b"), new Guid("0cd247a9-1ffe-4701-98b2-59f8d914d428"), null, new DateTime(2023, 4, 17, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5614), new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charl.legista@gmail.com", "Charl", 0, "Legista", "09052214812", new DateTime(2023, 4, 17, 3, 50, 5, 671, DateTimeKind.Local).AddTicks(5615), new Guid("be8108c2-10df-4a36-94d0-28c59ba26f6f") }
                });

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
                name: "IX_PRODUCTS_UpdaterId",
                table: "PRODUCTS",
                column: "UpdaterId");

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
