using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
<<<<<<<< HEAD:CRMS/Migrations/20230423200040_initDBSchema042423.cs
    public partial class initDBSchema042423 : Migration
========
    public partial class init : Migration
>>>>>>>> 7240e749e6afa22f4ee53fd1ae0d3ea67611fc48:CRMS/Migrations/20230423093856_init.cs
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
                    isHidden = table.Column<bool>(type: "bit", nullable: false),
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
                    IsLocal = table.Column<bool>(type: "bit", nullable: false),
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
<<<<<<<< HEAD:CRMS/Migrations/20230423200040_initDBSchema042423.cs
                    { new Guid("06ea6c17-714f-47ef-a50a-177bdea0934d"), "Others" },
                    { new Guid("499871d7-1bc7-4102-857e-8972755c1a1c"), "Fact-Find" },
                    { new Guid("727a1bc8-3a8f-4ee8-97d3-6a94531b2b83"), "Presentation" },
                    { new Guid("8ad436ec-a101-4bb8-a320-8cdd1d50a914"), "Proposal" },
                    { new Guid("bffea4d7-9e98-4bb3-a48b-67225c55ecac"), "Sales Closing" }
========
                    { new Guid("17618a75-4ccd-4791-8031-69b263b8bd8b"), "Fact-Find" },
                    { new Guid("4f318d3b-4b83-4e3c-9948-6167a933c13f"), "Proposal" },
                    { new Guid("695d0f03-c986-47b4-b30a-16c3ea5db64a"), "Sales Closing" },
                    { new Guid("bbf31318-e6a5-433c-bea8-307c557d01fd"), "Presentation" },
                    { new Guid("d769d517-77c0-402b-b5d5-903c0d88737a"), "Others" }
>>>>>>>> 7240e749e6afa22f4ee53fd1ae0d3ea67611fc48:CRMS/Migrations/20230423093856_init.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
<<<<<<<< HEAD:CRMS/Migrations/20230423200040_initDBSchema042423.cs
                    { new Guid("85990ed4-8dbf-42a2-8ab2-3c9021385646"), "a974f481-64ba-4c9b-ba4e-b71ecf18a976", "User", "USER" },
                    { new Guid("eab657c4-6689-4028-bbb4-a6896c08c0b0"), "f2f178fe-c1bf-4876-905b-cd27ab5f8fda", "Admin", "ADMIN" }
========
                    { new Guid("00cfb9ad-32f7-4fd6-b661-4cd41d87194d"), "44838ed8-7994-4f4f-ab69-2f2264a9e059", "User", "USER" },
                    { new Guid("fc397f0f-4f1c-4908-a164-6828401b83dd"), "7f075340-59e7-4bfb-9ec9-3673fc4cfe0b", "Admin", "ADMIN" }
