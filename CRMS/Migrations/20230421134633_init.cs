using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
<<<<<<<< HEAD:CRMS/Migrations/20230421134633_init.cs
    public partial class init : Migration
========
    public partial class initDBSchema : Migration
>>>>>>>> 9d9dfd1f591db4261a0c1fe0c6eecb69bd4b10e2:CRMS/Migrations/20230421133712_initDBSchema.cs
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
<<<<<<<< HEAD:CRMS/Migrations/20230421134633_init.cs
                    { new Guid("39b0a5ee-f5b7-478c-bcd6-20735cc36233"), "Proposal" },
                    { new Guid("84dff59b-91fd-4d90-b045-73055e32e216"), "Sales Closing" },
                    { new Guid("9d1db14a-a172-41c5-9b56-79f09bc5a82d"), "Others" },
                    { new Guid("aef37697-fbdf-4c43-a72c-18f0f42a6371"), "Fact-Find" },
                    { new Guid("e04ca44f-30de-4431-9dfa-489a64554d63"), "Presentation" }
========
                    { new Guid("0f9aa0c7-a501-4134-b7a2-069781b9100e"), "Fact-Find" },
                    { new Guid("2dc9474a-e468-440d-ac11-6695b9570c34"), "Sales Closing" },
                    { new Guid("686cf830-b97e-438e-8653-a4e6b0d21422"), "Proposal" },
                    { new Guid("a3a815ef-237f-4cc0-bf29-34ddba3d35a5"), "Others" },
                    { new Guid("d76958a3-a4f5-40be-b771-c74ccae03743"), "Presentation" }
>>>>>>>> 9d9dfd1f591db4261a0c1fe0c6eecb69bd4b10e2:CRMS/Migrations/20230421133712_initDBSchema.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
<<<<<<<< HEAD:CRMS/Migrations/20230421134633_init.cs
                    { new Guid("4b54c6a4-33a0-420a-af48-476119f6e188"), "a92b1c2a-0293-45a4-9e9e-cec299e77af2", "User", "USER" },
                    { new Guid("f0c59254-afd8-4fd6-a05f-66233454c1d7"), "f328dcd4-d05d-4b9f-9593-88f36da6f017", "Admin", "ADMIN" }
========
                    { new Guid("2f3a157e-16ff-4645-8fc2-d0195e45e613"), "bcc7a62d-40ca-45e3-bdeb-4ed893430531", "User", "USER" },
                    { new Guid("ac534830-3ebd-48f9-b7e3-7638e5fa2fa4"), "d3e9ce13-1076-4bda-b2c9-ba67d019ec6a", "Admin", "ADMIN" }
>>>>>>>> 9d9dfd1f591db4261a0c1fe0c6eecb69bd4b10e2:CRMS/Migrations/20230421133712_initDBSchema.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityAddress", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:CRMS/Migrations/20230421134633_init.cs
                    { new Guid("20b2435e-493b-4544-8cf2-ed0d95cbd853"), 0, "General Trias", "45bf1e7b-7b70-4636-9d2e-d6ed084d9bb0", new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "sbb@crms.com", true, "Steven", "Barris", true, null, "SBB@CRMS.COM", "SBB@CRMS.COM", "AQAAAAEAACcQAAAAEJ8cR71YfeROaeCV6y3ESoTb9+t4bGFgqcQlxpJa5RMozJjQ+PSYJAeWUEkan5jCIw==", null, true, "", false, "sbb@crms.com" },
                    { new Guid("2f3082ee-bf88-4893-a326-5f93e67865bb"), 0, "Pasay", "39155fca-98f2-46ea-b140-05968f010cd2", new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "cgl@crms.com", true, "Charl", "Legista", true, null, "CGL@CRMS.COM", "CGL@CRMS.COM", "AQAAAAEAACcQAAAAEHGb2uSGRZ545HZMkjIzyURRayztVWKRtVE3bRFnXexD6ohjdzisqiT8tCG6YMLvgg==", null, true, "", false, "cgl@crms.com" },
                    { new Guid("3c09d555-3ee0-4d9c-adba-c7b683aa9bda"), 0, "Makati", "f96f9e92-21a4-4fd2-8ced-250daef0197c", new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "System", "Admin", true, null, "SU@CRMS.COM", "SYSADMIN", "AQAAAAEAACcQAAAAEDD+U/pDTM+Ip1rItuLitp11EjqyZ6AH8yRcVjobPq7qTlQMc+//gsyl8Um8KSxlSA==", null, true, "", false, "SysAdmin" }
