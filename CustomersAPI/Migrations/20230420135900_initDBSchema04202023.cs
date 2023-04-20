using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomersAPI.Migrations
{
    public partial class initDBSchema04202023 : Migration
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
                    { new Guid("0d4cdee0-09a2-41aa-b503-6dab93b2ab39"), 0, "Makati", "f7cc45e3-420e-4deb-a76f-39838dd97f73", new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAELzz85W/MCEkpF613+pyNn70Tnmc3cIDrq/08KXraHAK/qEhjkN5nwh7tOe7uOvq0A==", null, true, "", false, "user@crms.com" },
                    { new Guid("42522008-de29-4086-b3b3-ff8cd13cecf0"), 0, "Makati", "727ba01f-0e9d-450c-9981-8d58b7eb8173", new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEAS7oej7ni73j6PmbjVYVY6vZBfKq06V3awbO5XmB6EBndz0K5bT6VWe9bKzFlPNKw==", null, true, "", false, "su@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "CUSTOMERS LIST",
                columns: new[] { "Contact_Id", "Address", "CreateDate", "DOB", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1d9ab053-49db-47bd-af3d-912f361c9a0f"), "59830 Brickson Park Road", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7172), new DateTime(2001, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "khadlington9@paypal.com", "Kerianne", "Female", "Hadlington", "09225056729", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7172) },
                    { new Guid("22c416db-edfb-4aeb-85c8-79fe91ce7826"), "5234 Crossing Street", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7101), new DateTime(1975, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "mauris.sagittis@icloud.edu", "Madeline", "Female", "Baxter", "09123546789", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7116) },
                    { new Guid("23202d5d-3a78-4444-8ac6-49544b8a2283"), "82368 Boyd Point", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7169), new DateTime(2002, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahave8@so-net.ne.jp", "Alister", "Male", "Have", "09638397843", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7169) },
                    { new Guid("2b3c011b-432b-4873-a870-0662ba010568"), "673 Autumn Leaf Court", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7158), new DateTime(2006, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "asummerskill5@gravatar.com", "Angela", "Female", "Summerskill", "09337435073", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7158) },
                    { new Guid("485a5b31-f4d3-4917-8323-4dddec595cf2"), "58172 Ruskin Crossing", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7181), new DateTime(1965, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "tcantoc@msu.edu", "Trenton", "Male", "Canto", "09809339189", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7181) },
                    { new Guid("58c86370-6a63-4589-beb1-fa597d568c69"), "57 Hagan Point", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7199), new DateTime(1992, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "rskedgeh@google.de", "Rhianna", "Female", "Skedge", "09956873369", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7199) },
                    { new Guid("61c25c33-4552-43d4-9827-0c0d343817c9"), "3 Pepper Wood Center", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7139), new DateTime(1984, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "aabrahamovitz0@marketwatch.com", "Agatha", "Female", "Abrahamovitz", "09601729545", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7140) },
                    { new Guid("808b42d1-a4d4-4a9b-8322-6c78b43377bc"), "9 Pleasure Way", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7160), new DateTime(1978, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "jbrowett6@mediafire.com", "Jed", "Male", "Browett", "09143498357", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7162) },
                    { new Guid("84e288d4-29ea-4105-9ab0-68f3da729a8c"), "03722 Westridge Court", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7191), new DateTime(1997, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "cthomkinsf@etsy.com", "Con", "Female", "Thomkins", "09939955254", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7192) },
                    { new Guid("94e78008-9700-4a7f-92df-fa200ceb3cfd"), "624 Buhler Point", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7174), new DateTime(1994, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "mcrummaya@tripod.com", "Meggy", "Female", "Crummay", "09392511444", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7174) },
                    { new Guid("9eea9ba0-43eb-481a-89eb-433c8d880220"), "1 Dawn Circle", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7205), new DateTime(1994, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ddimnagej@etsy.com", "Delano", "Male", "Dimnage", "09662401440", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7205) },
                    { new Guid("afb73944-0966-40ef-b5da-45533e1a2793"), "9664 Redwing Court", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7201), new DateTime(1991, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "fstoweri@engadget.com", "Farlee", "Male", "Stower", "09579026072", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7202) },
                    { new Guid("b574da28-08a8-4020-9c56-56d0564052b3"), "1 Pond Center", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7186), new DateTime(1996, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmularkeyd@typepad.com", "Montague", "Male", "Mularkey", "09306995169", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7186) },
                    { new Guid("bc9659dc-cff6-4598-9680-fc13f91a1426"), "4608 Raven Parkway", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7146), new DateTime(1987, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "amacrow2@globo.com", "Alane", "Female", "Macrow", "09276939145", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7147) },
                    { new Guid("c9613993-24ab-4162-8261-c55ebf0aaf43"), "17 Columbus Junction", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7164), new DateTime(1955, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "gbilson7@prnewswire.com", "Georgianna", "Female", "Bilson", "09397882449", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7164) },
                    { new Guid("cd5e2b15-8294-48bc-968c-f53a2becbffa"), "62956 1st Street", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7196), new DateTime(1972, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "rmorgang@bbc.co.uk", "Rudy", "Male", "Morgan", "09597429865", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7197) },
                    { new Guid("d3a72633-940d-497e-bb7e-958247ec6283"), "52014 Leroy Hill", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7155), new DateTime(1954, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "hsimunek4@yellowpages.com", "Hinze", "Male", "Simunek", "09267006937", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7155) },
                    { new Guid("e1373572-b462-4a6c-a611-5ccef20aee42"), "64071 Acker Park", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7176), new DateTime(1997, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "cakramb@wsj.com", "Catlin", "Female", "Akram", "09093870858", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7177) },
                    { new Guid("e1b84966-5bc8-4cee-8090-8b384e1e9f6e"), "4526 Northfield Road", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7188), new DateTime(1953, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmerryfielde@nih.gov", "Morganica", "Female", "Merryfield", "09003901945", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7188) },
                    { new Guid("f2381586-b823-4ce1-b565-12a06b1283cd"), "97649 Corry Terrace", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7143), new DateTime(1956, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "mhabercham1@squidoo.com", "Maia", "Female", "Habercham", "09184621695", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7144) },
                    { new Guid("f66928fb-baba-48ca-94a3-cfb26836a639"), "2067 Golden Leaf Circle", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7149), new DateTime(1964, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedington3@illinois.edu", "Tracy", "Male", "Edington", "09265235080", new DateTime(2023, 2, 9, 21, 59, 0, 11, DateTimeKind.Local).AddTicks(7149) }
                });

            migrationBuilder.InsertData(
                table: "TRANSACTIONS LIST",
                columns: new[] { "Transaction_Id", "Amount", "ContactId", "TransactionDate" },
                values: new object[,]
                {
                    { new Guid("0183df0e-2fce-4145-85ad-55018146faee"), 3896.77m, new Guid("bc9659dc-cff6-4598-9680-fc13f91a1426"), new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0db382b6-cfa7-44d1-b38f-f8dc715aee4f"), 19646.52m, new Guid("84e288d4-29ea-4105-9ab0-68f3da729a8c"), new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10827af6-d459-457c-99f7-4b647362874e"), 13405.27m, new Guid("f66928fb-baba-48ca-94a3-cfb26836a639"), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("18f439c8-383c-4d77-9060-7bfff841ac5c"), 3134.06m, new Guid("23202d5d-3a78-4444-8ac6-49544b8a2283"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("19f98f83-efea-4e18-bed3-67370a3aee28"), 3940.43m, new Guid("58c86370-6a63-4589-beb1-fa597d568c69"), new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1be6cb96-cc3f-4cdb-9644-cc8c1e3786f1"), 12163.93m, new Guid("f66928fb-baba-48ca-94a3-cfb26836a639"), new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("239f2143-02e4-4f7c-8fad-88cdfdeaad8e"), 19644.39m, new Guid("cd5e2b15-8294-48bc-968c-f53a2becbffa"), new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("23be9131-61ac-4492-b118-366ff74508cf"), 15326.44m, new Guid("808b42d1-a4d4-4a9b-8322-6c78b43377bc"), new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("264ae730-5010-4214-9238-3c27eb410826"), 5587.62m, new Guid("58c86370-6a63-4589-beb1-fa597d568c69"), new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("283f4e8f-7951-4c35-878a-bd79b6ed143d"), 3399.04m, new Guid("485a5b31-f4d3-4917-8323-4dddec595cf2"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("314b29ef-a561-473a-8b5b-7cb759aeebd7"), 13524.20m, new Guid("9eea9ba0-43eb-481a-89eb-433c8d880220"), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("35fbf1d2-bed3-45f8-9964-22b131c53247"), 11703.50m, new Guid("d3a72633-940d-497e-bb7e-958247ec6283"), new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3b44274d-e86d-4b36-9e41-4bfa3fe5f392"), 14523.92m, new Guid("f2381586-b823-4ce1-b565-12a06b1283cd"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("40542923-6d15-4551-9d3f-9e4dc5f4f67b"), 7895.30m, new Guid("b574da28-08a8-4020-9c56-56d0564052b3"), new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("42e3d422-62f7-4ac6-bdd0-5e614038e3f5"), 12621.27m, new Guid("94e78008-9700-4a7f-92df-fa200ceb3cfd"), new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("465aa655-2f48-4384-97d5-0ccb9b00d5a6"), 2116.34m, new Guid("e1b84966-5bc8-4cee-8090-8b384e1e9f6e"), new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4e0fd1d1-395d-4a12-bda7-a8458a11b49c"), 13910.67m, new Guid("c9613993-24ab-4162-8261-c55ebf0aaf43"), new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4fb734be-aa89-4786-bcdc-b2f9a4535240"), 14115.62m, new Guid("cd5e2b15-8294-48bc-968c-f53a2becbffa"), new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("512476a5-ff0e-44e6-9402-ff8e352107dd"), 17809.47m, new Guid("58c86370-6a63-4589-beb1-fa597d568c69"), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("53b8190e-fbd9-4e72-845e-5cd98e6da6f6"), 15192.52m, new Guid("485a5b31-f4d3-4917-8323-4dddec595cf2"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("586e797b-b55b-4b8b-b55d-b6d139327b47"), 9929.75m, new Guid("cd5e2b15-8294-48bc-968c-f53a2becbffa"), new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("588a9332-204f-4a89-a2fb-fbc7cdd9fa3d"), 10839.38m, new Guid("c9613993-24ab-4162-8261-c55ebf0aaf43"), new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("64b1da2d-8db8-4439-858b-971103a8ee28"), 6068.91m, new Guid("e1b84966-5bc8-4cee-8090-8b384e1e9f6e"), new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a0d4052-ac84-406f-97d9-01087248b1d9"), 8628.20m, new Guid("e1b84966-5bc8-4cee-8090-8b384e1e9f6e"), new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6afce422-7e27-4088-b84c-86a5077a5681"), 4079.20m, new Guid("485a5b31-f4d3-4917-8323-4dddec595cf2"), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("79a0ab99-15ca-48af-a157-9a6fe3ca7208"), 18095.37m, new Guid("e1373572-b462-4a6c-a611-5ccef20aee42"), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c87f3fd-b8d9-44e8-a265-eadaa60cbc72"), 15743.60m, new Guid("d3a72633-940d-497e-bb7e-958247ec6283"), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8cdd2d41-91de-4839-93aa-a5e4e883369e"), 14562.70m, new Guid("9eea9ba0-43eb-481a-89eb-433c8d880220"), new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8feebdf7-721b-4f01-a387-d45b2fa0c431"), 17362.33m, new Guid("bc9659dc-cff6-4598-9680-fc13f91a1426"), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9f997564-d9bc-445d-b045-3ea4ec35a35d"), 19017.30m, new Guid("61c25c33-4552-43d4-9827-0c0d343817c9"), new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a7582af9-9cab-4b4f-86de-9493540fb602"), 8243.38m, new Guid("f2381586-b823-4ce1-b565-12a06b1283cd"), new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa80e919-292a-4c39-b03e-cbf2429b1059"), 12432.71m, new Guid("e1373572-b462-4a6c-a611-5ccef20aee42"), new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad46ea45-25a7-4186-8c50-ac7786b5ea9e"), 9842.85m, new Guid("afb73944-0966-40ef-b5da-45533e1a2793"), new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b871d17d-49c3-4430-9252-9426b18a953d"), 14447.04m, new Guid("23202d5d-3a78-4444-8ac6-49544b8a2283"), new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("beee72c5-cca1-4685-96c1-0fcab56fde4f"), 1183.59m, new Guid("e1373572-b462-4a6c-a611-5ccef20aee42"), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c5c5acec-ba3c-4ae2-9f8c-3e5d964f434a"), 7914.91m, new Guid("afb73944-0966-40ef-b5da-45533e1a2793"), new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c61b3c3e-f293-4e4f-9515-0d5417165142"), 15225.41m, new Guid("23202d5d-3a78-4444-8ac6-49544b8a2283"), new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c98b11fc-959b-448f-9906-19feef86572a"), 5204.34m, new Guid("e1b84966-5bc8-4cee-8090-8b384e1e9f6e"), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d6d8da1c-6a0d-4bfa-af90-897ede954390"), 8205.19m, new Guid("808b42d1-a4d4-4a9b-8322-6c78b43377bc"), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d902f4a7-192c-49ad-9ee2-8cc8104547f5"), 6523.52m, new Guid("e1b84966-5bc8-4cee-8090-8b384e1e9f6e"), new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("de6b3c27-2607-411a-b1c6-caa888968c4f"), 18900.31m, new Guid("84e288d4-29ea-4105-9ab0-68f3da729a8c"), new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e0cc4764-b1a8-4fe1-bab3-45b0418cd4fa"), 12396.27m, new Guid("bc9659dc-cff6-4598-9680-fc13f91a1426"), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TRANSACTIONS LIST",
                columns: new[] { "Transaction_Id", "Amount", "ContactId", "TransactionDate" },
                values: new object[,]
                {
                    { new Guid("e3daee09-fb85-436b-8437-4ae1a211b6f3"), 17181.86m, new Guid("9eea9ba0-43eb-481a-89eb-433c8d880220"), new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e49d516a-b5a8-43bd-9584-fb6a3f83b0f1"), 1347.45m, new Guid("afb73944-0966-40ef-b5da-45533e1a2793"), new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f0ab6f72-287f-4aae-a5c3-c0d5e24e9d5b"), 16861.07m, new Guid("9eea9ba0-43eb-481a-89eb-433c8d880220"), new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f10b90a3-e5b2-4a4a-8022-bed695006584"), 7388.27m, new Guid("b574da28-08a8-4020-9c56-56d0564052b3"), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f23506fe-1a50-41e1-ae25-6ec8c75baaf7"), 14420.64m, new Guid("808b42d1-a4d4-4a9b-8322-6c78b43377bc"), new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f36af356-ff4b-446b-bda8-3582f6feebaf"), 19958.59m, new Guid("9eea9ba0-43eb-481a-89eb-433c8d880220"), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f4a8065d-6d0b-440b-ab25-a8394438b9ed"), 12838.18m, new Guid("b574da28-08a8-4020-9c56-56d0564052b3"), new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8627465-b875-49d1-a688-6463092c9d88"), 14215.58m, new Guid("2b3c011b-432b-4873-a870-0662ba010568"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