>>>>>>>> 7240e749e6afa22f4ee53fd1ae0d3ea67611fc48:CRMS/Migrations/20230423093856_init.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityAddress", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isHidden" },
                values: new object[,]
                {
<<<<<<<< HEAD:CRMS/Migrations/20230423200040_initDBSchema042423.cs
                    { new Guid("1d20c7d3-d246-4fc2-9b15-75e4b5769074"), 0, "General Trias", "90be228b-4d46-466e-b357-a79e51b89a75", new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "sbb@crms.com", true, "Steven", "Baris", true, null, "SBB@CRMS.COM", "SBB@CRMS.COM", "AQAAAAEAACcQAAAAEDEBeac4uRZjCvAteS6mE0l/A7JKr+OanqF0ppOUORXUmMeuMxhpP2JfJ86nzyIDSw==", null, true, "", false, "sbb@crms.com", false },
                    { new Guid("ad5f6c61-63ef-4be2-a9fa-7376f3f0f828"), 0, "Pasay", "db6e4909-2159-451a-b3d3-bbb840307081", new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "cgl@crms.com", true, "Charl", "Legista", true, null, "CGL@CRMS.COM", "CGL@CRMS.COM", "AQAAAAEAACcQAAAAEIn4zwscNkGVNJLeMPeXmjeRViNT1XN3FT4VJJMpILjM/NbTjS6z+NSYDUqx5u889A==", null, true, "", false, "cgl@crms.com", false },
                    { new Guid("e4274999-2c7e-4cc0-8a65-2381570c01c6"), 0, "Makati", "791f1789-7c0d-4a3e-ae38-1a877ecef31d", new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "System", "Admin", true, null, "SU@CRMS.COM", "SYSADMIN", "AQAAAAEAACcQAAAAEGr2hZWmn+8mxAbr95+sUKDoB86KaJDY1Of0AuHb1Puelw8Cgq3CgFiw5BzqM9VZoA==", null, true, "", false, "SysAdmin", true }
========
                    { new Guid("24121e19-d6a8-4a31-868a-35810c07a6b9"), 0, "General Trias", "b28050f8-37c0-4766-af38-22f1f7c3bdbd", new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), "sbb@crms.com", true, "Steven", "Baris", true, null, "SBB@CRMS.COM", "SBB@CRMS.COM", "AQAAAAEAACcQAAAAELf+Af5kohSklNp8FFWVBtUhp9E6I38dbormytOCml4dzJJ55rv6eFXjN6cYd4O+vA==", null, true, "", false, "sbb@crms.com", false },
                    { new Guid("6647c921-35f0-4980-b014-e8e9b50c4066"), 0, "Pasay", "11637642-2144-4c8a-8e3b-347670703621", new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), "cgl@crms.com", true, "Charl", "Legista", true, null, "CGL@CRMS.COM", "CGL@CRMS.COM", "AQAAAAEAACcQAAAAEC+8pJIlltmWyIVFNwLshLYslABmM5y8/Wm5t2oRCCojLNA5SeJin2aZKzDp+mJpaQ==", null, true, "", false, "cgl@crms.com", false },
                    { new Guid("f9f3b8b2-26eb-4731-8680-323863682bde"), 0, "Makati", "e7b207a8-3c04-48f8-b31d-5f82c262128f", new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "System", "Admin", true, null, "SU@CRMS.COM", "SYSADMIN", "AQAAAAEAACcQAAAAENybnSXDKyQK0XlvbmAUhZuAy5KQWEbGd93myO/Avbc8vdqNY8cKY8qPJ1YRX2fbHQ==", null, true, "", false, "SysAdmin", true }
>>>>>>>> 7240e749e6afa22f4ee53fd1ae0d3ea67611fc48:CRMS/Migrations/20230423093856_init.cs
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
<<<<<<<< HEAD:CRMS/Migrations/20230423200040_initDBSchema042423.cs
                    { new Guid("18357e57-c373-4f9c-ae33-76832c00104c"), "Phone Call" },
                    { new Guid("214e8e5a-ac60-4e48-a67e-3dbbb40c5686"), "Email" },
                    { new Guid("32b8e209-59f0-4a25-8a21-8a679760f2ac"), "Instagram" },
                    { new Guid("6b27026b-6394-4a31-ac3e-3f0e74c77a2d"), "WhatsApp" },
                    { new Guid("99e90010-0595-410a-aa15-8cf020ccbd20"), "Line" },
                    { new Guid("a1514fe1-14b1-4dae-9611-5e89110135a2"), "Text Message" },
                    { new Guid("af9cf827-ff7f-497a-8353-3344ff0b1bb7"), "Others" },
                    { new Guid("bef323bd-63c3-4049-8d1b-c2ab220679a6"), "Facebook" }
