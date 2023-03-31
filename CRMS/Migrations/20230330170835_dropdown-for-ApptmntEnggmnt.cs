using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class dropdownforApptmntEnggmnt : Migration
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

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("07e2c562-6b90-4559-85f1-12e6fdc0f4fc"), "Others" },
                    { new Guid("85211b5c-0733-456c-abd3-101aa251dc53"), "Presentation" },
                    { new Guid("98e288e3-654c-4a3a-8b8b-a775f2eb3829"), "Proposal" },
                    { new Guid("a17a9e89-703c-456c-8cf7-307020542c83"), "Fact-Find" },
                    { new Guid("c1a07a9c-ee9b-47ee-ab37-ca406a78707c"), "Sales Closing" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("48fe6fe4-a4b6-49c4-9f1d-4471f3dbcad6"), "Instagram" },
                    { new Guid("6e0f22d6-3397-4a32-9f36-ddedad74a5da"), "Phone Call" },
                    { new Guid("7bef1c63-5b05-47e6-a7a6-2704333d19bb"), "Others" },
                    { new Guid("ae5fd60c-dd12-4f0c-bd7c-bda592cfcb91"), "WhatsApp" },
                    { new Guid("bd7fe088-0bcd-4d24-8ba7-7ae59f730057"), "Email" },
                    { new Guid("ca6e9e86-fa5c-407f-a6e1-a8a472c780c3"), "Test Message" },
                    { new Guid("dd0cc4e5-6ce5-43a7-bbcc-34b5159a40be"), "Facebook" },
                    { new Guid("fdfdf9db-5356-4522-8924-c4ea838d7901"), "Line" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("57b13b9b-fd42-4f9c-a73b-3dfcfd32dcdb"), "Read but no response" },
                    { new Guid("84ef3def-854a-4f45-81de-0a99bcba827e"), "Simple Response" },
                    { new Guid("c0128c24-1163-44cb-9d23-93d28ff5b246"), "Good Engagement" },
                    { new Guid("ef9483d2-ccce-4124-8de1-c10392285805"), "Not Read" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("614779ba-0c52-4cc3-a617-12471e4c0f6a"), "Others" },
                    { new Guid("6ef33022-617f-4990-bde9-2b78b445b44e"), "New Product" },
                    { new Guid("84265c26-065a-4e92-a524-9519ee663d21"), "Anniversary" },
                    { new Guid("9442c012-5fd9-45c9-9201-dffb189c6a52"), "Congratulations" },
                    { new Guid("d078468f-bbc7-4794-b7ff-9c36665dfcdf"), "Discount" },
                    { new Guid("dac3000c-d1b4-4e2b-a74c-1c094f0efb24"), "Holiday" },
                    { new Guid("db1bc8e5-9d59-4079-b425-a302c59ceb73"), "Company News" },
                    { new Guid("ec94bb51-2294-4428-9212-d88071566f23"), "Birthday" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APPOINTMENT_PURPOSES");

            migrationBuilder.DropTable(
                name: "ENGAGEMENT_COMMUNICATION METHODS");

            migrationBuilder.DropTable(
                name: "ENGAGEMENT_EFFECTIVITY");

            migrationBuilder.DropTable(
                name: "ENGAGEMENT_ENGAGEMENT-TYPES");
        }
    }
}
