﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentRecordsApp.Migrations
{
    public partial class checkchanges9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "341743f0-asd2-42de-afbf-59kmkkmk72cf6", "341743f0-asd2-42de-afbf-59kmkkmk72cf6", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserID", "UserName" },
                values: new object[] { "02174cf0-9412-4cfe-afbf-59f706d72cf6", 0, null, "04484198-567b-4e0f-93f9-778591af9879", "admin@gmail.com", true, "Raquel", "Sorila", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEEXvj4HDNFuXn4B2w0suAsDOGEoaykEtqSVJa7xE3m6Kf2reoj3Q7FFc0JHW6A/rzQ==", null, false, "0a50d519-3489-4247-9c86-9ed41a547289", false, "0", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "341743f0-asd2-42de-afbf-59kmkkmk72cf6", "02174cf0-9412-4cfe-afbf-59f706d72cf6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "341743f0-asd2-42de-afbf-59kmkkmk72cf6", "02174cf0-9412-4cfe-afbf-59f706d72cf6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6");
        }
    }
}
