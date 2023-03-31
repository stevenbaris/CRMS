using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class addingidentitytables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("20921d0a-a717-4a85-b4a5-b26c7f84f9c7"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("4ec7dec0-24f1-4d29-827f-0e03e8d405de"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("953c53b9-325b-4ac8-9c82-325226b030c1"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("a6b740f4-faab-4f36-a6e2-72ebe572a9e5"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("cd7a22ce-0632-4b13-a3e0-eb502de8faa3"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("f992ea21-08f3-4c2f-bb98-91946bc15da2"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("2348a0ac-7197-481d-96c4-64b28f3ffd9b"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("2643073b-3b97-46c5-8218-1db223193676"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("802f018e-6c60-4d4b-b045-ee561a2c38a6"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("8d4be98a-1d59-4866-9528-3bbbd94d6257"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("99c01814-4d9a-4a57-8c0e-96e36e865c88"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("ed6dc4a7-c020-441e-8a89-57c208e14a65"));

            migrationBuilder.InsertData(
                table: "APPOINTMENT_PURPOSES",
                columns: new[] { "Purpose_Id", "PurposeName" },
                values: new object[,]
                {
                    { new Guid("2107d263-f6a6-409b-b9d9-a034da509e97"), "Presentation" },
                    { new Guid("4b450562-ccd8-44ef-b28c-77ce2e1c9a7c"), "Proposal" },
                    { new Guid("61456991-8576-4f1a-a753-139940610a5e"), "Fact-Find" },
                    { new Guid("a6051811-1ce8-423e-9b69-b37c742295ec"), "Others" },
                    { new Guid("ac558199-bf88-4cd2-99ed-839231cc8689"), "Sales Closing" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                columns: new[] { "CommunicationMethod_Id", "CommunicationMethodName" },
                values: new object[,]
                {
                    { new Guid("09e0eeb2-8aba-4b2c-8f55-4889f0f1973b"), "Others" },
                    { new Guid("4cf975d3-2698-453d-818b-3017752da0a0"), "Instagram" },
                    { new Guid("7ff23b6d-1ebd-4bc9-996c-b6df7ba9852b"), "Facebook" },
                    { new Guid("97bb2f0e-5a40-4443-8460-c6090d9fd461"), "Email" },
                    { new Guid("ad0aaebf-9815-4c8c-be7d-fbf15d79f27a"), "WhatsApp" },
                    { new Guid("b8c4c8d5-4cc2-4bff-86c1-b4f3c9c52f1b"), "Phone Call" },
                    { new Guid("c32854ad-eef8-4841-93ab-5e842ad2fb19"), "Test Message" },
                    { new Guid("dffce4c9-3b0c-4b13-b05a-b862a35c7142"), "Line" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_EFFECTIVITY",
                columns: new[] { "Effectivity_Id", "Effectivity_Name" },
                values: new object[,]
                {
                    { new Guid("9a6e751c-5f50-4747-b80b-60d8cfb98144"), "Read but no response" },
                    { new Guid("d4914ea9-9ed2-4e0c-957e-a7d5380a7e38"), "Not Read" },
                    { new Guid("df49f373-e988-4ce1-b304-abcc8bcc5ed7"), "Good Engagement" },
                    { new Guid("fe8afbb6-20ea-484a-919f-9878a48800a3"), "Simple Response" }
                });

            migrationBuilder.InsertData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                columns: new[] { "EType_Id", "EngagementName" },
                values: new object[,]
                {
                    { new Guid("18fd6b9e-8331-4e9a-a400-559754b662f7"), "Company News" },
                    { new Guid("1f1d1c14-50c0-402d-b445-a07531a05007"), "Others" },
                    { new Guid("4ae1f267-2b69-42f9-8ed4-474bf85e7a0a"), "Congratulations" },
                    { new Guid("5166f386-c8e6-4c93-8559-d56ef453333c"), "Anniversary" },
                    { new Guid("b74af64b-e725-498f-98a0-bec3c50360ef"), "Discount" },
                    { new Guid("ca2f11d3-bdf6-4b4f-afb6-dff9136e8119"), "Birthday" },
                    { new Guid("e78da97e-8db3-488a-817d-e96681f60dc0"), "New Product" },
                    { new Guid("ecabb29a-28d9-4414-859b-c1f9cd3a0f1d"), "Holiday" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_SOURCES",
                columns: new[] { "Source_Id", "SourceName" },
                values: new object[,]
                {
                    { new Guid("6911a4f7-64c7-4a4a-b966-9323f5b73ad2"), "Webinar" },
                    { new Guid("78ca56fd-c25c-49dc-b74c-3881e4309b7f"), "Compony-Generated" },
                    { new Guid("7b578a2b-1681-4018-aaf8-ddf78b6e5749"), "Others" },
                    { new Guid("937f5772-6ce1-4231-ab98-b38de56f3b0b"), "Social Media" },
                    { new Guid("9ab32434-ef92-45e1-a08e-fea904160b26"), "Friend" },
                    { new Guid("dc8ef401-a5c3-45ef-bc79-9a13d98e520b"), "Referral" }
                });

            migrationBuilder.InsertData(
                table: "LEADS_STATUSES",
                columns: new[] { "LeadStatus_Id", "LeadStatusName" },
                values: new object[,]
                {
                    { new Guid("05d4f04c-eba1-4b7f-ad97-c8196c665431"), "Application Submitted" },
                    { new Guid("2cd79579-5b43-496e-8039-d8464dc2a6de"), "Contacted" },
                    { new Guid("53ca32fd-d16a-4852-9abf-ccfb0b8b4793"), "Lead is Dead" },
                    { new Guid("887658a8-d10e-427f-a676-da6882f0ae01"), "Proposal Generated" },
                    { new Guid("a3745347-03a2-4e5a-b899-7798fd2e9a69"), "Policy Issued" },
                    { new Guid("f515d52d-b404-45e6-ba5b-67b81ed17b9e"), "Met" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("2107d263-f6a6-409b-b9d9-a034da509e97"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("4b450562-ccd8-44ef-b28c-77ce2e1c9a7c"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("61456991-8576-4f1a-a753-139940610a5e"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("a6051811-1ce8-423e-9b69-b37c742295ec"));

            migrationBuilder.DeleteData(
                table: "APPOINTMENT_PURPOSES",
                keyColumn: "Purpose_Id",
                keyValue: new Guid("ac558199-bf88-4cd2-99ed-839231cc8689"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("09e0eeb2-8aba-4b2c-8f55-4889f0f1973b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("4cf975d3-2698-453d-818b-3017752da0a0"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("7ff23b6d-1ebd-4bc9-996c-b6df7ba9852b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("97bb2f0e-5a40-4443-8460-c6090d9fd461"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("ad0aaebf-9815-4c8c-be7d-fbf15d79f27a"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("b8c4c8d5-4cc2-4bff-86c1-b4f3c9c52f1b"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("c32854ad-eef8-4841-93ab-5e842ad2fb19"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_COMMUNICATION METHODS",
                keyColumn: "CommunicationMethod_Id",
                keyValue: new Guid("dffce4c9-3b0c-4b13-b05a-b862a35c7142"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("9a6e751c-5f50-4747-b80b-60d8cfb98144"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("d4914ea9-9ed2-4e0c-957e-a7d5380a7e38"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("df49f373-e988-4ce1-b304-abcc8bcc5ed7"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_EFFECTIVITY",
                keyColumn: "Effectivity_Id",
                keyValue: new Guid("fe8afbb6-20ea-484a-919f-9878a48800a3"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("18fd6b9e-8331-4e9a-a400-559754b662f7"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("1f1d1c14-50c0-402d-b445-a07531a05007"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("4ae1f267-2b69-42f9-8ed4-474bf85e7a0a"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("5166f386-c8e6-4c93-8559-d56ef453333c"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("b74af64b-e725-498f-98a0-bec3c50360ef"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("ca2f11d3-bdf6-4b4f-afb6-dff9136e8119"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("e78da97e-8db3-488a-817d-e96681f60dc0"));

            migrationBuilder.DeleteData(
                table: "ENGAGEMENT_ENGAGEMENT-TYPES",
                keyColumn: "EType_Id",
                keyValue: new Guid("ecabb29a-28d9-4414-859b-c1f9cd3a0f1d"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("6911a4f7-64c7-4a4a-b966-9323f5b73ad2"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("78ca56fd-c25c-49dc-b74c-3881e4309b7f"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("7b578a2b-1681-4018-aaf8-ddf78b6e5749"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("937f5772-6ce1-4231-ab98-b38de56f3b0b"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("9ab32434-ef92-45e1-a08e-fea904160b26"));

            migrationBuilder.DeleteData(
                table: "LEADS_SOURCES",
                keyColumn: "Source_Id",
                keyValue: new Guid("dc8ef401-a5c3-45ef-bc79-9a13d98e520b"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("05d4f04c-eba1-4b7f-ad97-c8196c665431"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("2cd79579-5b43-496e-8039-d8464dc2a6de"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("53ca32fd-d16a-4852-9abf-ccfb0b8b4793"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("887658a8-d10e-427f-a676-da6882f0ae01"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("a3745347-03a2-4e5a-b899-7798fd2e9a69"));

            migrationBuilder.DeleteData(
                table: "LEADS_STATUSES",
                keyColumn: "LeadStatus_Id",
                keyValue: new Guid("f515d52d-b404-45e6-ba5b-67b81ed17b9e"));

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
    }
}
