using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class addRollingTransactionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("1ab2f946-f117-4702-ad14-05150a77243f"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("3dbba4ea-3e87-436a-88d4-2bea2faa2e89"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("43b0f213-a447-4f12-980a-b948403fc490"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("4bb4af14-f406-4836-9ff5-07a136a20c31"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("97b81117-da08-47fe-a24e-60d8f7be34fc"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("47947c54-cbea-4751-bf82-ac43fdbdbf55"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("68bf1f8e-f31d-418e-824c-2f55db4e81e7"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("7dc22be9-52d8-4d83-b1a0-2e01456aa305"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("895b5fba-8559-4aa2-8a1e-1dfb4d371903"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("ca67a03e-44b4-4cd0-885c-17e5c2cee30a"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("cd1d02a3-fcbc-49b6-afb0-0c789ad63035"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("d63e684c-fe71-427b-8620-19f57c9fa95a"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("ebf32643-30cd-4173-b9cf-0ec9a2b6c1c3"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("6174d5d8-631f-4078-9330-2d7508f247d5"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("8d906718-db4c-4206-84e5-0153921199e0"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("d0a08d8c-246f-42ca-a15a-26529aefdc14"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("d578ba6c-d51e-4774-8314-9c406bd5d450"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("057bb849-c0a0-4d27-8296-4855bf0ab0c3"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("1451297a-93da-47b9-a5eb-67544830726f"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("1af2cf2f-2bda-45bb-9d86-2e6a49464517"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("54c79ced-f46d-4f52-ad58-f4d7bcf9b053"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("748323cb-aaba-4740-9c25-59cf2e4a5c8d"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("ae75c350-a351-43bb-8c0e-dfd068c8a7de"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("d335af28-3fc8-44bb-8f9f-9d8420ce749d"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("e861bd4f-517e-4880-bb3d-26a358c98a69"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("217c4929-b995-4ab6-897c-348f48fe31a1"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("38c95f40-985d-4435-aee9-d863d348f162"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("4a166d72-d16b-4284-ae89-f4877a29a68d"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("63dcf354-2593-453d-8f5f-45d0f396639c"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("d2deb997-1e0b-44db-af11-84ea001ef78f"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("d66e4b47-43ac-433e-89d4-dad453747357"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("3fdcd373-b594-415b-a048-c64d9f9567df"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("8160025e-8e8b-4a15-9084-7ab149cc3eca"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("a10052cd-dc35-4b5e-832d-bced13f6de72"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("af2f7795-9909-4fe0-850c-237ad1bdf11d"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("b629c8c0-9cca-46f6-acd0-ab636fe70491"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("dc47582f-e332-4c99-9019-1f97acdb8688"));

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("46ba3f3d-bb0d-418b-b275-d3c2a539a762"), "Sales Closing" },
                    { new Guid("90f7f41a-c895-4c9d-b151-3fb6f0aabd86"), "Proposal" },
                    { new Guid("94ba0450-a39b-4f6a-a4f5-292792c8c669"), "Fact-Find" },
                    { new Guid("b603a1fe-47ab-410f-9961-b27915aded6f"), "Others" },
                    { new Guid("f191d001-cb19-471d-9363-331711825f0b"), "Presentation" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("4678aac8-0810-46ba-a941-b37779e828f0"), "Others" },
                    { new Guid("58d97bed-0c73-45f5-95eb-f8ff3dcc920f"), "Test Message" },
                    { new Guid("58f47347-35f3-4062-bb71-82a267694c0f"), "Email" },
                    { new Guid("643c6512-5104-4ca7-a039-02f8bf0e9910"), "Instagram" },
                    { new Guid("a4f3a312-a3c6-45d5-8a8e-367153d2b0ac"), "Line" },
                    { new Guid("a9dc8c41-666c-4d43-9d36-a26322f870fe"), "WhatsApp" },
                    { new Guid("c67f7688-c624-4ece-a762-d465e4090fdf"), "Facebook" },
                    { new Guid("e2601bb0-81ef-42c3-a700-0a5d726ce5d0"), "Phone Call" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("184fe740-43e8-4dd0-9152-29c7b2cf85f4"), "Not Read" },
                    { new Guid("2f6a48bd-c73e-461e-8b6d-9718d27b4cfb"), "Simple Response" },
                    { new Guid("647bbac0-b3f6-4744-b124-5b2dd5b9fc46"), "Read but no response" },
                    { new Guid("f19b0b7e-46aa-4fd8-9b08-12a512deab38"), "Good Engagement" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("1193f49d-be8a-4721-a75d-2cc42aac5a65"), "Others" },
                    { new Guid("68f26ff1-f03b-491c-8e53-8172b6def7eb"), "Holiday" },
                    { new Guid("7c64668d-c996-4182-a86f-ccb067bffefd"), "Congratulations" },
                    { new Guid("aabb222b-76a2-432e-ab8b-2f7f8f0aeb8b"), "Anniversary" },
                    { new Guid("b8ac4535-9e75-46d2-9228-5e5602c3bc1e"), "Birthday" },
                    { new Guid("c0ae4de5-6f93-429f-ba5e-dc6a90658f97"), "New Product" },
                    { new Guid("ed0b8343-c65b-4de7-b0ca-64fffe91c414"), "Discount" },
                    { new Guid("ed690734-1bda-4180-8caa-692e20181b05"), "Company News" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("22916c8b-1b19-4045-8977-8089a78e64c0"), "Referral" },
                    { new Guid("38d600e9-cccd-45ff-8b92-597b592b186b"), "Social Media" },
                    { new Guid("75f2b6b5-ff1e-45cc-b98b-f33c0790c7ca"), "Compony-Generated" },
                    { new Guid("788f63ca-11b5-44ec-b796-dbb73e63ad66"), "Friend" },
                    { new Guid("8bbc315c-ec27-446d-bb06-42eb9b87608b"), "Others" },
                    { new Guid("ee9f6d22-24b8-4afd-8341-aa3f10c72ad5"), "Webinar" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("243488a8-f9ce-49d7-935c-1f9e02899017"), "Proposal Generated" },
                    { new Guid("2d419c85-4b2d-4454-b3fb-0485e5620096"), "Met" },
                    { new Guid("584bba83-9d7e-45e5-9faf-c985cbc66d2e"), "Lead is Dead" },
                    { new Guid("970b5c04-567b-4f9d-9e4d-6d9410db3804"), "Application Submitted" },
                    { new Guid("c2f44fda-f681-4919-8146-fc34c140432a"), "Contacted" },
                    { new Guid("d06e04f0-771f-41be-90f0-182ef4654316"), "Policy Issued" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("46ba3f3d-bb0d-418b-b275-d3c2a539a762"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("90f7f41a-c895-4c9d-b151-3fb6f0aabd86"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("94ba0450-a39b-4f6a-a4f5-292792c8c669"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("b603a1fe-47ab-410f-9961-b27915aded6f"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("f191d001-cb19-471d-9363-331711825f0b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("4678aac8-0810-46ba-a941-b37779e828f0"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("58d97bed-0c73-45f5-95eb-f8ff3dcc920f"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("58f47347-35f3-4062-bb71-82a267694c0f"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("643c6512-5104-4ca7-a039-02f8bf0e9910"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("a4f3a312-a3c6-45d5-8a8e-367153d2b0ac"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("a9dc8c41-666c-4d43-9d36-a26322f870fe"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("c67f7688-c624-4ece-a762-d465e4090fdf"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("e2601bb0-81ef-42c3-a700-0a5d726ce5d0"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("184fe740-43e8-4dd0-9152-29c7b2cf85f4"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("2f6a48bd-c73e-461e-8b6d-9718d27b4cfb"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("647bbac0-b3f6-4744-b124-5b2dd5b9fc46"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("f19b0b7e-46aa-4fd8-9b08-12a512deab38"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("1193f49d-be8a-4721-a75d-2cc42aac5a65"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("68f26ff1-f03b-491c-8e53-8172b6def7eb"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("7c64668d-c996-4182-a86f-ccb067bffefd"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("aabb222b-76a2-432e-ab8b-2f7f8f0aeb8b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("b8ac4535-9e75-46d2-9228-5e5602c3bc1e"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("c0ae4de5-6f93-429f-ba5e-dc6a90658f97"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("ed0b8343-c65b-4de7-b0ca-64fffe91c414"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("ed690734-1bda-4180-8caa-692e20181b05"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("22916c8b-1b19-4045-8977-8089a78e64c0"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("38d600e9-cccd-45ff-8b92-597b592b186b"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("75f2b6b5-ff1e-45cc-b98b-f33c0790c7ca"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("788f63ca-11b5-44ec-b796-dbb73e63ad66"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("8bbc315c-ec27-446d-bb06-42eb9b87608b"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("ee9f6d22-24b8-4afd-8341-aa3f10c72ad5"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("243488a8-f9ce-49d7-935c-1f9e02899017"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("2d419c85-4b2d-4454-b3fb-0485e5620096"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("584bba83-9d7e-45e5-9faf-c985cbc66d2e"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("970b5c04-567b-4f9d-9e4d-6d9410db3804"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("c2f44fda-f681-4919-8146-fc34c140432a"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("d06e04f0-771f-41be-90f0-182ef4654316"));

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("1ab2f946-f117-4702-ad14-05150a77243f"), "Sales Closing" },
                    { new Guid("3dbba4ea-3e87-436a-88d4-2bea2faa2e89"), "Proposal" },
                    { new Guid("43b0f213-a447-4f12-980a-b948403fc490"), "Presentation" },
                    { new Guid("4bb4af14-f406-4836-9ff5-07a136a20c31"), "Others" },
                    { new Guid("97b81117-da08-47fe-a24e-60d8f7be34fc"), "Fact-Find" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("47947c54-cbea-4751-bf82-ac43fdbdbf55"), "Facebook" },
                    { new Guid("68bf1f8e-f31d-418e-824c-2f55db4e81e7"), "Instagram" },
                    { new Guid("7dc22be9-52d8-4d83-b1a0-2e01456aa305"), "Email" },
                    { new Guid("895b5fba-8559-4aa2-8a1e-1dfb4d371903"), "Phone Call" },
                    { new Guid("ca67a03e-44b4-4cd0-885c-17e5c2cee30a"), "Line" },
                    { new Guid("cd1d02a3-fcbc-49b6-afb0-0c789ad63035"), "Test Message" },
                    { new Guid("d63e684c-fe71-427b-8620-19f57c9fa95a"), "WhatsApp" },
                    { new Guid("ebf32643-30cd-4173-b9cf-0ec9a2b6c1c3"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("6174d5d8-631f-4078-9330-2d7508f247d5"), "Not Read" },
                    { new Guid("8d906718-db4c-4206-84e5-0153921199e0"), "Read but no response" },
                    { new Guid("d0a08d8c-246f-42ca-a15a-26529aefdc14"), "Good Engagement" },
                    { new Guid("d578ba6c-d51e-4774-8314-9c406bd5d450"), "Simple Response" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("057bb849-c0a0-4d27-8296-4855bf0ab0c3"), "Birthday" },
                    { new Guid("1451297a-93da-47b9-a5eb-67544830726f"), "Congratulations" },
                    { new Guid("1af2cf2f-2bda-45bb-9d86-2e6a49464517"), "Company News" },
                    { new Guid("54c79ced-f46d-4f52-ad58-f4d7bcf9b053"), "Anniversary" },
                    { new Guid("748323cb-aaba-4740-9c25-59cf2e4a5c8d"), "Holiday" },
                    { new Guid("ae75c350-a351-43bb-8c0e-dfd068c8a7de"), "Discount" },
                    { new Guid("d335af28-3fc8-44bb-8f9f-9d8420ce749d"), "Others" },
                    { new Guid("e861bd4f-517e-4880-bb3d-26a358c98a69"), "New Product" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("217c4929-b995-4ab6-897c-348f48fe31a1"), "Webinar" },
                    { new Guid("38c95f40-985d-4435-aee9-d863d348f162"), "Others" },
                    { new Guid("4a166d72-d16b-4284-ae89-f4877a29a68d"), "Referral" },
                    { new Guid("63dcf354-2593-453d-8f5f-45d0f396639c"), "Social Media" },
                    { new Guid("d2deb997-1e0b-44db-af11-84ea001ef78f"), "Compony-Generated" },
                    { new Guid("d66e4b47-43ac-433e-89d4-dad453747357"), "Friend" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("3fdcd373-b594-415b-a048-c64d9f9567df"), "Contacted" },
                    { new Guid("8160025e-8e8b-4a15-9084-7ab149cc3eca"), "Lead is Dead" },
                    { new Guid("a10052cd-dc35-4b5e-832d-bced13f6de72"), "Met" },
                    { new Guid("af2f7795-9909-4fe0-850c-237ad1bdf11d"), "Proposal Generated" },
                    { new Guid("b629c8c0-9cca-46f6-acd0-ab636fe70491"), "Policy Issued" },
                    { new Guid("dc47582f-e332-4c99-9019-1f97acdb8688"), "Application Submitted" }
                });
        }
    }
}