========
                    { new Guid("6eb953e5-be60-4cf8-9027-e6e2674b7ef9"), 0, "General Trias", "d4849ed3-1889-4e64-a52c-ee1cb2107ce9", new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "sbb@crms.com", true, "Steven", "Barris", true, null, "SBB@CRMS.COM", "SBB@CRMS.COM", "AQAAAAEAACcQAAAAEPraP8gphO4CP4i7/1lQf4CWuz797XqbBu5XGugZhJvIRGNhjRfYxXVlEMWVMlb/CA==", null, true, "", false, "sbb@crms.com" },
                    { new Guid("87dcfc4e-2dcf-4bfb-bdae-b4a7829c5a78"), 0, "Makati", "b2798b2c-25c4-4332-8665-7758b439dcd1", new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "System", "Admin", true, null, "SU@CRMS.COM", "SYSADMIN", "AQAAAAEAACcQAAAAEElqqM8n/M1ODoGiTkb46W+f1FGTF8kgNVOklG0pJ9hJoq4ey9WQPpI9EAVlbuoeWQ==", null, true, "", false, "SysAdmin" },
                    { new Guid("facbae48-5380-462f-ba63-582480352ade"), 0, "Pasay", "718e8d4b-6532-4596-8375-b94135e943b1", new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "cgl@crms.com", true, "Charl", "Legista", true, null, "CGL@CRMS.COM", "CGL@CRMS.COM", "AQAAAAEAACcQAAAAEG9Skes8CLJ8u/w00u3/1GdZiWpoJhvuJan36ZeAsTQFcabgl9pPE6YD6wHzbzEa1A==", null, true, "", false, "cgl@crms.com" }
>>>>>>>> 9d9dfd1f591db4261a0c1fe0c6eecb69bd4b10e2:CRMS/Migrations/20230421133712_initDBSchema.cs
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
<<<<<<<< HEAD:CRMS/Migrations/20230421134633_init.cs
                    { new Guid("198c5dfc-89d4-45da-9f9d-db04a4c8612b"), "Others" },
                    { new Guid("3c971e05-2006-45b1-ba43-2a669052069a"), "Test Message" },
                    { new Guid("68850ed6-4c3f-45cd-9c52-403cb77d20d4"), "WhatsApp" },
                    { new Guid("68dc300e-1d61-4890-9d67-9c2c9235e067"), "Email" },
                    { new Guid("9eb81189-ff22-4312-86b0-2aa623f49cf8"), "Instagram" },
                    { new Guid("a96c50fd-10dd-4fbf-b584-1c88cbc96b91"), "Line" },
                    { new Guid("c2b2ac6e-9e0a-4696-a99b-ff6638635c5e"), "Facebook" },
                    { new Guid("e8306836-e180-4235-af10-d4ad2a24fdd0"), "Phone Call" }
========
                    { new Guid("564aa4c4-501a-456f-8a26-e1d1c23673f0"), "Line" },
                    { new Guid("5d9e7a0a-33c4-4692-88d1-62d2e7b58af2"), "Phone Call" },
                    { new Guid("99b22594-6e7a-4191-b07f-b8829a0485a1"), "Email" },
                    { new Guid("bb12e619-a56a-4454-ac1f-d0c8f1730249"), "Instagram" },
                    { new Guid("bc329f38-f9ef-4bac-80a0-d9d24bb3e47d"), "WhatsApp" },
                    { new Guid("d24322be-ef85-429a-b468-22e000531172"), "Facebook" },
                    { new Guid("dd716a81-2faa-40e6-aacb-f1657235e7c6"), "Others" },
                    { new Guid("fe00677e-30f2-4e7d-9296-55bfa726d901"), "Test Message" }
>>>>>>>> 9d9dfd1f591db4261a0c1fe0c6eecb69bd4b10e2:CRMS/Migrations/20230421133712_initDBSchema.cs
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
<<<<<<<< HEAD:CRMS/Migrations/20230421134633_init.cs
                    { new Guid("4b24b007-70ea-4f21-8341-cfb6c24ca8dc"), "Good Engagement" },
                    { new Guid("58b8ff06-e900-4bcb-84be-fc115165de00"), "Not Read" },
                    { new Guid("8575c7df-6572-4360-82df-536d60289459"), "Simple Response" },
                    { new Guid("c25f002f-d42c-4e6a-accd-3bf79ab2253e"), "Read but no response" }
========
                    { new Guid("1a936b96-4bc3-48e2-81ff-4ec1756604b3"), "Good Engagement" },
                    { new Guid("4c0c3b60-1d14-44f1-8321-f5d9c16e8b22"), "Not Read" },
                    { new Guid("8ebad41e-83be-4f72-8d4b-5393fe425b20"), "Simple Response" },
                    { new Guid("b822d684-8699-4c84-993c-9a2263707362"), "Read but no response" }
>>>>>>>> 9d9dfd1f591db4261a0c1fe0c6eecb69bd4b10e2:CRMS/Migrations/20230421133712_initDBSchema.cs
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
<<<<<<<< HEAD:CRMS/Migrations/20230421134633_init.cs
                    { new Guid("127077c0-4f59-491c-bfe6-366244f679da"), "Company News" },
                    { new Guid("4914c32b-293a-48f2-ab48-9a61252f1093"), "New Product" },
                    { new Guid("9626081b-9ca7-460c-b138-00ca68366b49"), "Others" },
                    { new Guid("a3bba312-b5bf-4382-b799-6b5d835a4557"), "Anniversary" },
                    { new Guid("ad4fa0e0-235f-4e4a-8ad1-4183bf143c8a"), "Holiday" },
                    { new Guid("ae1f78bf-c4fe-4574-a270-0fb561c57143"), "Discount" },
                    { new Guid("e45b45ae-fa4d-4c61-ab30-584343129340"), "Congratulations" },
                    { new Guid("eed2940f-e022-4e97-a47b-8693629fc42d"), "Birthday" }