========
                    { new Guid("05b25a74-47d9-43ee-8ce8-625c28697866"), "Email" },
                    { new Guid("080b32e8-5665-4abe-91f5-dfccf8afe2c7"), "Others" },
                    { new Guid("72de5d06-2ab1-4988-9271-f93ba7e393a4"), "Test Message" },
                    { new Guid("a095109a-ddb5-40fb-bd4b-5f829822f8cd"), "Line" },
                    { new Guid("a419f484-6089-4da2-9b2d-d4c630e88a98"), "Instagram" },
                    { new Guid("c1b22338-028f-41cf-b88b-b244def4c861"), "WhatsApp" },
                    { new Guid("eeb2b9b7-9c54-4442-ba5c-c97741fe5aa3"), "Facebook" },
                    { new Guid("f566f556-a05c-4dcd-905d-991a7150d16e"), "Phone Call" }
>>>>>>>> 7240e749e6afa22f4ee53fd1ae0d3ea67611fc48:CRMS/Migrations/20230423093856_init.cs
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
<<<<<<<< HEAD:CRMS/Migrations/20230423200040_initDBSchema042423.cs
                    { new Guid("9ec40974-f249-40ff-abe2-43bbe0746c25"), "Read but no response" },
                    { new Guid("aa0e640d-c539-4d85-8aa7-798807dbbea7"), "Simple Response" },
                    { new Guid("e23d60bb-7a4e-4d65-b187-f507e90dfab8"), "Not Read" },
                    { new Guid("f468e49a-c029-4fca-a45f-f5bb71f78757"), "Good Engagement" }
========
                    { new Guid("4798ec67-155d-4782-9777-d13584441693"), "Simple Response" },
                    { new Guid("c47a6bbe-cacf-4994-9510-7256a39a00cd"), "Not Read" },
                    { new Guid("d3e83cb9-1dd3-4272-82a9-f4b815238b55"), "Good Engagement" },
                    { new Guid("dbc18a5c-684d-4725-adaf-c443489c9072"), "Read but no response" }
>>>>>>>> 7240e749e6afa22f4ee53fd1ae0d3ea67611fc48:CRMS/Migrations/20230423093856_init.cs
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
<<<<<<<< HEAD:CRMS/Migrations/20230423200040_initDBSchema042423.cs
                    { new Guid("1a43ad67-336e-4511-8411-0a133c84e0ce"), "Others" },
                    { new Guid("432fd84e-576a-49ec-936f-1f3dcd358a0c"), "Birthday" },
                    { new Guid("749126c4-2d23-4c22-99cd-d903d670c9cb"), "Holiday" },
                    { new Guid("772282ba-5e65-4f65-97bd-b2745bd0d6c2"), "Company News" },
                    { new Guid("784c6bec-1b25-4d57-9a35-a2c8c2c5cc95"), "Congratulations" },
                    { new Guid("7c144eb1-e968-4a70-ae61-e6a40e892631"), "Anniversary" },
                    { new Guid("cefdbe49-bc17-4afb-87d5-3340c5f5b700"), "New Product" },
                    { new Guid("e8782cc4-9a0b-4313-acd4-d70a6314ed31"), "Discount" }
========
                    { new Guid("0ed0bb6d-0696-4ba9-bad3-657d75807fa2"), "Anniversary" },
                    { new Guid("12acb338-beb6-4b96-b501-e8d3be46b26b"), "Discount" },
                    { new Guid("2faebbed-05e4-4d93-b9d2-248e287200b8"), "Company News" },
                    { new Guid("6d4961de-8a4f-4670-ae7f-889ebcfcbc91"), "Others" },
                    { new Guid("7c544101-6b83-4c11-93e6-7098440ef5b2"), "Birthday" },
                    { new Guid("882974f5-85b8-4337-9ea8-47afa0fe9301"), "Holiday" },
                    { new Guid("90416b52-37af-4154-8e42-05f75a057e90"), "New Product" },
                    { new Guid("c5a5a5ca-c0cf-49df-84d8-702cd0b81a75"), "Congratulations" }
