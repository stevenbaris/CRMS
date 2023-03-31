using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class addleadstatusandsource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("07e2c562-6b90-4559-85f1-12e6fdc0f4fc"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("85211b5c-0733-456c-abd3-101aa251dc53"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("98e288e3-654c-4a3a-8b8b-a775f2eb3829"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("a17a9e89-703c-456c-8cf7-307020542c83"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("c1a07a9c-ee9b-47ee-ab37-ca406a78707c"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("48fe6fe4-a4b6-49c4-9f1d-4471f3dbcad6"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("6e0f22d6-3397-4a32-9f36-ddedad74a5da"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("7bef1c63-5b05-47e6-a7a6-2704333d19bb"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("ae5fd60c-dd12-4f0c-bd7c-bda592cfcb91"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("bd7fe088-0bcd-4d24-8ba7-7ae59f730057"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("ca6e9e86-fa5c-407f-a6e1-a8a472c780c3"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("dd0cc4e5-6ce5-43a7-bbcc-34b5159a40be"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("fdfdf9db-5356-4522-8924-c4ea838d7901"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("57b13b9b-fd42-4f9c-a73b-3dfcfd32dcdb"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("84ef3def-854a-4f45-81de-0a99bcba827e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("c0128c24-1163-44cb-9d23-93d28ff5b246"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("ef9483d2-ccce-4124-8de1-c10392285805"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("614779ba-0c52-4cc3-a617-12471e4c0f6a"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("6ef33022-617f-4990-bde9-2b78b445b44e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("84265c26-065a-4e92-a524-9519ee663d21"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("9442c012-5fd9-45c9-9201-dffb189c6a52"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("d078468f-bbc7-4794-b7ff-9c36665dfcdf"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("dac3000c-d1b4-4e2b-a74c-1c094f0efb24"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("db1bc8e5-9d59-4079-b425-a302c59ceb73"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("ec94bb51-2294-4428-9212-d88071566f23"));

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

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("14b225d2-a67b-4ce7-a874-d7e4d43b7bc0"), "Presentation" },
                    { new Guid("39e0e557-04cb-47a7-998b-32fae947dacc"), "Proposal" },
                    { new Guid("b723e6c9-17a9-4fd5-9a0d-82dbbe2b48de"), "Fact-Find" },
                    { new Guid("cefb49da-c282-4627-906e-ee0d56ce81a0"), "Sales Closing" },
                    { new Guid("fe21a2e1-0d21-408b-9cc2-272f3ee542c8"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("2217910d-7f3a-4f3f-ab09-88122e46b65f"), "Instagram" },
                    { new Guid("37169b6b-3501-4ae4-b4a9-5851e441dbd2"), "Test Message" },
                    { new Guid("48651ee6-af94-4a26-a1db-416cc3c39594"), "Others" },
                    { new Guid("4bdb241e-644c-4b83-88ef-8babb9dac2b6"), "Facebook" },
                    { new Guid("646c730f-d5b1-4046-82da-fd403b78f68c"), "WhatsApp" },
                    { new Guid("889b0b4e-ad4d-465d-8406-ccd35651c3c0"), "Line" },
                    { new Guid("ba768f7c-66b4-49bc-ad38-263e242fa469"), "Email" },
                    { new Guid("d0d011fe-53e0-442b-ae07-435b45495200"), "Phone Call" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("14f8c3ce-0dae-4793-a428-0e7665e5585e"), "Read but no response" },
                    { new Guid("194cc59a-d282-4c45-8dcf-8ed057d75c0e"), "Simple Response" },
                    { new Guid("76d947a0-c597-4ef2-83f0-7f4036bd3471"), "Good Engagement" },
                    { new Guid("824be642-ca17-4bbd-a7eb-6fdb7aec0cf4"), "Not Read" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("1c6c8f48-5583-4435-821e-857e0c5a6a3b"), "Holiday" },
                    { new Guid("21d87b01-7ac2-42cf-8399-bf752fb635fb"), "Birthday" },
                    { new Guid("41c9261f-5751-49ef-a7f1-24bc4b1057c4"), "Company News" },
                    { new Guid("5b2768ef-a1b1-444c-b0ac-155d433ff362"), "Anniversary" },
                    { new Guid("8905c48d-c071-43b0-a859-2daed63da8bc"), "New Product" },
                    { new Guid("a3a45328-c7b8-4913-af67-5429ae1dc300"), "Congratulations" },
                    { new Guid("b58d27f3-4247-4c7b-ba58-0e87d7c52cdc"), "Discount" },
                    { new Guid("dabbed93-cce7-4c2c-aab1-0e40ac34f6dd"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("20921d0a-a717-4a85-b4a5-b26c7f84f9c7"), "Referral" },
                    { new Guid("4ec7dec0-24f1-4d29-827f-0e03e8d405de"), "Social Media" },
                    { new Guid("953c53b9-325b-4ac8-9c82-325226b030c1"), "Compony-Generated" },
                    { new Guid("a6b740f4-faab-4f36-a6e2-72ebe572a9e5"), "Webinar" },
                    { new Guid("cd7a22ce-0632-4b13-a3e0-eb502de8faa3"), "Others" },
                    { new Guid("f992ea21-08f3-4c2f-bb98-91946bc15da2"), "Friend" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("2348a0ac-7197-481d-96c4-64b28f3ffd9b"), "Application Submitted" },
                    { new Guid("2643073b-3b97-46c5-8218-1db223193676"), "Met" },
                    { new Guid("802f018e-6c60-4d4b-b045-ee561a2c38a6"), "Proposal Generated" },
                    { new Guid("8d4be98a-1d59-4866-9528-3bbbd94d6257"), "Lead is Dead" },
                    { new Guid("99c01814-4d9a-4a57-8c0e-96e36e865c88"), "Contacted" },
                    { new Guid("ed6dc4a7-c020-441e-8a89-57c208e14a65"), "Policy Issued" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LEADS_SOURCES");

            migrationBuilder.DropTable(
                name: "LEADS_STATUSES");

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("14b225d2-a67b-4ce7-a874-d7e4d43b7bc0"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("39e0e557-04cb-47a7-998b-32fae947dacc"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("b723e6c9-17a9-4fd5-9a0d-82dbbe2b48de"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("cefb49da-c282-4627-906e-ee0d56ce81a0"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("fe21a2e1-0d21-408b-9cc2-272f3ee542c8"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("2217910d-7f3a-4f3f-ab09-88122e46b65f"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("37169b6b-3501-4ae4-b4a9-5851e441dbd2"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("48651ee6-af94-4a26-a1db-416cc3c39594"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("4bdb241e-644c-4b83-88ef-8babb9dac2b6"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("646c730f-d5b1-4046-82da-fd403b78f68c"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("889b0b4e-ad4d-465d-8406-ccd35651c3c0"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("ba768f7c-66b4-49bc-ad38-263e242fa469"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("d0d011fe-53e0-442b-ae07-435b45495200"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("14f8c3ce-0dae-4793-a428-0e7665e5585e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("194cc59a-d282-4c45-8dcf-8ed057d75c0e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("76d947a0-c597-4ef2-83f0-7f4036bd3471"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("824be642-ca17-4bbd-a7eb-6fdb7aec0cf4"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("1c6c8f48-5583-4435-821e-857e0c5a6a3b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("21d87b01-7ac2-42cf-8399-bf752fb635fb"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("41c9261f-5751-49ef-a7f1-24bc4b1057c4"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("5b2768ef-a1b1-444c-b0ac-155d433ff362"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("8905c48d-c071-43b0-a859-2daed63da8bc"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("a3a45328-c7b8-4913-af67-5429ae1dc300"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("b58d27f3-4247-4c7b-ba58-0e87d7c52cdc"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("dabbed93-cce7-4c2c-aab1-0e40ac34f6dd"));

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
    }
}