========
                    { new Guid("2174d7d5-791a-4007-afcb-64698f845ac8"), "Birthday" },
                    { new Guid("4048b390-7c2b-4915-9b9e-229d09f4de3a"), "New Product" },
                    { new Guid("62d7cc71-2814-4213-b33c-03a6382563de"), "Discount" },
                    { new Guid("86500835-254b-40c2-b0da-88262805bc6b"), "Others" },
                    { new Guid("ad9bd564-7f20-42b1-9a67-43bc8574a32c"), "Company News" },
                    { new Guid("b2591e38-98b4-429b-a5d1-4d5c9a8030b4"), "Congratulations" },
                    { new Guid("c84f9866-3577-437b-81a5-21c34492d02e"), "Holiday" },
                    { new Guid("d0c84295-37d0-4299-86a2-2be49ce52668"), "Anniversary" }
>>>>>>>> 9d9dfd1f591db4261a0c1fe0c6eecb69bd4b10e2:CRMS/Migrations/20230421133712_initDBSchema.cs
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
<<<<<<<< HEAD:CRMS/Migrations/20230421134633_init.cs
                    { new Guid("0f08853b-e6c3-4279-83dc-75fec9f9e0f4"), "Others" },
                    { new Guid("4ecdd1bd-2c86-47c5-b4e9-b7bf791f0c25"), "Referral" },
                    { new Guid("5e354852-d99b-4fe2-85e8-92d7d888ded4"), "Social Media" },
                    { new Guid("8dfaa5e3-5254-428f-b863-a504fcae5ace"), "Webinar" },
                    { new Guid("987460fa-c15a-487e-8206-33b677017030"), "Friend" },
                    { new Guid("d6ec6453-4a4b-4746-a94a-dc51afbefb56"), "Compony-Generated" }
========
                    { new Guid("0b0c7af2-ccc0-48ac-8b12-12653dd594db"), "Social Media" },
                    { new Guid("23898679-6ce2-4890-8fc0-3d1c7ea0f085"), "Company-Generated" },
                    { new Guid("2e23c4b3-3caf-4bd0-8d89-da840a660713"), "Webinar" },
                    { new Guid("5016826c-2573-4db0-aa29-c7ec262c4183"), "Referral" },
                    { new Guid("878c3b67-7dcf-4db5-8349-f3e74a962b86"), "Friend" },
                    { new Guid("b7583693-f11f-4268-8de3-b8d851a1f998"), "Others" }
>>>>>>>> 9d9dfd1f591db4261a0c1fe0c6eecb69bd4b10e2:CRMS/Migrations/20230421133712_initDBSchema.cs
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
<<<<<<<< HEAD:CRMS/Migrations/20230421134633_init.cs
                    { new Guid("1f563ae0-ac07-46d3-aaa0-8ef314964c42"), "Proposal Generated" },
                    { new Guid("20f45bbc-7e7a-4128-b5d4-c565eb2818dc"), "Contacted" },
                    { new Guid("8d947a26-f605-462a-9387-11cc0ce8b525"), "Met" },
                    { new Guid("9d7ad471-1323-4c8c-b2e4-8b80d555977f"), "Policy Issued" },
                    { new Guid("a091124d-db7e-4d22-aa69-68431ffa1db9"), "Application Submitted" },
                    { new Guid("ec4e88a1-7502-46d3-93a2-3dca8b58a168"), "Lead is Dead" }
========
                    { new Guid("3c9c48bf-6a6e-47e5-b6a7-721babf7523b"), "Met" },
                    { new Guid("4d5caa56-5a9a-4cf1-b5fe-27a903b5c1c6"), "Proposal Generated" },
                    { new Guid("6a4f8963-2a09-4f7a-923a-cbec70f196b5"), "Application Submitted" },
                    { new Guid("a54be486-2c3d-4006-b124-2c4cc577d1f9"), "Policy Issued" },
                    { new Guid("d2b0a0b0-40dd-47bd-8295-45265144a9f9"), "Lead is Dead" },
                    { new Guid("e4baf8e7-89d9-47cf-9392-cf41cfbad2af"), "Contacted" }
>>>>>>>> 9d9dfd1f591db4261a0c1fe0c6eecb69bd4b10e2:CRMS/Migrations/20230421133712_initDBSchema.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:CRMS/Migrations/20230421134633_init.cs
                values: new object[] { new Guid("f0c59254-afd8-4fd6-a05f-66233454c1d7"), new Guid("3c09d555-3ee0-4d9c-adba-c7b683aa9bda") });
========
                values: new object[] { new Guid("ac534830-3ebd-48f9-b7e3-7638e5fa2fa4"), new Guid("87dcfc4e-2dcf-4bfb-bdae-b4a7829c5a78") });
>>>>>>>> 9d9dfd1f591db4261a0c1fe0c6eecb69bd4b10e2:CRMS/Migrations/20230421133712_initDBSchema.cs

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
