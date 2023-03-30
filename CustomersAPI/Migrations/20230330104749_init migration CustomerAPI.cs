using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomersAPI.Migrations
{
    public partial class initmigrationCustomerAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("026b6f1a-d2aa-44e5-b064-83228988f1b4"), "57 Hagan Point", new DateTime(1992, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "rskedgeh@google.de", "Rhianna", "Female", "Skedge", "09956873369" },
                    { new Guid("0d67eb24-4ff5-48d2-b7e3-0c20e5722b9d"), "17 Columbus Junction", new DateTime(1955, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "gbilson7@prnewswire.com", "Georgianna", "Female", "Bilson", "09397882449" },
                    { new Guid("0f5da1f6-8af2-45b7-b7f7-1009a0824a75"), "624 Buhler Point", new DateTime(1994, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "mcrummaya@tripod.com", "Meggy", "Female", "Crummay", "09392511444" },
                    { new Guid("11c4b4c3-4c5b-4dc2-a34b-b632a701eb40"), "2067 Golden Leaf Circle", new DateTime(1964, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedington3@illinois.edu", "Tracy", "Male", "Edington", "09265235080" },
                    { new Guid("2ee2d83f-62e0-40b7-ad0b-14b1b81ed871"), "4526 Northfield Road", new DateTime(1953, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmerryfielde@nih.gov", "Morganica", "Female", "Merryfield", "09003901945" },
                    { new Guid("32ba67ab-9d6b-4ebc-8bc5-0740fbe25b32"), "1 Dawn Circle", new DateTime(1994, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ddimnagej@etsy.com", "Delano", "Male", "Dimnage", "09662401440" },
                    { new Guid("34678801-6788-438c-88a0-95f8e3aa5382"), "58172 Ruskin Crossing", new DateTime(1965, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "tcantoc@msu.edu", "Trenton", "Male", "Canto", "09809339189" },
                    { new Guid("37bb612e-a419-42ec-ba3c-98e0806bc328"), "4608 Raven Parkway", new DateTime(1987, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "amacrow2@globo.com", "Alane", "Female", "Macrow", "09276939145" },
                    { new Guid("49251f79-637d-413f-83df-a596818e7936"), "3 Pepper Wood Center", new DateTime(1984, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "aabrahamovitz0@marketwatch.com", "Agatha", "Female", "Abrahamovitz", "09601729545" },
                    { new Guid("4ba14856-6a17-42e3-be8e-c1253fd1d9d9"), "97649 Corry Terrace", new DateTime(1956, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "mhabercham1@squidoo.com", "Maia", "Female", "Habercham", "09184621695" },
                    { new Guid("5bcea2f4-b79d-4fdf-a378-d67d6fb3f568"), "9 Pleasure Way", new DateTime(1978, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "jbrowett6@mediafire.com", "Jed", "Male", "Browett", "09143498357" },
                    { new Guid("5e8eeaa8-1f10-40de-bfe8-2089f9f8d6d9"), "52014 Leroy Hill", new DateTime(1954, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "hsimunek4@yellowpages.com", "Hinze", "Male", "Simunek", "09267006937" },
                    { new Guid("62b1ae3b-58f1-4a0c-8e80-f22e170bda8a"), "82368 Boyd Point", new DateTime(2002, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahave8@so-net.ne.jp", "Alister", "Male", "Have", "09638397843" },
                    { new Guid("ade4638a-f6af-430f-a1f0-4c272bae514e"), "64071 Acker Park", new DateTime(1997, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "cakramb@wsj.com", "Catlin", "Female", "Akram", "09093870858" },
                    { new Guid("b5c4f49b-9d42-4dcf-850f-bd2748b9a086"), "5234 Crossing Street", new DateTime(1975, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "mauris.sagittis@icloud.edu", "Madeline", "Female", "Baxter", "09123546789" },
                    { new Guid("c5d15bbf-0629-4b65-9bbe-53acbadee905"), "62956 1st Street", new DateTime(1972, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "rmorgang@bbc.co.uk", "Rudy", "Male", "Morgan", "09597429865" },
                    { new Guid("c5dee34c-f062-4723-9d00-b9d21624cdf6"), "1 Pond Center", new DateTime(1996, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmularkeyd@typepad.com", "Montague", "Male", "Mularkey", "09306995169" },
                    { new Guid("d8cf10d0-0095-44ce-8263-bef0e0119659"), "9664 Redwing Court", new DateTime(1991, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "fstoweri@engadget.com", "Farlee", "Male", "Stower", "09579026072" },
                    { new Guid("ec894063-3b56-4a26-9fa9-5ea6565f8049"), "673 Autumn Leaf Court", new DateTime(2006, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "asummerskill5@gravatar.com", "Angela", "Female", "Summerskill", "09337435073" },
                    { new Guid("edf55e81-8fe1-47d2-9d0a-b605951d756a"), "03722 Westridge Court", new DateTime(1997, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "cthomkinsf@etsy.com", "Con", "Female", "Thomkins", "09939955254" },
                    { new Guid("f4b8736c-409f-4d76-86a2-eb31a849f2ee"), "59830 Brickson Park Road", new DateTime(2001, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "khadlington9@paypal.com", "Kerianne", "Female", "Hadlington", "09225056729" }
                });

            migrationBuilder.InsertData(
                table: "TRANSACTIONS LIST",
                columns: new[] { "Transaction_Id", "Amount", "CustomerId", "TransactionDate" },
                values: new object[,]
                {
                    { new Guid("01bfd07c-e870-4867-a491-a524bdab507f"), 5204.34m, new Guid("2ee2d83f-62e0-40b7-ad0b-14b1b81ed871"), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("04fbdc8c-89c3-47c6-be50-2c0503b5e0a9"), 3896.77m, new Guid("37bb612e-a419-42ec-ba3c-98e0806bc328"), new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("050f71c4-ea5f-4d93-9e5d-1cd443274cd8"), 2116.34m, new Guid("2ee2d83f-62e0-40b7-ad0b-14b1b81ed871"), new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0a0f7578-1c28-497e-ad7f-065641e3dcae"), 9842.85m, new Guid("d8cf10d0-0095-44ce-8263-bef0e0119659"), new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("11ae8710-4aef-4849-a9e5-6ed8eb010a8f"), 17181.86m, new Guid("32ba67ab-9d6b-4ebc-8bc5-0740fbe25b32"), new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("19c9c154-58d9-479f-8b3b-b8705cf47314"), 4079.20m, new Guid("34678801-6788-438c-88a0-95f8e3aa5382"), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1ed02e48-8f66-46a6-a883-1325f1d67740"), 18900.31m, new Guid("edf55e81-8fe1-47d2-9d0a-b605951d756a"), new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f40f67f-5499-48cb-92e6-3766719c0a80"), 15192.52m, new Guid("34678801-6788-438c-88a0-95f8e3aa5382"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22c33b66-7bf8-4ba9-a0f7-acb23a69c2a3"), 12838.18m, new Guid("c5dee34c-f062-4723-9d00-b9d21624cdf6"), new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("28841356-ef18-45e7-b08f-b98249a06e9b"), 5587.62m, new Guid("026b6f1a-d2aa-44e5-b064-83228988f1b4"), new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("35dafa6c-e09f-41de-a1f9-129575aa1fe4"), 14115.62m, new Guid("c5d15bbf-0629-4b65-9bbe-53acbadee905"), new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("361e0099-5f0d-442d-903d-030dcb6a97f3"), 11703.50m, new Guid("5e8eeaa8-1f10-40de-bfe8-2089f9f8d6d9"), new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3700f939-cf85-4b2b-b2e3-a8a8a566adad"), 7914.91m, new Guid("d8cf10d0-0095-44ce-8263-bef0e0119659"), new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4512388c-5e51-4fb9-a431-a55344eb78d2"), 15326.44m, new Guid("5bcea2f4-b79d-4fdf-a378-d67d6fb3f568"), new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4cc61ade-682f-4d9b-abd8-64a17dcce762"), 3134.06m, new Guid("62b1ae3b-58f1-4a0c-8e80-f22e170bda8a"), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ebf69e4-bbe1-489e-8bff-cd402b90543a"), 8205.19m, new Guid("5bcea2f4-b79d-4fdf-a378-d67d6fb3f568"), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5751685c-7175-4973-8f0a-809e55d4b69b"), 6068.91m, new Guid("2ee2d83f-62e0-40b7-ad0b-14b1b81ed871"), new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("684312ea-0a64-4614-96d7-e377169cee15"), 17362.33m, new Guid("37bb612e-a419-42ec-ba3c-98e0806bc328"), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("708311b0-82cd-4e8a-bfdb-765b16a6e726"), 7388.27m, new Guid("c5dee34c-f062-4723-9d00-b9d21624cdf6"), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("70853e7e-b5a8-462b-b817-05975154bf58"), 13910.67m, new Guid("0d67eb24-4ff5-48d2-b7e3-0c20e5722b9d"), new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("70920a75-ff0c-4a91-a2fe-e574677e9fea"), 19958.59m, new Guid("32ba67ab-9d6b-4ebc-8bc5-0740fbe25b32"), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76373f06-c630-4e4f-839e-3b7d02fb3644"), 1347.45m, new Guid("d8cf10d0-0095-44ce-8263-bef0e0119659"), new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78cbf1cc-8af6-44c6-94b9-148aeb2397cd"), 12432.71m, new Guid("ade4638a-f6af-430f-a1f0-4c272bae514e"), new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("872b0336-a3d2-4080-a422-e98de6a268f2"), 6523.52m, new Guid("2ee2d83f-62e0-40b7-ad0b-14b1b81ed871"), new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8de0f7f0-9f3a-4d70-b648-b2e08f689b8c"), 14562.70m, new Guid("32ba67ab-9d6b-4ebc-8bc5-0740fbe25b32"), new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8ded48d7-9884-4a0c-82a1-2137c16f033f"), 9929.75m, new Guid("c5d15bbf-0629-4b65-9bbe-53acbadee905"), new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8fb38c8f-2561-4754-aa7a-fad5ba63229d"), 1183.59m, new Guid("ade4638a-f6af-430f-a1f0-4c272bae514e"), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("904170c2-ed34-4437-8879-18620cf33b00"), 12396.27m, new Guid("37bb612e-a419-42ec-ba3c-98e0806bc328"), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92433e38-af44-4beb-951f-34faeb3c3750"), 15225.41m, new Guid("62b1ae3b-58f1-4a0c-8e80-f22e170bda8a"), new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99a8ec9b-80a4-4ef5-9b0b-1f4cf8614d57"), 12163.93m, new Guid("11c4b4c3-4c5b-4dc2-a34b-b632a701eb40"), new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9a838dd8-8dff-4528-8c2d-1f71d139f6fe"), 3940.43m, new Guid("026b6f1a-d2aa-44e5-b064-83228988f1b4"), new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a442172b-d901-4658-a1d8-42a37ae420fe"), 19646.52m, new Guid("edf55e81-8fe1-47d2-9d0a-b605951d756a"), new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa959317-8013-4f50-b51d-7967d99f5fcd"), 19017.30m, new Guid("49251f79-637d-413f-83df-a596818e7936"), new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("add08a49-59a8-415c-ae42-ee30302b28f5"), 13524.20m, new Guid("32ba67ab-9d6b-4ebc-8bc5-0740fbe25b32"), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("afec2965-82a0-49ef-9109-488b07d429c2"), 14523.92m, new Guid("4ba14856-6a17-42e3-be8e-c1253fd1d9d9"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b224b098-0634-49ba-9593-00f5c63d3692"), 8243.38m, new Guid("4ba14856-6a17-42e3-be8e-c1253fd1d9d9"), new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b59b48ff-d969-4611-9140-0d603aad2556"), 14215.58m, new Guid("ec894063-3b56-4a26-9fa9-5ea6565f8049"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4657148-c4eb-45b1-b66a-280dd9cbbba1"), 16861.07m, new Guid("32ba67ab-9d6b-4ebc-8bc5-0740fbe25b32"), new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc7331a0-d6b2-4a7a-b323-b7b33761e345"), 14447.04m, new Guid("62b1ae3b-58f1-4a0c-8e80-f22e170bda8a"), new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d121e8a8-490f-46ae-ab8d-803d6ba61d56"), 8628.20m, new Guid("2ee2d83f-62e0-40b7-ad0b-14b1b81ed871"), new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d28e6fed-4ce4-4f11-9acc-33d22b6bc366"), 14420.64m, new Guid("5bcea2f4-b79d-4fdf-a378-d67d6fb3f568"), new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d2b0dbb2-06db-49ef-bf58-99ed3f5e023d"), 15743.60m, new Guid("5e8eeaa8-1f10-40de-bfe8-2089f9f8d6d9"), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TRANSACTIONS LIST",
                columns: new[] { "Transaction_Id", "Amount", "CustomerId", "TransactionDate" },
                values: new object[,]
                {
                    { new Guid("d66d46db-b136-4a56-8d08-71a3a86dde40"), 18095.37m, new Guid("ade4638a-f6af-430f-a1f0-4c272bae514e"), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d7eaf4da-c52f-4605-aa1e-d1e37c7362d1"), 13405.27m, new Guid("11c4b4c3-4c5b-4dc2-a34b-b632a701eb40"), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e54b1e98-5f8f-4ed1-8e78-2b985aacbd27"), 19644.39m, new Guid("c5d15bbf-0629-4b65-9bbe-53acbadee905"), new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e6510ea0-d8e2-4edb-a40b-7533fd5bee3d"), 7895.30m, new Guid("c5dee34c-f062-4723-9d00-b9d21624cdf6"), new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eac08797-eba8-4818-af91-9028e941bb7d"), 17809.47m, new Guid("026b6f1a-d2aa-44e5-b064-83228988f1b4"), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef7c2d7f-5ff2-47a6-87ac-677f39e9ab11"), 12621.27m, new Guid("0f5da1f6-8af2-45b7-b7f7-1009a0824a75"), new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f3833de4-83bd-45a1-ab30-31af5d837eb7"), 3399.04m, new Guid("34678801-6788-438c-88a0-95f8e3aa5382"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f4087fb8-60af-4e35-9174-759223fd011d"), 10839.38m, new Guid("0d67eb24-4ff5-48d2-b7e3-0c20e5722b9d"), new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TRANSACTIONS LIST_CustomerId",
                table: "TRANSACTIONS LIST",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TRANSACTIONS LIST");

            migrationBuilder.DropTable(
                name: "CUSTOMERS LIST");
        }
    }
}
