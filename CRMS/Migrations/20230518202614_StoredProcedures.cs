using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMS.Migrations
{
    public partial class StoredProcedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) 
        {
            var sp = @"CREATE OR ALTER PROCEDURE GetAppointmentsByDateAndUser
                        @CurrentDate DATE,
                        @UserGUID UNIQUEIDENTIFIER
                    AS
                    BEGIN
                       SELECT A.*,CONCAT(C.FirstName, ' ', C.LastName) AS ProspectFullName
                        FROM Appointments A
                        LEFT JOIN Contacts C ON A.ContactId = C.Contact_Id
                        WHERE CONVERT(DATE, A.Appointment_DateTime) = @CurrentDate
                            AND A.CreatedBy = @UserGUID
                            AND A.SchedStatus = 0
                    END";

            migrationBuilder.Sql(sp);
        }
        protected override void Down(MigrationBuilder migrationBuilder) 
        {
           
        }
       
    }
}
