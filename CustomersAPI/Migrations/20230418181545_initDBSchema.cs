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
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { new Guid("ad57a14b-7ffd-4475-b8b9-9ac2e3a37eb3"), 0, "Makati", "177b9197-4429-4b77-b9d1-3292e451520d", new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEEwVWeE+1Ql63lSCv1/XoJ+l/1k6G0CTaTvbdBIL9cV/zFaXtOzevxNKTnq2esTHQA==", null, true, "", false, "user@crms.com" },
                    { new Guid("ecbbd58b-9984-419a-80de-e631bd732296"), 0, "Makati", "39cea1ef-e428-4b9d-9797-7493747db677", new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEIXYHfuZfSeav7MiY6DzOUADD3yQ7BNdw3RfhTOhDJxbKKz2BQ2IDrQmj/llIwcgqg==", null, true, "", false, "su@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "CUSTOMERS LIST",
                columns: new[] { "Contact_Id", "Address", "CreateDate", "DOB", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0439dcb1-5791-4868-bb56-b2638b357b4b"), "3 Pepper Wood Center", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7086), new DateTime(1984, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "aabrahamovitz0@marketwatch.com", "Agatha", "Female", "Abrahamovitz", "09601729545", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7087) },
                    { new Guid("0521fa46-6452-4b3d-bcf1-5b8555d25ea3"), "59830 Brickson Park Road", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7120), new DateTime(2001, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "khadlington9@paypal.com", "Kerianne", "Female", "Hadlington", "09225056729", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7120) },
                    { new Guid("082fed74-e715-4d16-97b3-91ecaf905653"), "673 Autumn Leaf Court", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7106), new DateTime(2006, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "asummerskill5@gravatar.com", "Angela", "Female", "Summerskill", "09337435073", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7107) },
                    { new Guid("0f237658-5350-4f5a-959f-8471326dfeba"), "2067 Golden Leaf Circle", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7098), new DateTime(1964, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedington3@illinois.edu", "Tracy", "Male", "Edington", "09265235080", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7099) },
                    { new Guid("13347c7f-1745-4751-8eb0-a175d4cc167f"), "624 Buhler Point", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7122), new DateTime(1994, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "mcrummaya@tripod.com", "Meggy", "Female", "Crummay", "09392511444", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7123) },
                    { new Guid("35261dda-8935-4a36-ba8d-4018294bb39e"), "17 Columbus Junction", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7113), new DateTime(1955, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "gbilson7@prnewswire.com", "Georgianna", "Female", "Bilson", "09397882449", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7114) },
                    { new Guid("353577f3-040d-4fd0-96a8-2055fcacec22"), "1 Pond Center", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7133), new DateTime(1996, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmularkeyd@typepad.com", "Montague", "Male", "Mularkey", "09306995169", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7134) },
                    { new Guid("3d65cb96-cd32-44db-9142-c94fd055db3a"), "03722 Westridge Court", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7140), new DateTime(1997, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "cthomkinsf@etsy.com", "Con", "Female", "Thomkins", "09939955254", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7141) },
                    { new Guid("42eb421e-932a-4443-b673-11c94f38ecd4"), "4526 Northfield Road", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7136), new DateTime(1953, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmerryfielde@nih.gov", "Morganica", "Female", "Merryfield", "09003901945", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7136) },
                    { new Guid("5c73f138-3314-4747-9f90-5c4506a3df53"), "97649 Corry Terrace", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7090), new DateTime(1956, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "mhabercham1@squidoo.com", "Maia", "Female", "Habercham", "09184621695", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7091) },
                    { new Guid("6893001e-d215-492f-9855-6599c2917267"), "9664 Redwing Court", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7151), new DateTime(1991, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "fstoweri@engadget.com", "Farlee", "Male", "Stower", "09579026072", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7151) },
                    { new Guid("85271f33-1857-4a1d-8143-3e103aee534a"), "62956 1st Street", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7144), new DateTime(1972, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "rmorgang@bbc.co.uk", "Rudy", "Male", "Morgan", "09597429865", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7145) },
                    { new Guid("889f924d-f483-418c-9e8a-430509ff777b"), "4608 Raven Parkway", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7093), new DateTime(1987, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "amacrow2@globo.com", "Alane", "Female", "Macrow", "09276939145", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7094) },
                    { new Guid("8c33904f-4b64-41fb-abb8-1a990b1c776a"), "82368 Boyd Point", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7117), new DateTime(2002, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahave8@so-net.ne.jp", "Alister", "Male", "Have", "09638397843", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7118) },
                    { new Guid("9605648a-49d9-496d-a710-59f1280c0008"), "58172 Ruskin Crossing", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7129), new DateTime(1965, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "tcantoc@msu.edu", "Trenton", "Male", "Canto", "09809339189", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7130) },
                    { new Guid("a897ce1f-d56c-4b3a-969e-97a81ba66e33"), "9 Pleasure Way", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7109), new DateTime(1978, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "jbrowett6@mediafire.com", "Jed", "Male", "Browett", "09143498357", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7109) },
                    { new Guid("ac9d5fa3-0bc4-4454-bdb7-d376eb842d07"), "64071 Acker Park", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7127), new DateTime(1997, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "cakramb@wsj.com", "Catlin", "Female", "Akram", "09093870858", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7127) },
                    { new Guid("af8695fa-b2e2-41b6-ad63-700f851de325"), "1 Dawn Circle", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7157), new DateTime(1994, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ddimnagej@etsy.com", "Delano", "Male", "Dimnage", "09662401440", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7158) },
                    { new Guid("dcd89b25-ca71-40c0-8614-ea950e93136b"), "52014 Leroy Hill", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7103), new DateTime(1954, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "hsimunek4@yellowpages.com", "Hinze", "Male", "Simunek", "09267006937", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7103) },
                    { new Guid("ea75052e-ac70-4c96-a14e-09fbb8ad3ce8"), "5234 Crossing Street", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7059), new DateTime(1975, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "mauris.sagittis@icloud.edu", "Madeline", "Female", "Baxter", "09123546789", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7077) },
                    { new Guid("fd6b3578-0054-4397-9e27-c8b0eb3c1790"), "57 Hagan Point", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7148), new DateTime(1992, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "rskedgeh@google.de", "Rhianna", "Female", "Skedge", "09956873369", new DateTime(2023, 2, 8, 2, 15, 45, 696, DateTimeKind.Local).AddTicks(7149) }
                });

            migrationBuilder.InsertData(
                table: "TRANSACTIONS LIST",
                columns: new[] { "Transaction_Id", "Amount", "ContactId", "TransactionDate" },
                values: new object[,]
                {
                    { new Guid("051a8ced-746d-4f76-be56-9dc861a8fbc8"), 17181.86m, new Guid("af8695fa-b2e2-41b6-ad63-700f851de325"), new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("07539120-e647-4520-b761-e6b734d02bb6"), 5204.34m, new Guid("42eb421e-932a-4443-b673-11c94f38ecd4"), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("09680f48-96f4-47d8-b8c8-8501166bea7d"), 15225.41m, new Guid("8c33904f-4b64-41fb-abb8-1a990b1c776a"), new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0b18df25-191f-4582-be45-00656f9b49e8"), 4079.20m, new Guid("9605648a-49d9-496d-a710-59f1280c0008"), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1bba2af5-e358-4d10-8277-ac91b4711693"), 14115.62m, new Guid("85271f33-1857-4a1d-8143-3e103aee534a"), new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("27826bac-c974-431b-9417-405af410278f"), 14523.92m, new Guid("5c73f138-3314-4747-9f90-5c4506a3df53"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2acafa55-2882-4e8f-a2aa-c101101a30e2"), 19646.52m, new Guid("3d65cb96-cd32-44db-9142-c94fd055db3a"), new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2ad64d18-aeed-430a-b41d-35d61fe074b3"), 3896.77m, new Guid("889f924d-f483-418c-9e8a-430509ff777b"), new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2dc1ef12-290c-4fbe-9d5e-a88fbecdd98b"), 6068.91m, new Guid("42eb421e-932a-4443-b673-11c94f38ecd4"), new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("39540533-593d-4c2c-8157-a3fe80beed8c"), 13405.27m, new Guid("0f237658-5350-4f5a-959f-8471326dfeba"), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a0c7575-a72d-4c4c-9db9-78cc776fc24c"), 12838.18m, new Guid("353577f3-040d-4fd0-96a8-2055fcacec22"), new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c16bceb-a70e-438c-a413-b3528881d3e4"), 14562.70m, new Guid("af8695fa-b2e2-41b6-ad63-700f851de325"), new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52202b15-3349-43ba-904a-a2e96c1e52ea"), 16861.07m, new Guid("af8695fa-b2e2-41b6-ad63-700f851de325"), new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5812559f-40e9-4794-8bf7-22ddf881269f"), 17362.33m, new Guid("889f924d-f483-418c-9e8a-430509ff777b"), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("618f8152-2768-41b2-9645-3d51d95c9af3"), 2116.34m, new Guid("42eb421e-932a-4443-b673-11c94f38ecd4"), new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("654c4871-fe12-44a2-9f84-90c3d7258dd3"), 15743.60m, new Guid("dcd89b25-ca71-40c0-8614-ea950e93136b"), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("68e52286-4d6a-48b2-8e63-d32491042004"), 7895.30m, new Guid("353577f3-040d-4fd0-96a8-2055fcacec22"), new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a520e4a-eba0-420a-a58c-faff3ce63b10"), 10839.38m, new Guid("35261dda-8935-4a36-ba8d-4018294bb39e"), new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7c43a06f-cb71-4b30-9821-65b1b2a6e289"), 7388.27m, new Guid("353577f3-040d-4fd0-96a8-2055fcacec22"), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7cf2c97d-8132-4d89-827c-81309ab5bd65"), 9842.85m, new Guid("6893001e-d215-492f-9855-6599c2917267"), new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f8ddd20-19d4-46a9-8cf5-264a358e0f1e"), 5587.62m, new Guid("fd6b3578-0054-4397-9e27-c8b0eb3c1790"), new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8331468f-d0fe-485f-84d2-59174634b970"), 19017.30m, new Guid("0439dcb1-5791-4868-bb56-b2638b357b4b"), new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8724c1dd-3d59-4255-b4cf-71488a6e737d"), 3940.43m, new Guid("fd6b3578-0054-4397-9e27-c8b0eb3c1790"), new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88f0c3c4-d1ad-43fa-8a4b-7f4ee438eddb"), 1183.59m, new Guid("ac9d5fa3-0bc4-4454-bdb7-d376eb842d07"), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a31b51f-6390-433c-8b65-6d9ea1afa738"), 18095.37m, new Guid("ac9d5fa3-0bc4-4454-bdb7-d376eb842d07"), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c91d2ab-9eb4-48fa-9fb0-68e56725b724"), 14447.04m, new Guid("8c33904f-4b64-41fb-abb8-1a990b1c776a"), new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8fe0d380-8888-406b-8242-f8a655653702"), 1347.45m, new Guid("6893001e-d215-492f-9855-6599c2917267"), new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("952a82d1-91cb-4ff7-8385-c782c5e3b828"), 8628.20m, new Guid("42eb421e-932a-4443-b673-11c94f38ecd4"), new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9a10eb8b-018b-46ff-985a-684b66eb1ddd"), 12432.71m, new Guid("ac9d5fa3-0bc4-4454-bdb7-d376eb842d07"), new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9a62f1b6-c650-49b8-8ce3-9b278e4c075e"), 11703.50m, new Guid("dcd89b25-ca71-40c0-8614-ea950e93136b"), new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9abdc6c7-3fa8-4a0c-bdae-0ac661ffa7f5"), 12163.93m, new Guid("0f237658-5350-4f5a-959f-8471326dfeba"), new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b0cb936-ddb3-4b16-ac31-4acafc8249bf"), 3134.06m, new Guid("8c33904f-4b64-41fb-abb8-1a990b1c776a"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9eb2dd8c-7860-435f-8ef1-8fad59d47c36"), 18900.31m, new Guid("3d65cb96-cd32-44db-9142-c94fd055db3a"), new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a07b72e2-12b7-45d7-b46f-295d76a4fcf0"), 3399.04m, new Guid("9605648a-49d9-496d-a710-59f1280c0008"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a665fe7e-df23-4e7c-8f46-ccd82c5c7d13"), 12621.27m, new Guid("13347c7f-1745-4751-8eb0-a175d4cc167f"), new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a7b910a2-f7ae-4f92-b1c4-18ba7c31ce42"), 17809.47m, new Guid("fd6b3578-0054-4397-9e27-c8b0eb3c1790"), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b55b6773-ba5a-48e6-be09-1cff15a1403e"), 15192.52m, new Guid("9605648a-49d9-496d-a710-59f1280c0008"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b748c414-3398-46fb-b938-127d99dd8fe3"), 13524.20m, new Guid("af8695fa-b2e2-41b6-ad63-700f851de325"), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba188a64-bd49-47f2-9dc7-9e3145356af1"), 8243.38m, new Guid("5c73f138-3314-4747-9f90-5c4506a3df53"), new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c14ca97a-b8c6-4d85-852a-da77fc8a83b5"), 14215.58m, new Guid("082fed74-e715-4d16-97b3-91ecaf905653"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3b84347-71f1-493a-a9f4-ceea154c947c"), 12396.27m, new Guid("889f924d-f483-418c-9e8a-430509ff777b"), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c8019d96-6082-4e36-aeb8-f9d2684e3ab3"), 7914.91m, new Guid("6893001e-d215-492f-9855-6599c2917267"), new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TRANSACTIONS LIST",
                columns: new[] { "Transaction_Id", "Amount", "ContactId", "TransactionDate" },
                values: new object[,]
                {
                    { new Guid("c867949e-28d2-4a23-ae68-5ff1a0abf842"), 8205.19m, new Guid("a897ce1f-d56c-4b3a-969e-97a81ba66e33"), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c8c5d75c-911c-4b0c-9b1f-7ab4264325cb"), 9929.75m, new Guid("85271f33-1857-4a1d-8143-3e103aee534a"), new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d3179c4f-bffd-4e6d-976e-427bb9ac9cd6"), 19958.59m, new Guid("af8695fa-b2e2-41b6-ad63-700f851de325"), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8da0c9e-1a2d-44ce-9340-4b89b1b83e7e"), 6523.52m, new Guid("42eb421e-932a-4443-b673-11c94f38ecd4"), new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8ddbe74-8495-4303-b4e9-5cc93894db0a"), 15326.44m, new Guid("a897ce1f-d56c-4b3a-969e-97a81ba66e33"), new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e3a53149-02d4-4c18-a413-6630d95c4a4b"), 14420.64m, new Guid("a897ce1f-d56c-4b3a-969e-97a81ba66e33"), new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f0804f63-8d9f-4a57-90c9-69cb27297c5f"), 19644.39m, new Guid("85271f33-1857-4a1d-8143-3e103aee534a"), new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f56da542-3a7a-4e6b-ab16-c575f96dac6f"), 13910.67m, new Guid("35261dda-8935-4a36-ba8d-4018294bb39e"), new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
