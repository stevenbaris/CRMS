using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductAPI.Migrations
{
    public partial class modifiedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9285fe50-1d1a-4091-9d3f-1f217de6fb81"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("af9103e0-8686-4ee9-84d6-47b3a48a8dc2"));

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "Product_Id");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProductDescription",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Benefits",
                table: "Products",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductName");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityAddress", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("9c9b2ebe-846c-401e-b519-2b349a776c4a"), 0, "Makati", "d217e68b-9aa0-4ed6-8f64-d5bffe85e46d", new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEAPhEQg4qKNuoGxptxyFSIuDmbnm+M+GDYuLwL2N9TUycpn4pYwV08hPJmHHhNINMQ==", null, true, "", false, "su@crms.com" },
                    { new Guid("caa56575-59ca-4952-98af-ac77afcc0352"), 0, "Makati", "d31113c4-1508-44a4-83ac-c76d7fa17bf1", new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEEuCECrpsAgGMoahp2aeBUhoRg+ivgti5AzAFEzghYMGdEIXW0JFtRdcN+kY2SQ3nw==", null, true, "", false, "user@crms.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductName",
                keyValue: "CL ER Care",
                columns: new[] { "CreateDate", "Product_Id", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 17, 21, 58, 20, 623, DateTimeKind.Local).AddTicks(2986), new Guid("b040bbcb-8518-4f66-ab04-d52f6f051121"), new DateTime(2023, 2, 17, 21, 58, 20, 623, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductName",
                keyValue: "CL Health Care",
                columns: new[] { "CreateDate", "Product_Id", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 17, 21, 58, 20, 623, DateTimeKind.Local).AddTicks(2929), new Guid("0640008e-b03b-4369-a1dd-0128f3641afc"), new DateTime(2023, 2, 17, 21, 58, 20, 623, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductName",
                keyValue: "CL MicroEnterpriseProtek",
                columns: new[] { "CreateDate", "Product_Id", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 17, 21, 58, 20, 623, DateTimeKind.Local).AddTicks(2925), new Guid("cf0fb557-0d28-4ced-9453-50ee5b3bbd15"), new DateTime(2023, 2, 17, 21, 58, 20, 623, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductName",
                keyValue: "CL Personal Accident Basic",
                columns: new[] { "CreateDate", "Product_Id", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 17, 21, 58, 20, 623, DateTimeKind.Local).AddTicks(2983), new Guid("5acf9424-fb73-4436-b9b9-34128bb32e1f"), new DateTime(2023, 2, 17, 21, 58, 20, 623, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductName",
                keyValue: "CL Personal Accident Nano",
                columns: new[] { "CreateDate", "Product_Id", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 17, 21, 58, 20, 623, DateTimeKind.Local).AddTicks(2890), new Guid("29f56f46-003a-4151-96bc-2a1f3728f17a"), new DateTime(2023, 2, 17, 21, 58, 20, 623, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductName",
                keyValue: "CL Personal Accident Nano Plus",
                columns: new[] { "CreateDate", "Product_Id", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 17, 21, 58, 20, 623, DateTimeKind.Local).AddTicks(2923), new Guid("45709e63-f807-49ab-a330-7162225ce3a4"), new DateTime(2023, 2, 17, 21, 58, 20, 623, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductName",
                keyValue: "ProtectMAX",
                columns: new[] { "CreateDate", "Product_Id", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 17, 21, 58, 20, 623, DateTimeKind.Local).AddTicks(2927), new Guid("cae33538-8b1a-4da2-b7e0-157d2f180b2b"), new DateTime(2023, 2, 17, 21, 58, 20, 623, DateTimeKind.Local).AddTicks(2927) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9c9b2ebe-846c-401e-b519-2b349a776c4a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("caa56575-59ca-4952-98af-ac77afcc0352"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductName",
                keyValue: "CL ER Care");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductName",
                keyValue: "CL Health Care");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductName",
                keyValue: "CL MicroEnterpriseProtek");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductName",
                keyValue: "CL Personal Accident Basic");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductName",
                keyValue: "CL Personal Accident Nano");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductName",
                keyValue: "CL Personal Accident Nano Plus");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductName",
                keyValue: "ProtectMAX");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Product_Id",
                table: "Products",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "ProductDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Benefits",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityAddress", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("9285fe50-1d1a-4091-9d3f-1f217de6fb81"), 0, "Makati", "d58f2201-afc3-4638-a5e8-3e1215a2b71f", new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "user@crms.com", true, "Regular", "User", true, null, "USER@CRMS.COM", "USER@CRMS.COM", "AQAAAAEAACcQAAAAEOdE/iY2pIs20fqmAIaHJtzXr0TYwAMfQzoCUyMy8b7aMZ5QQBS7sdj8ZNIhuX6zwg==", null, true, "", false, "user@crms.com" },
                    { new Guid("af9103e0-8686-4ee9-84d6-47b3a48a8dc2"), 0, "Makati", "5951e20d-86ce-41a1-931c-d58ebd2dc8c9", new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "su@crms.com", true, "Super", "User", true, null, "SU@CRMS.COM", "SU@CRMS.COM", "AQAAAAEAACcQAAAAEPuBRyJXLl2yp6zH6OWP/mBI8VVVHi1jNwmq6WDWgiIb6amZi05ng5ZvBJzSC+IgIw==", null, true, "", false, "su@crms.com" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Benefits", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { new Guid("2f3a5b1d-0466-4744-b0b5-934d2ba0695a"), "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Cash Assistance Due to Food Poisoning", "CL Personal Accident Nano Insurance covers loss for Accidental Death, Disablement, or Dismemberment, and Cash Assistance due to Food Poisoning.", "CL Personal Accident Nano" },
                    { new Guid("2f96372a-0268-4723-ad73-0b6da8f16a31"), "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Accidental Burial Benefit, Cash Assistance Benefit, Fire Cash Assistance", "CL Personal Accident Nano Plus Insurance covers Accidental Death, Disablement, or Dismemberment, Accident Medical Reimbursement, Accident Burial Benefit, Cash Assistance benefit, and Fire Cash Assistance.", "CL Personal Accident Nano Plus" },
                    { new Guid("6e563dad-2738-474c-b3fd-e9ce0869bfcb"), "The Policy is Effective for one (1) year from the date of issuance or after payment of claim,whichever comes first.", "covers the medical expenses incurred within a year from the date of issuance or purchase by the InsuredPerson for the treatment of an eligible emergency condition, availment of which caneither be as an Out-Patient in the Emergency Room Department or as an In-Patient of aHospital via cash assistance.", "CL ER Care" },
                    { new Guid("716740a0-5fb9-4eab-bf80-75e9b89ac143"), "Death Benefit, Accident or Sickness Emergency Cash Assistance, Accidental Dismemberment and/or Disablement, Murder and Unprovoked Assault and Residential Fire Reconstruction cash assistance", "For as low as P50, each certificate is valid for four (4) months from the date of issuance and can be availed up to a maximum of 5 certificates per insured.", "ProtectMAX" },
                    { new Guid("7f6914ca-38fb-464d-943e-89c2fbeda31a"), "Accidental Death, Accidental Dismemberment and/or Disablement", "Covers Accidental Death and Accidental Dismemberment and/or Disablement Benefit.", "CL Personal Accident Basic" },
                    { new Guid("c7d93b44-85ff-4f93-b803-53707ce799b5"), "Earthquake, Typhoon, Flood, Windstorm, Volcanic Eruption and other Acts of Nature, Extended Coverage, BOWTAP, BWD, SL and other water related damages, Vandalism/Spontaneous Combustion, All Other Losses", "CL MicroEnterpriseProtekis a Property Insurance Program specially designed for Cebuana Lhuillier clients. It covers loss “ALL Risks” of physical loss, destruction of or damage to the property of the insured and wholly attributable to any sudden and unforeseen cause, except as hereinafter excluded, occurring during the currency of the policy.", "CL MicroEnterpriseProtek" },
                    { new Guid("f7aad4cf-4a57-4c7a-a4e3-ab42fe2bba8c"), "24/7 Call-a-doc, OP ER One Time use (All causes), Daily Hospital Income Benefit (All Causes)", "An Individual Personal Accident Insurance specifically designed for Cebuana Lhuillier clients.It covers Accidental Death and Disability (AD&D), Double Indemnity, 24/7 Call-a-doc, OP ER One Time use and Daily Hospital Income Benefit.", "CL Health Care" }
                });
        }
    }
}
