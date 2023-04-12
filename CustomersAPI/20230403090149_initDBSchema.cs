using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomersAPI.Migrations
{
    public partial class initDBSchema : Migration
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
                    Customer_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMERS LIST", x => x.Customer_Id);
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
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSACTIONS LIST", x => x.Transaction_Id);
                    table.ForeignKey(
                        name: "FK_Customer_ID",
                        column: x => x.CustomerId,
                        principalTable: "CUSTOMERS LIST",
                        principalColumn: "Customer_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CUSTOMERS LIST",
                columns: new[] { "Customer_Id", "Address", "DOB", "Email", "FirstName", "Gender", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("0ab31e3a-858c-4f9f-9d62-dccb5cea16e2"), "59830 Brickson Park Road", new DateTime(2001, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "khadlington9@paypal.com", "Kerianne", "Female", "Hadlington", "09225056729" },
                    { new Guid("19ddd5d4-12fd-4357-a49d-05651d48b550"), "64071 Acker Park", new DateTime(1997, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "cakramb@wsj.com", "Catlin", "Female", "Akram", "09093870858" },
                    { new Guid("429408a7-890c-4f07-bfa8-c76da7def723"), "58172 Ruskin Crossing", new DateTime(1965, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "tcantoc@msu.edu", "Trenton", "Male", "Canto", "09809339189" },
                    { new Guid("460a787b-4f0f-44c6-840b-51d30c4e0566"), "62956 1st Street", new DateTime(1972, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "rmorgang@bbc.co.uk", "Rudy", "Male", "Morgan", "09597429865" },
                    { new Guid("4fd960ab-2aa6-49d7-a526-2d0f4da21320"), "82368 Boyd Point", new DateTime(2002, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahave8@so-net.ne.jp", "Alister", "Male", "Have", "09638397843" },
                    { new Guid("535ec1ed-3fdf-4691-9681-4d2c5d6738d2"), "673 Autumn Leaf Court", new DateTime(2006, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "asummerskill5@gravatar.com", "Angela", "Female", "Summerskill", "09337435073" },
                    { new Guid("58545c34-7a1a-4ac8-8198-3cc391ef3ed0"), "17 Columbus Junction", new DateTime(1955, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "gbilson7@prnewswire.com", "Georgianna", "Female", "Bilson", "09397882449" },
                    { new Guid("5c789246-a36e-46fb-bbe0-59eeb68c19a6"), "5234 Crossing Street", new DateTime(1975, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "mauris.sagittis@icloud.edu", "Madeline", "Female", "Baxter", "09123546789" },
                    { new Guid("69b66251-6956-4eed-8811-e8d1de41de29"), "57 Hagan Point", new DateTime(1992, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "rskedgeh@google.de", "Rhianna", "Female", "Skedge", "09956873369" },
                    { new Guid("8f67ca88-92a0-40ae-92e8-9d0642fad52b"), "9664 Redwing Court", new DateTime(1991, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "fstoweri@engadget.com", "Farlee", "Male", "Stower", "09579026072" },
                    { new Guid("8fe044ed-eabc-4354-b11e-4c962ccc63e5"), "9 Pleasure Way", new DateTime(1978, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "jbrowett6@mediafire.com", "Jed", "Male", "Browett", "09143498357" },
                    { new Guid("a809e63c-a6d8-4201-a18a-7da209801bd9"), "4608 Raven Parkway", new DateTime(1987, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "amacrow2@globo.com", "Alane", "Female", "Macrow", "09276939145" },
                    { new Guid("ab8633c3-3056-4dff-88a9-4066c0bd2114"), "4526 Northfield Road", new DateTime(1953, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmerryfielde@nih.gov", "Morganica", "Female", "Merryfield", "09003901945" },
                    { new Guid("b7faef3d-2d5b-4e2a-8376-502b361c64d3"), "03722 Westridge Court", new DateTime(1997, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "cthomkinsf@etsy.com", "Con", "Female", "Thomkins", "09939955254" },
                    { new Guid("c073d015-78ac-4436-a555-fc74eeba640c"), "1 Pond Center", new DateTime(1996, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmularkeyd@typepad.com", "Montague", "Male", "Mularkey", "09306995169" },
                    { new Guid("c9fde16b-bebe-4160-a866-da2a1b2ca61f"), "52014 Leroy Hill", new DateTime(1954, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "hsimunek4@yellowpages.com", "Hinze", "Male", "Simunek", "09267006937" },
                    { new Guid("cad23225-85c0-4f54-a4df-440df5c3d10c"), "624 Buhler Point", new DateTime(1994, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "mcrummaya@tripod.com", "Meggy", "Female", "Crummay", "09392511444" },
                    { new Guid("ccb70d01-3249-4d5b-be97-560bbed7620f"), "2067 Golden Leaf Circle", new DateTime(1964, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedington3@illinois.edu", "Tracy", "Male", "Edington", "09265235080" },
                    { new Guid("cddd06e2-5def-47fa-ac26-606416b83717"), "1 Dawn Circle", new DateTime(1994, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ddimnagej@etsy.com", "Delano", "Male", "Dimnage", "09662401440" },
                    { new Guid("efbf6381-b76b-49e8-9d3d-aa2ac7de0c71"), "97649 Corry Terrace", new DateTime(1956, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "mhabercham1@squidoo.com", "Maia", "Female", "Habercham", "09184621695" },
                    { new Guid("f65a5031-50a8-4893-9972-d05c7d88a2ae"), "3 Pepper Wood Center", new DateTime(1984, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "aabrahamovitz0@marketwatch.com", "Agatha", "Female", "Abrahamovitz", "09601729545" }
                });

            migrationBuilder.InsertData(
                table: "TRANSACTIONS LIST",
                columns: new[] { "Transaction_Id", "Amount", "CustomerId", "TransactionDate" },
                values: new object[,]
                {
                    { new Guid("053eba4a-064f-4c98-ab7a-033efc39c64e"), 17362.33m, new Guid("a809e63c-a6d8-4201-a18a-7da209801bd9"), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("13779749-17d8-4c81-925d-aae22b43b1f6"), 19958.59m, new Guid("cddd06e2-5def-47fa-ac26-606416b83717"), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1aa2305b-821a-4bbf-a4ae-33f431f5d688"), 19646.52m, new Guid("b7faef3d-2d5b-4e2a-8376-502b361c64d3"), new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2ad1ec8a-6b9e-4fc8-96f9-efbae0f65dfa"), 14420.64m, new Guid("8fe044ed-eabc-4354-b11e-4c962ccc63e5"), new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2b775dc1-46c4-45e0-9458-b016e50e9ecc"), 1183.59m, new Guid("19ddd5d4-12fd-4357-a49d-05651d48b550"), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2f422d76-474d-46e4-a1c9-27c5eaadc58c"), 7914.91m, new Guid("8f67ca88-92a0-40ae-92e8-9d0642fad52b"), new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("39a71a4a-f8bf-4dee-98a3-20f53b519b25"), 2116.34m, new Guid("ab8633c3-3056-4dff-88a9-4066c0bd2114"), new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a1d2074-7cc8-4295-812b-8f32bfc2fd04"), 12163.93m, new Guid("ccb70d01-3249-4d5b-be97-560bbed7620f"), new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3e66e1a0-8182-49df-aa5c-ec0cbd32f60f"), 15743.60m, new Guid("c9fde16b-bebe-4160-a866-da2a1b2ca61f"), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("47f20f44-5027-4885-b127-2f05c06a1313"), 5587.62m, new Guid("69b66251-6956-4eed-8811-e8d1de41de29"), new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b127757-2bbd-4a7c-a8d0-5ac50763b4fd"), 14523.92m, new Guid("efbf6381-b76b-49e8-9d3d-aa2ac7de0c71"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f59bb35-e5d0-4228-b5c8-f915e7c2e169"), 15326.44m, new Guid("8fe044ed-eabc-4354-b11e-4c962ccc63e5"), new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("60198401-9a0b-4ab4-80da-eaac6ad45e66"), 18900.31m, new Guid("b7faef3d-2d5b-4e2a-8376-502b361c64d3"), new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66ce3b0b-732d-4c32-9be1-eed024b41e24"), 14447.04m, new Guid("4fd960ab-2aa6-49d7-a526-2d0f4da21320"), new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6708028c-d98f-45f6-a9c9-78142413e7ac"), 14562.70m, new Guid("cddd06e2-5def-47fa-ac26-606416b83717"), new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d95657c-3ec0-4771-85f8-1f3742755795"), 15225.41m, new Guid("4fd960ab-2aa6-49d7-a526-2d0f4da21320"), new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71fc4c48-1991-45c1-a1ca-71d29018335e"), 16861.07m, new Guid("cddd06e2-5def-47fa-ac26-606416b83717"), new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("736ec3b4-2fa7-4b60-8afd-5e1d8e3decd3"), 7895.30m, new Guid("c073d015-78ac-4436-a555-fc74eeba640c"), new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7672faa0-628d-478a-9583-614c30f8438c"), 14215.58m, new Guid("535ec1ed-3fdf-4691-9681-4d2c5d6738d2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78767eca-ca8e-4df5-8a6c-298e5954a012"), 8628.20m, new Guid("ab8633c3-3056-4dff-88a9-4066c0bd2114"), new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("794c832d-4384-4fd6-823d-59f2c9caab42"), 3399.04m, new Guid("429408a7-890c-4f07-bfa8-c76da7def723"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7a2fca26-491e-4b57-9aa4-c5118c2c1be3"), 3134.06m, new Guid("4fd960ab-2aa6-49d7-a526-2d0f4da21320"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7eb10987-d455-4b4f-b5ad-fe1526e2f63f"), 17181.86m, new Guid("cddd06e2-5def-47fa-ac26-606416b83717"), new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("89a2712b-23a2-478c-89c1-9bd9fb013f52"), 12621.27m, new Guid("cad23225-85c0-4f54-a4df-440df5c3d10c"), new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8dfec47d-105d-4885-a924-02e868d25b37"), 9842.85m, new Guid("8f67ca88-92a0-40ae-92e8-9d0642fad52b"), new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("90429ab2-bedb-47b4-ab00-de533c3d9513"), 12838.18m, new Guid("c073d015-78ac-4436-a555-fc74eeba640c"), new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("971487b8-aadb-4663-9f0f-9e411ce72c6d"), 10839.38m, new Guid("58545c34-7a1a-4ac8-8198-3cc391ef3ed0"), new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9915dd35-4bfa-4f40-9ac1-ff2c074a9fcc"), 19644.39m, new Guid("460a787b-4f0f-44c6-840b-51d30c4e0566"), new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99970be2-cd67-4ef7-9f8a-d31b24a5cfb6"), 4079.20m, new Guid("429408a7-890c-4f07-bfa8-c76da7def723"), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99d73a89-654f-47d2-ba74-481c6ad40a44"), 13524.20m, new Guid("cddd06e2-5def-47fa-ac26-606416b83717"), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a7c37cb5-f8ed-4d03-8173-905d0db3b322"), 5204.34m, new Guid("ab8633c3-3056-4dff-88a9-4066c0bd2114"), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a9aaebad-94f3-49be-bf1f-5cadd7c2e140"), 18095.37m, new Guid("19ddd5d4-12fd-4357-a49d-05651d48b550"), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b0e5e17f-4caf-40f2-b598-ec550002b667"), 14115.62m, new Guid("460a787b-4f0f-44c6-840b-51d30c4e0566"), new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b23855af-40a5-46c0-b678-ed1a04271c3f"), 1347.45m, new Guid("8f67ca88-92a0-40ae-92e8-9d0642fad52b"), new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd2853cf-3ae4-46e0-b6cf-1f77a45485c1"), 13405.27m, new Guid("ccb70d01-3249-4d5b-be97-560bbed7620f"), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2f6c4a0-d975-48cb-87b7-45b8c365a66e"), 13910.67m, new Guid("58545c34-7a1a-4ac8-8198-3cc391ef3ed0"), new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3381e92-d999-4572-a572-616fc2769014"), 11703.50m, new Guid("c9fde16b-bebe-4160-a866-da2a1b2ca61f"), new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c46aea69-8326-405d-be63-bdbf2c5c5703"), 3896.77m, new Guid("a809e63c-a6d8-4201-a18a-7da209801bd9"), new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb3d2ae9-10bc-4348-a840-0ffac47ab7f5"), 8205.19m, new Guid("8fe044ed-eabc-4354-b11e-4c962ccc63e5"), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d356e4a8-ed99-4e57-8c0c-a877f4efef51"), 15192.52m, new Guid("429408a7-890c-4f07-bfa8-c76da7def723"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d975ce29-a6f7-4318-b937-3727a04a5b70"), 12432.71m, new Guid("19ddd5d4-12fd-4357-a49d-05651d48b550"), new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dd5a2ce8-3ef5-44db-b292-62135b663c99"), 9929.75m, new Guid("460a787b-4f0f-44c6-840b-51d30c4e0566"), new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TRANSACTIONS LIST",
                columns: new[] { "Transaction_Id", "Amount", "CustomerId", "TransactionDate" },
                values: new object[,]
                {
                    { new Guid("e2897d64-a559-4917-b2a1-9cd04717e9f6"), 7388.27m, new Guid("c073d015-78ac-4436-a555-fc74eeba640c"), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e484145a-1e79-4e57-9b7d-e421855ab075"), 12396.27m, new Guid("a809e63c-a6d8-4201-a18a-7da209801bd9"), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e91cf5b6-016d-4f27-ab85-cde749f2e79b"), 6068.91m, new Guid("ab8633c3-3056-4dff-88a9-4066c0bd2114"), new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e998fba6-3572-443f-a1d8-100355be9b77"), 17809.47m, new Guid("69b66251-6956-4eed-8811-e8d1de41de29"), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea192ce4-ca54-4f15-afd2-9f038701dbc5"), 19017.30m, new Guid("f65a5031-50a8-4893-9972-d05c7d88a2ae"), new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f044e6e8-d6e7-46d6-8e22-5f5423a8205e"), 8243.38m, new Guid("efbf6381-b76b-49e8-9d3d-aa2ac7de0c71"), new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2ec6b80-f589-4c62-9462-e0938e77635d"), 3940.43m, new Guid("69b66251-6956-4eed-8811-e8d1de41de29"), new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f9e411f6-b7fd-46ce-aea7-b5c6608bf7da"), 6523.52m, new Guid("ab8633c3-3056-4dff-88a9-4066c0bd2114"), new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                name: "IX_TRANSACTIONS LIST_CustomerId",
                table: "TRANSACTIONS LIST",
                column: "CustomerId");
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
