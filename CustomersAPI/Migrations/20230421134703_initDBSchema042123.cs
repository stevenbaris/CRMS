using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomersAPI.Migrations
{
    public partial class initDBSchema042123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "CUSTOMERS LIST",
                columns: table => new
                {
                    Contact_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMERS LIST", x => x.Contact_Id);
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
                name: "TRANSACTIONS LIST",
                columns: table => new
                {
                    Transaction_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSACTIONS LIST", x => x.Transaction_Id);
                    table.ForeignKey(
                        name: "FK_Contact_Id",
                        column: x => x.ContactId,
                        principalTable: "CUSTOMERS LIST",
                        principalColumn: "Contact_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityAddress", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3dc3020c-c99c-42c9-a8c0-a81e894bc3db"), 0, "Makati", "60b53a94-a63e-4942-8e9c-6790fb8e6475", new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEH3R/+1oRRllmx+U6z47Mm8A11HGL6YyT/Mv0ad7Qqq4QeUUUIEcx/Re4OJ7GzXeqA==", null, true, "", false, "user@crms.com" },
                    { new Guid("97b6365c-90a9-4638-97ad-0e008529723f"), 0, "Makati", "8ba7f7c5-0605-4234-a361-8988a6a1b30c", new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEPWLW6KoL2nbEkl0FEk3UYHBOs6NbqMW/ByViTvgP5NipqOFoc9rK2cC6jydsd4QMA==", null, true, "", false, "su@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "CUSTOMERS LIST",
                columns: new[] { "Contact_Id", "Address", "CreateDate", "DOB", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1513f84b-559f-4fa6-89ee-6b2d43455308"), "3 Pepper Wood Center", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5837), new DateTime(1984, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "aabrahamovitz0@marketwatch.com", "Agatha", "Female", "Abrahamovitz", "09601729545", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5838) },
                    { new Guid("2e770030-22f5-41b1-a653-555037c60881"), "2067 Golden Leaf Circle", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5874), new DateTime(1964, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedington3@illinois.edu", "Tracy", "Male", "Edington", "09265235080", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5875) },
                    { new Guid("314742d5-3cd9-402d-830f-8a2d15703c00"), "58172 Ruskin Crossing", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5930), new DateTime(1965, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "tcantoc@msu.edu", "Trenton", "Male", "Canto", "09809339189", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5931) },
                    { new Guid("36edaf18-569c-4e23-9192-07995ded4017"), "5234 Crossing Street", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5807), new DateTime(1975, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "mauris.sagittis@icloud.edu", "Madeline", "Female", "Baxter", "09123546789", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5823) },
                    { new Guid("3eb930ca-d8ef-4286-b495-8d860bc47430"), "97649 Corry Terrace", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5843), new DateTime(1956, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "mhabercham1@squidoo.com", "Maia", "Female", "Habercham", "09184621695", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5843) },
                    { new Guid("4abd65f4-07e2-4c74-a74f-457cef2d31aa"), "17 Columbus Junction", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5906), new DateTime(1955, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "gbilson7@prnewswire.com", "Georgianna", "Female", "Bilson", "09397882449", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5907) },
                    { new Guid("508ea221-ad49-4951-ac2c-7ee1b18fe30e"), "82368 Boyd Point", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5912), new DateTime(2002, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahave8@so-net.ne.jp", "Alister", "Male", "Have", "09638397843", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5913) },
                    { new Guid("5340606b-2fa9-40d7-95da-b9fc35caa7e1"), "673 Autumn Leaf Court", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5889), new DateTime(2006, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "asummerskill5@gravatar.com", "Angela", "Female", "Summerskill", "09337435073", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5889) },
                    { new Guid("80750390-38cc-417d-9f0f-cc72959d140d"), "52014 Leroy Hill", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5882), new DateTime(1954, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "hsimunek4@yellowpages.com", "Hinze", "Male", "Simunek", "09267006937", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5883) },
                    { new Guid("83166a66-7a03-469e-944e-492f6e699dd6"), "62956 1st Street", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5950), new DateTime(1972, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "rmorgang@bbc.co.uk", "Rudy", "Male", "Morgan", "09597429865", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5950) },
                    { new Guid("856c4f50-bcd2-4a10-bdff-1d63129e4bec"), "03722 Westridge Court", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5945), new DateTime(1997, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "cthomkinsf@etsy.com", "Con", "Female", "Thomkins", "09939955254", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5945) },
                    { new Guid("9213c9e5-f804-43a7-9a20-6dcf6ffaaab7"), "624 Buhler Point", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5920), new DateTime(1994, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "mcrummaya@tripod.com", "Meggy", "Female", "Crummay", "09392511444", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5920) },
                    { new Guid("a73f5a92-40fe-4e01-8f0d-3e9cca678e4b"), "9 Pleasure Way", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5896), new DateTime(1978, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "jbrowett6@mediafire.com", "Jed", "Male", "Browett", "09143498357", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5897) },
                    { new Guid("b0249f04-c720-4e19-ae93-9a884fe4b706"), "4526 Northfield Road", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5938), new DateTime(1953, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmerryfielde@nih.gov", "Morganica", "Female", "Merryfield", "09003901945", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5938) },
                    { new Guid("b032acb2-f646-4337-8e22-ef2b959cdc16"), "1 Dawn Circle", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5966), new DateTime(1994, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ddimnagej@etsy.com", "Delano", "Male", "Dimnage", "09662401440", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5966) },
                    { new Guid("b151e60b-b0d5-471f-a31e-7bd8a7cf6a44"), "64071 Acker Park", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5925), new DateTime(1997, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "cakramb@wsj.com", "Catlin", "Female", "Akram", "09093870858", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5926) },
                    { new Guid("b26cbd53-e55b-488b-8e30-0a1f3753bd3d"), "9664 Redwing Court", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5960), new DateTime(1991, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "fstoweri@engadget.com", "Farlee", "Male", "Stower", "09579026072", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5961) },
                    { new Guid("b365c783-f208-4a8a-acb5-f9e9e46252ad"), "1 Pond Center", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5934), new DateTime(1996, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmularkeyd@typepad.com", "Montague", "Male", "Mularkey", "09306995169", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5935) },
                    { new Guid("c2980a8f-f75b-4ba6-8e4e-dd0f03656419"), "57 Hagan Point", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5956), new DateTime(1992, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "rskedgeh@google.de", "Rhianna", "Female", "Skedge", "09956873369", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5957) },
                    { new Guid("d25996a9-e7c8-450e-9b25-725a330e21ae"), "4608 Raven Parkway", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5848), new DateTime(1987, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "amacrow2@globo.com", "Alane", "Female", "Macrow", "09276939145", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5849) },
                    { new Guid("f530065a-1064-4b78-9788-6774d36bd403"), "59830 Brickson Park Road", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5916), new DateTime(2001, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "khadlington9@paypal.com", "Kerianne", "Female", "Hadlington", "09225056729", new DateTime(2023, 2, 10, 21, 47, 3, 683, DateTimeKind.Local).AddTicks(5917) }
                });

            migrationBuilder.InsertData(
                table: "TRANSACTIONS LIST",
                columns: new[] { "Transaction_Id", "Amount", "ContactId", "TransactionDate" },
                values: new object[,]
                {
                    { new Guid("03c5ab8c-8cb0-45df-b7d8-9c8746024d76"), 7914.91m, new Guid("b26cbd53-e55b-488b-8e30-0a1f3753bd3d"), new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("07103475-100d-4ee0-8638-2936f800c998"), 19958.59m, new Guid("b032acb2-f646-4337-8e22-ef2b959cdc16"), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("08893775-80dd-4194-96ba-00f69b445916"), 3896.77m, new Guid("d25996a9-e7c8-450e-9b25-725a330e21ae"), new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f04751b-b624-42e2-a3df-09bdde8e27bf"), 15192.52m, new Guid("314742d5-3cd9-402d-830f-8a2d15703c00"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1657b079-788e-4827-a22c-31c92729b858"), 17181.86m, new Guid("b032acb2-f646-4337-8e22-ef2b959cdc16"), new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("219cc8c9-d37b-4394-a3c5-14bdb3d33913"), 10839.38m, new Guid("4abd65f4-07e2-4c74-a74f-457cef2d31aa"), new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("30da6d37-2599-46c3-a3a5-205b1adccc01"), 11703.50m, new Guid("80750390-38cc-417d-9f0f-cc72959d140d"), new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3519ec8f-ea39-4513-99fc-86afed66a632"), 14523.92m, new Guid("3eb930ca-d8ef-4286-b495-8d860bc47430"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("36f8bb33-9000-4030-ae1f-c9bf93711da8"), 1183.59m, new Guid("b151e60b-b0d5-471f-a31e-7bd8a7cf6a44"), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3cad3a33-e915-46ea-87de-a8e3aa3d2592"), 19017.30m, new Guid("1513f84b-559f-4fa6-89ee-6b2d43455308"), new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3d381e65-b5ac-4e01-a8a9-9740feb71cdd"), 12432.71m, new Guid("b151e60b-b0d5-471f-a31e-7bd8a7cf6a44"), new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("433bab1f-8c46-4b59-b38e-4e759a9c489d"), 12621.27m, new Guid("9213c9e5-f804-43a7-9a20-6dcf6ffaaab7"), new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a5e3996-1741-440a-b55c-2f88fbfa1e19"), 5204.34m, new Guid("b0249f04-c720-4e19-ae93-9a884fe4b706"), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("533a5d8b-1dc4-4804-8ffa-5e2ab058903b"), 14420.64m, new Guid("a73f5a92-40fe-4e01-8f0d-3e9cca678e4b"), new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5ac356e0-7e3a-4faf-ac1f-c54f61a24abd"), 13910.67m, new Guid("4abd65f4-07e2-4c74-a74f-457cef2d31aa"), new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d98c569-90a7-4490-bcae-f65d4ab75e5b"), 15743.60m, new Guid("80750390-38cc-417d-9f0f-cc72959d140d"), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("65994779-d1a8-4744-b193-87b19b7c511c"), 9929.75m, new Guid("83166a66-7a03-469e-944e-492f6e699dd6"), new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e89513e-0a9c-4489-918a-04af5eaa1717"), 1347.45m, new Guid("b26cbd53-e55b-488b-8e30-0a1f3753bd3d"), new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("721727b8-c449-4ef1-93a1-bd48edfae26f"), 12163.93m, new Guid("2e770030-22f5-41b1-a653-555037c60881"), new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81f18396-d9cc-45b8-9ccc-0a14f9ac2eca"), 6068.91m, new Guid("b0249f04-c720-4e19-ae93-9a884fe4b706"), new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("86bf597a-c3eb-44a6-b1ee-8af9a1b5740f"), 7895.30m, new Guid("b365c783-f208-4a8a-acb5-f9e9e46252ad"), new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("94070fa4-3114-41e4-b86a-cf647af743e4"), 3399.04m, new Guid("314742d5-3cd9-402d-830f-8a2d15703c00"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("996666d1-741e-4ad3-b5cf-8267f9f834db"), 7388.27m, new Guid("b365c783-f208-4a8a-acb5-f9e9e46252ad"), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b463495-b069-48bf-ad7a-a59c8dc859e1"), 2116.34m, new Guid("b0249f04-c720-4e19-ae93-9a884fe4b706"), new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9ee2ea49-a4d3-447b-b201-584bdfb0a8d4"), 13405.27m, new Guid("2e770030-22f5-41b1-a653-555037c60881"), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9f80f6ce-442a-4c05-b957-010034885057"), 14447.04m, new Guid("508ea221-ad49-4951-ac2c-7ee1b18fe30e"), new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a21222ea-1abe-4054-9896-12dfbd29cce2"), 19644.39m, new Guid("83166a66-7a03-469e-944e-492f6e699dd6"), new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2f6f541-8fba-4f79-917b-d058b260dc69"), 14215.58m, new Guid("5340606b-2fa9-40d7-95da-b9fc35caa7e1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a521fc55-4085-44f8-9c3f-bbe0a01e8b7f"), 19646.52m, new Guid("856c4f50-bcd2-4a10-bdff-1d63129e4bec"), new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa273b45-7085-46eb-96d5-da6d51b6dc58"), 17809.47m, new Guid("c2980a8f-f75b-4ba6-8e4e-dd0f03656419"), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3c84b22-00e7-4c94-9e90-92ccebace364"), 18095.37m, new Guid("b151e60b-b0d5-471f-a31e-7bd8a7cf6a44"), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc52736c-e0d6-4688-ad3e-4a1b24788d5b"), 12396.27m, new Guid("d25996a9-e7c8-450e-9b25-725a330e21ae"), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf2c97be-dacc-4925-acfd-6256d3f4b797"), 14562.70m, new Guid("b032acb2-f646-4337-8e22-ef2b959cdc16"), new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c8fc818c-b191-4f0f-bb37-45b415488358"), 15326.44m, new Guid("a73f5a92-40fe-4e01-8f0d-3e9cca678e4b"), new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cacf2754-a1b3-4435-b511-5b8a2bcf5d10"), 8205.19m, new Guid("a73f5a92-40fe-4e01-8f0d-3e9cca678e4b"), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb42cc3c-34f2-450f-b957-1c728fd1e602"), 8628.20m, new Guid("b0249f04-c720-4e19-ae93-9a884fe4b706"), new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf7dd58c-7167-4f2d-864e-c8abe81dc8b8"), 14115.62m, new Guid("83166a66-7a03-469e-944e-492f6e699dd6"), new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cfc9323b-8628-4ae0-9d1b-0a8bcc991ecc"), 8243.38m, new Guid("3eb930ca-d8ef-4286-b495-8d860bc47430"), new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d109aa28-121e-40f3-afdf-7c543eab02ed"), 12838.18m, new Guid("b365c783-f208-4a8a-acb5-f9e9e46252ad"), new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d14fb42e-6fbf-426e-b4f2-7797d939a4cd"), 16861.07m, new Guid("b032acb2-f646-4337-8e22-ef2b959cdc16"), new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d6f297cb-dab4-471c-9804-4dd97bf53dd1"), 9842.85m, new Guid("b26cbd53-e55b-488b-8e30-0a1f3753bd3d"), new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d903c52f-5546-4677-b46d-64396d7b4648"), 3940.43m, new Guid("c2980a8f-f75b-4ba6-8e4e-dd0f03656419"), new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TRANSACTIONS LIST",
                columns: new[] { "Transaction_Id", "Amount", "ContactId", "TransactionDate" },
                values: new object[,]
                {
                    { new Guid("d9fa4214-fcfa-423f-a6c9-6292754de83d"), 5587.62m, new Guid("c2980a8f-f75b-4ba6-8e4e-dd0f03656419"), new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("daa88f30-7096-4978-adda-2edc1749799d"), 15225.41m, new Guid("508ea221-ad49-4951-ac2c-7ee1b18fe30e"), new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e12fc700-8392-4e87-96da-408548bb268b"), 13524.20m, new Guid("b032acb2-f646-4337-8e22-ef2b959cdc16"), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e9b5f69f-aba0-4c83-998d-291d5637a795"), 3134.06m, new Guid("508ea221-ad49-4951-ac2c-7ee1b18fe30e"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ebbe63a1-c091-49d3-8c37-20872d520d19"), 6523.52m, new Guid("b0249f04-c720-4e19-ae93-9a884fe4b706"), new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f10acb25-adba-4ca0-9bc5-f598a58fd6a1"), 4079.20m, new Guid("314742d5-3cd9-402d-830f-8a2d15703c00"), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f29423b1-1b50-4a25-bab7-bde468f01ab4"), 17362.33m, new Guid("d25996a9-e7c8-450e-9b25-725a330e21ae"), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fff4b629-35c0-4222-967f-fe2a1cff153b"), 18900.31m, new Guid("856c4f50-bcd2-4a10-bdff-1d63129e4bec"), new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                name: "IX_CUSTOMERS LIST_Email",
                table: "CUSTOMERS LIST",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TRANSACTIONS LIST_ContactId",
                table: "TRANSACTIONS LIST",
                column: "ContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "TRANSACTIONS LIST");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CUSTOMERS LIST");
        }
    }
}