>>>>>>>> 7240e749e6afa22f4ee53fd1ae0d3ea67611fc48:CRMS/Migrations/20230423093856_init.cs
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
<<<<<<<< HEAD:CRMS/Migrations/20230423200040_initDBSchema042423.cs
                    { new Guid("0b53fbe1-c7a3-4feb-8f81-960142e7a58c"), "Webinar" },
                    { new Guid("23c5aafb-3cf8-491a-91f8-fec7f2699024"), "Others" },
                    { new Guid("77f583a7-8e34-4d23-a1ae-f73b5f31b2ab"), "Referral" },
                    { new Guid("993f9d84-caf7-4730-add5-5f836cdb47e6"), "Company-Generated" },
                    { new Guid("b915d906-52b0-4afc-a880-09e1e1f86e5e"), "Friend" },
                    { new Guid("cfa5213c-78cb-4c9b-8d89-65448883a200"), "Social Media" }
========
                    { new Guid("1adac791-ae26-4254-87f2-413110bf70a9"), "Company-Generated" },
                    { new Guid("66a44d1f-eb08-4fba-98c2-c9e3e299a3f6"), "Referral" },
                    { new Guid("766dad50-8192-4164-8e96-41a0fa3d96b6"), "Social Media" },
                    { new Guid("b6263368-8d5c-4072-b378-eb5e71770dc3"), "Others" },
                    { new Guid("e21688b1-8b7b-4a00-a479-c7c74779684f"), "Webinar" },
                    { new Guid("ef54390c-3cef-4863-a776-82d7427dc5e2"), "Friend" }
>>>>>>>> 7240e749e6afa22f4ee53fd1ae0d3ea67611fc48:CRMS/Migrations/20230423093856_init.cs
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
<<<<<<<< HEAD:CRMS/Migrations/20230423200040_initDBSchema042423.cs
                    { new Guid("1271a7ed-bd75-4376-b472-221a614c4d40"), "Proposal Generated" },
                    { new Guid("592b29b1-2afa-4004-98d0-ee4847d91825"), "Lead is Dead" },
                    { new Guid("65ea5bc2-716a-4f85-80cf-f29cde0de0aa"), "Application Submitted" },
                    { new Guid("6d0ec1f7-2cc2-4a01-af87-916495693238"), "Met" },
                    { new Guid("7a45fef7-675c-4946-834d-0d32bbabaf49"), "Contacted" },
                    { new Guid("b2458401-af60-4e14-8bfc-0f0f3db52799"), "Policy Issued" }
========
                    { new Guid("0533adba-60cc-4735-a300-769385d852e3"), "Lead is Dead" },
                    { new Guid("0bdd51f6-8454-4275-bc8a-965b8ba35b70"), "Contacted" },
                    { new Guid("8ea3cf44-ac1c-49e9-86c9-3cde7b8a0a78"), "Proposal Generated" },
                    { new Guid("8edeba47-db89-4d88-9ad1-327fb80fd9bb"), "Application Submitted" },
                    { new Guid("90f50456-afc4-4063-8a21-01f21b73e769"), "Policy Issued" },
                    { new Guid("ea053f5d-7a33-431e-8b04-8b46fcb0e9cb"), "Met" }
>>>>>>>> 7240e749e6afa22f4ee53fd1ae0d3ea67611fc48:CRMS/Migrations/20230423093856_init.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:CRMS/Migrations/20230423200040_initDBSchema042423.cs
                values: new object[] { new Guid("eab657c4-6689-4028-bbb4-a6896c08c0b0"), new Guid("e4274999-2c7e-4cc0-8a65-2381570c01c6") });
========
                values: new object[] { new Guid("fc397f0f-4f1c-4908-a164-6828401b83dd"), new Guid("f9f3b8b2-26eb-4731-8680-323863682bde") });
>>>>>>>> 7240e749e6afa22f4ee53fd1ae0d3ea67611fc48:CRMS/Migrations/20230423093856_init.cs

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
