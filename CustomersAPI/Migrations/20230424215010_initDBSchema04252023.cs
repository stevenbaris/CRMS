using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomersAPI.Migrations
{
    public partial class initDBSchema04252023 : Migration
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
                    { new Guid("15d9be86-09b7-4d4d-bad5-a08b693482e6"), 0, "Makati", "fec96b15-3404-4992-a49c-234414187bfb", new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEJJqbOS2VfOiloTO3jNihmDP186M9zJr97Kybe0dCwO8NaPbUpcq/buxakQu5i/zBQ==", null, true, "", false, "user@crms.com" },
                    { new Guid("c0ce52a4-785e-48cc-b5a7-d3e926a54d46"), 0, "Makati", "03834ff5-6424-44bc-ab0c-fbd936c63708", new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAELW+tOSMV6sDFGU21wJdTaerwwCip2QTbsHuEgj9wAhdjFWV/5Q198m2ZHMf/9+x+g==", null, true, "", false, "su@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "CUSTOMERS LIST",
                columns: new[] { "Contact_Id", "Address", "CreateDate", "DOB", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("036ef421-725c-4cdc-8579-1d2a90a4679e"), "97649 Corry Terrace", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9312), new DateTime(1956, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "mhabercham1@squidoo.com", "Maia", "Female", "Habercham", "09184621695", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9313) },
                    { new Guid("0ed30cb6-5d14-4297-b68b-a8b6f144b216"), "57 Hagan Point", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9403), new DateTime(1992, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "rskedgeh@google.de", "Rhianna", "Female", "Skedge", "09956873369", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9403) },
                    { new Guid("10d4c00b-1091-4015-ba1c-28f30caaf4c7"), "82368 Boyd Point", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9361), new DateTime(2002, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahave8@so-net.ne.jp", "Alister", "Male", "Have", "09638397843", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9364) },
                    { new Guid("308b5968-b25d-4ea0-87ad-ab90a6e1e1f8"), "59830 Brickson Park Road", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9368), new DateTime(2001, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "khadlington9@paypal.com", "Kerianne", "Female", "Hadlington", "09225056729", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9368) },
                    { new Guid("4acfcef6-57d5-47c9-90d4-d5b8b39d73a5"), "3 Pepper Wood Center", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9308), new DateTime(1984, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "aabrahamovitz0@marketwatch.com", "Agatha", "Female", "Abrahamovitz", "09601729545", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9309) },
                    { new Guid("72321d02-9e99-4ef4-98ae-2b17ecaef838"), "624 Buhler Point", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9374), new DateTime(1994, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "mcrummaya@tripod.com", "Meggy", "Female", "Crummay", "09392511444", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9375) },
                    { new Guid("7460a459-2012-4342-bc62-266bbc8b0a5f"), "62956 1st Street", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9399), new DateTime(1972, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "rmorgang@bbc.co.uk", "Rudy", "Male", "Morgan", "09597429865", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9400) },
                    { new Guid("7d1738cc-c0de-4bae-9333-688b5eca6446"), "2067 Golden Leaf Circle", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9335), new DateTime(1964, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedington3@illinois.edu", "Tracy", "Male", "Edington", "09265235080", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9336) },
                    { new Guid("8d2245f2-b801-44b5-b6ef-bcd372305748"), "1 Pond Center", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9385), new DateTime(1996, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmularkeyd@typepad.com", "Montague", "Male", "Mularkey", "09306995169", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9386) },
                    { new Guid("8eee1f9b-aff6-4f38-b69a-c568d81e59e5"), "673 Autumn Leaf Court", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9345), new DateTime(2006, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "asummerskill5@gravatar.com", "Angela", "Female", "Summerskill", "09337435073", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9346) },
                    { new Guid("a7230234-ec68-4c59-9d1a-3bb21bd989f7"), "03722 Westridge Court", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9394), new DateTime(1997, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "cthomkinsf@etsy.com", "Con", "Female", "Thomkins", "09939955254", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9395) },
                    { new Guid("b3102777-2cbc-4f02-9ffc-74f5f5fe8e21"), "58172 Ruskin Crossing", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9382), new DateTime(1965, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "tcantoc@msu.edu", "Trenton", "Male", "Canto", "09809339189", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9382) },
                    { new Guid("c504eaa3-7246-40a7-84ea-1ec2da6dc507"), "4526 Northfield Road", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9391), new DateTime(1953, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmerryfielde@nih.gov", "Morganica", "Female", "Merryfield", "09003901945", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9391) },
                    { new Guid("c50c2b5e-5b01-4782-9cd1-b4f177c9d82b"), "1 Dawn Circle", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9412), new DateTime(1994, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ddimnagej@etsy.com", "Delano", "Male", "Dimnage", "09662401440", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9412) },
                    { new Guid("c931d765-d4ee-4fe2-bd29-c7bfc47728a7"), "9 Pleasure Way", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9352), new DateTime(1978, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "jbrowett6@mediafire.com", "Jed", "Male", "Browett", "09143498357", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9353) },
                    { new Guid("d1befadf-96fe-4d80-8f2b-afe6255ab532"), "4608 Raven Parkway", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9331), new DateTime(1987, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "amacrow2@globo.com", "Alane", "Female", "Macrow", "09276939145", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9331) },
                    { new Guid("d46a0bdc-6014-4f32-899b-997987bc09bd"), "5234 Crossing Street", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9269), new DateTime(1975, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "mauris.sagittis@icloud.edu", "Madeline", "Female", "Baxter", "09123546789", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9288) },
                    { new Guid("dbfcb678-6643-4abc-91b3-d4d3c5491231"), "9664 Redwing Court", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9408), new DateTime(1991, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "fstoweri@engadget.com", "Farlee", "Male", "Stower", "09579026072", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9409) },
                    { new Guid("eb3c7f96-fdec-446b-8212-a9db7f60b4ae"), "17 Columbus Junction", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9356), new DateTime(1955, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "gbilson7@prnewswire.com", "Georgianna", "Female", "Bilson", "09397882449", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9357) },
                    { new Guid("f4338b1f-2bd2-478d-a215-773598ff73e0"), "64071 Acker Park", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9378), new DateTime(1997, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "cakramb@wsj.com", "Catlin", "Female", "Akram", "09093870858", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9379) },
                    { new Guid("f734132b-a94d-4e69-b4e0-9ab3fee53ed3"), "52014 Leroy Hill", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9341), new DateTime(1954, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "hsimunek4@yellowpages.com", "Hinze", "Male", "Simunek", "09267006937", new DateTime(2023, 2, 14, 5, 50, 10, 328, DateTimeKind.Local).AddTicks(9342) }
                });

            migrationBuilder.InsertData(
                table: "TRANSACTIONS LIST",
                columns: new[] { "Transaction_Id", "Amount", "ContactId", "TransactionDate" },
                values: new object[,]
                {
                    { new Guid("077b3c8b-daf3-4ce0-bf50-933353987307"), 19646.52m, new Guid("a7230234-ec68-4c59-9d1a-3bb21bd989f7"), new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c44cf20-5c1a-4eb7-acd3-8e8603429d34"), 11703.50m, new Guid("f734132b-a94d-4e69-b4e0-9ab3fee53ed3"), new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17c9b01f-fb35-481a-866e-867f9449fc1c"), 12838.18m, new Guid("8d2245f2-b801-44b5-b6ef-bcd372305748"), new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("18e3bc32-29a5-4fd1-9e38-d4ac864b0726"), 18900.31m, new Guid("a7230234-ec68-4c59-9d1a-3bb21bd989f7"), new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b36cdc2-85e7-4273-988f-c0419784667a"), 19644.39m, new Guid("7460a459-2012-4342-bc62-266bbc8b0a5f"), new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e93daab-2c2a-4fe9-8031-dcf9dfb81be9"), 14115.62m, new Guid("7460a459-2012-4342-bc62-266bbc8b0a5f"), new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("224ddf22-b458-4639-a508-d9e842650ff3"), 12432.71m, new Guid("f4338b1f-2bd2-478d-a215-773598ff73e0"), new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("25890324-a0a0-4e94-99e5-55e40a1d9544"), 14420.64m, new Guid("c931d765-d4ee-4fe2-bd29-c7bfc47728a7"), new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2797dbe1-c4d2-444d-b206-f030f068bb57"), 6068.91m, new Guid("c504eaa3-7246-40a7-84ea-1ec2da6dc507"), new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c8c66f3-07c1-49c3-ad66-b5d65e6b6fb5"), 13910.67m, new Guid("eb3c7f96-fdec-446b-8212-a9db7f60b4ae"), new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("39e65aa9-ac2b-4ac6-aa06-8c546bec50f2"), 3134.06m, new Guid("10d4c00b-1091-4015-ba1c-28f30caaf4c7"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a4e06ea-e943-4c2b-af49-2b62c33a583b"), 7895.30m, new Guid("8d2245f2-b801-44b5-b6ef-bcd372305748"), new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c19460c-6541-45ca-ba88-048bd78f1241"), 12621.27m, new Guid("72321d02-9e99-4ef4-98ae-2b17ecaef838"), new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3fc2e285-1f13-49ef-99d1-d08aecfe2d43"), 1347.45m, new Guid("dbfcb678-6643-4abc-91b3-d4d3c5491231"), new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("43c8e514-0345-45dd-b538-16db0f3f2f44"), 3896.77m, new Guid("d1befadf-96fe-4d80-8f2b-afe6255ab532"), new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("44814af1-07cc-4623-9163-76354c978dd2"), 5587.62m, new Guid("0ed30cb6-5d14-4297-b68b-a8b6f144b216"), new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("450d736d-aa51-4960-99bc-65b19348727a"), 7388.27m, new Guid("8d2245f2-b801-44b5-b6ef-bcd372305748"), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5bace217-ccae-4b6d-8194-4857271100fb"), 9929.75m, new Guid("7460a459-2012-4342-bc62-266bbc8b0a5f"), new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5cf6ce99-f11d-446e-bdfb-1725e61196b8"), 17809.47m, new Guid("0ed30cb6-5d14-4297-b68b-a8b6f144b216"), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5e6ff833-afcf-40e2-b7ff-cfb28d541553"), 12163.93m, new Guid("7d1738cc-c0de-4bae-9333-688b5eca6446"), new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6065bab1-becb-4e5f-97c2-4b2cade579ce"), 4079.20m, new Guid("b3102777-2cbc-4f02-9ffc-74f5f5fe8e21"), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6445f2e0-7f2c-48a9-a0f2-31c78a41b443"), 19958.59m, new Guid("c50c2b5e-5b01-4782-9cd1-b4f177c9d82b"), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6b612711-713a-4019-82d7-290018091d5a"), 14215.58m, new Guid("8eee1f9b-aff6-4f38-b69a-c568d81e59e5"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6baec760-2422-4e8d-93a7-dca1352e6fd0"), 1183.59m, new Guid("f4338b1f-2bd2-478d-a215-773598ff73e0"), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("74faa00b-93ab-4254-ae18-3fd9216054b6"), 2116.34m, new Guid("c504eaa3-7246-40a7-84ea-1ec2da6dc507"), new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7cc77eeb-8680-4bb0-be82-dcf79f7674e1"), 15326.44m, new Guid("c931d765-d4ee-4fe2-bd29-c7bfc47728a7"), new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8577528b-2522-484d-a641-e42acbeb602e"), 5204.34m, new Guid("c504eaa3-7246-40a7-84ea-1ec2da6dc507"), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("871daea2-c7d6-4134-b866-f434b74549a9"), 16861.07m, new Guid("c50c2b5e-5b01-4782-9cd1-b4f177c9d82b"), new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("981487be-043e-4511-a0a7-85c34bcb741c"), 3940.43m, new Guid("0ed30cb6-5d14-4297-b68b-a8b6f144b216"), new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("991d285d-8c50-4073-85f1-51c4392b4c4e"), 19017.30m, new Guid("4acfcef6-57d5-47c9-90d4-d5b8b39d73a5"), new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9fc766c3-2ea1-4966-ac8c-8e19c738e16e"), 7914.91m, new Guid("dbfcb678-6643-4abc-91b3-d4d3c5491231"), new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a5f1d942-c6bc-4c93-9585-e4ea9ea389f7"), 9842.85m, new Guid("dbfcb678-6643-4abc-91b3-d4d3c5491231"), new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a64a8f76-9a26-4c62-8e31-9a0a90c40781"), 6523.52m, new Guid("c504eaa3-7246-40a7-84ea-1ec2da6dc507"), new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a8c9c451-587a-41bf-b1e8-9425834348d8"), 10839.38m, new Guid("eb3c7f96-fdec-446b-8212-a9db7f60b4ae"), new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("af0e7411-6be6-498d-9346-3ff6ed48c110"), 15225.41m, new Guid("10d4c00b-1091-4015-ba1c-28f30caaf4c7"), new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("af8984c0-4979-48a2-aa63-0e28e803d536"), 17181.86m, new Guid("c50c2b5e-5b01-4782-9cd1-b4f177c9d82b"), new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b179c4b6-6ecd-4073-9828-8c193daac282"), 15743.60m, new Guid("f734132b-a94d-4e69-b4e0-9ab3fee53ed3"), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b9df075e-eada-4f60-97e2-2c12ac678634"), 13405.27m, new Guid("7d1738cc-c0de-4bae-9333-688b5eca6446"), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc0b5dec-e80d-4d36-98f6-8254a01ea9b7"), 3399.04m, new Guid("b3102777-2cbc-4f02-9ffc-74f5f5fe8e21"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc36c05f-15cf-4519-ac7f-7f2a7892f9f1"), 8628.20m, new Guid("c504eaa3-7246-40a7-84ea-1ec2da6dc507"), new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c16491f7-1f3c-4ead-9f82-79681c1bcc68"), 17362.33m, new Guid("d1befadf-96fe-4d80-8f2b-afe6255ab532"), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3169b28-f32f-40b9-ae4e-d1c28a04b5a8"), 14447.04m, new Guid("10d4c00b-1091-4015-ba1c-28f30caaf4c7"), new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TRANSACTIONS LIST",
                columns: new[] { "Transaction_Id", "Amount", "ContactId", "TransactionDate" },
                values: new object[,]
                {
                    { new Guid("c5f35094-acbc-45ce-a81d-85f428c9b523"), 8205.19m, new Guid("c931d765-d4ee-4fe2-bd29-c7bfc47728a7"), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c821a2c6-2a3b-4c34-a935-305cab777d4e"), 14523.92m, new Guid("036ef421-725c-4cdc-8579-1d2a90a4679e"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cbdd5c36-2745-405d-9dee-aa8d7781ec06"), 14562.70m, new Guid("c50c2b5e-5b01-4782-9cd1-b4f177c9d82b"), new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e0ee805f-363c-4935-b2aa-b98075e8fb6b"), 18095.37m, new Guid("f4338b1f-2bd2-478d-a215-773598ff73e0"), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e12add0a-4dbd-4cae-b82c-3923d335fb90"), 12396.27m, new Guid("d1befadf-96fe-4d80-8f2b-afe6255ab532"), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2b13169-c0b2-4bf3-a3d0-360af2ddbb4f"), 13524.20m, new Guid("c50c2b5e-5b01-4782-9cd1-b4f177c9d82b"), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f3a71adf-8999-4d7d-8f86-fa5bb37e2726"), 8243.38m, new Guid("036ef421-725c-4cdc-8579-1d2a90a4679e"), new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffa15f2e-36bc-40f0-95ce-8945dd7a8d5d"), 15192.52m, new Guid("b3102777-2cbc-4f02-9ffc-74f5f5fe8e21"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
