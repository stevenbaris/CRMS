using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class initDbSchemawContacts : Migration
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
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Gender = table.Column<int>(type: "int", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactOwnerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateAssigned = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactCreatorID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    { new Guid("280e236d-aecc-4535-8f12-e32c9f5b8aca"), "Proposal" },
                    { new Guid("91185bb8-e1dc-4086-84c0-1bd262d49952"), "Sales Closing" },
                    { new Guid("a73e3e80-1ca1-4184-b42c-117e2683edca"), "Presentation" },
                    { new Guid("b334d4f6-461b-499b-84de-2b24aaebb2cf"), "Fact-Find" },
                    { new Guid("d0b463fd-9886-4c79-83a6-5068bdd27f49"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8792a412-a1d5-4b4a-919c-7327f14780e1"), "9b112166-f6df-48e7-abe6-babe36c6a7bd", "User", null },
                    { new Guid("fa61d82e-a3fc-4271-a880-06ca42ed294e"), "4ae98d4d-764f-4cab-8d09-079b45dfc94c", "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("775b50f9-b147-4b01-a82c-c897506603c7"), 0, "PJ Lhuiller", "07390163-46bd-4933-82c8-ed10f23ff23f", new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, null, null, "AQAAAAEAACcQAAAAEDDKlDt0Lv8dYz9P4aX2S/7RW5tyktxVFMVTd38sVwBD9/xyScvYKNocXJ1AVAkosg==", null, true, "", false, "su@crms.com" },
                    { new Guid("a65582f0-df4b-4204-8b07-704e66360daf"), 0, "PJ Lhuiller", "87c0312e-d36b-4722-afa6-38756a8aeca2", new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, null, null, "AQAAAAEAACcQAAAAEC8ilH7gsb+SuuHli9X+m8nKpVIviKqvZB3wMPHOoiLlymb+WDLyL0NgoEgoBIS+BA==", null, true, "", false, "user@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("1bd4b881-b780-467f-8f67-935ed8e8a6d9"), "Facebook" },
                    { new Guid("3be13dc5-2519-4b3c-81e1-1f996749fdbc"), "Email" },
                    { new Guid("3f59417e-0699-423b-a4fc-2ed96d4fb379"), "Phone Call" },
                    { new Guid("5782af8a-a74c-43ce-99fb-bdb8c4c0c209"), "WhatsApp" },
                    { new Guid("5abde515-a1d5-49e0-b8ab-17d5baed2a93"), "Test Message" },
                    { new Guid("74f40398-8459-4f42-900b-2f77fea12e9d"), "Others" },
                    { new Guid("9436869e-79c5-4f8d-9685-ea1010815e88"), "Line" },
                    { new Guid("e1f23061-ee21-42ab-bc10-ea3d154e9f55"), "Instagram" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("59ab2491-a778-4777-a035-3419c4bc52eb"), "Read but no response" },
                    { new Guid("5df580a9-fe4e-4165-9614-a787c6b8db84"), "Simple Response" },
                    { new Guid("db61e122-d0d7-405a-a2c6-06b6af18a14b"), "Not Read" },
                    { new Guid("f9ff0128-6839-4c4e-814f-d9246e52f2c7"), "Good Engagement" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("3dfb98b4-810c-43e8-9e0c-6ab301472378"), "Discount" },
                    { new Guid("546a1ba0-bb7c-44f2-aec8-bb2831959ad5"), "Birthday" },
                    { new Guid("7b8d16e5-f16b-4ace-9ce5-c71d26bf7a1d"), "New Product" },
                    { new Guid("7e861260-be53-4acf-affb-24339d4ba04d"), "Holiday" },
                    { new Guid("bf24de0b-968f-4ffd-99fa-808b2f199b20"), "Congratulations" },
                    { new Guid("f4cb8f9a-40b0-444d-bad2-23939b249091"), "Anniversary" },
                    { new Guid("f69b6225-422a-481b-86f4-08e2e36dcde3"), "Others" },
                    { new Guid("fab25155-bdd9-4935-a2ee-7d38e5a0642b"), "Company News" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("177bb019-dc15-4b89-8960-e3fe98bfc687"), "Social Media" },
                    { new Guid("308168e8-cd74-478c-a735-11746def6c83"), "Friend" },
                    { new Guid("404be604-0f5a-4320-ab98-0080513cbeea"), "Webinar" },
                    { new Guid("7c6417cc-6271-4ce3-a456-efaae122c138"), "Compony-Generated" },
                    { new Guid("a9698b4f-b1fd-4f98-a1c6-8b270bcfb17f"), "Others" },
                    { new Guid("ee87c2ed-7896-49cc-9b39-2c0e23b6b31c"), "Referral" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("5ca59b0e-2349-4b44-b5f9-23aae1e1bd84"), "Met" },
                    { new Guid("5d5ca464-24eb-4b57-886d-de5f0f50e054"), "Policy Issued" },
                    { new Guid("930d6e6f-740f-4190-a41c-3a95290d9403"), "Contacted" },
                    { new Guid("b3bad378-34a8-4cb1-8ab2-9ca6f3cacf9b"), "Lead is Dead" },
                    { new Guid("dff4d3f7-8902-4cb1-9e95-836f5db6da40"), "Application Submitted" },
                    { new Guid("ff34c516-dfb8-40b1-a381-58d80209563d"), "Proposal Generated" }
                });

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
                name: "IX_ROLLING TRANSACTIONS_ContactId",
                table: "ROLLING TRANSACTIONS",
                column: "ContactId",
                unique: true,
                filter: "[ContactId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APPOINTMENT_PURPOSES");

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
                name: "ENGAGEMENT_COMMUNICATION METHODS");

            migrationBuilder.DropTable(
                name: "ENGAGEMENT_EFFECTIVITY");

            migrationBuilder.DropTable(
                name: "ENGAGEMENT_ENGAGEMENT-TYPES");

            migrationBuilder.DropTable(
                name: "LEADS_SOURCES");

            migrationBuilder.DropTable(
                name: "LEADS_STATUSES");

            migrationBuilder.DropTable(
                name: "ROLLING TRANSACTIONS");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CONTACTS");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
