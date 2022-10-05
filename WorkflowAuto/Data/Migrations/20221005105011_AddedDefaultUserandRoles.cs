using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkflowAuto.Data.Migrations
{
    public partial class AddedDefaultUserandRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6efb49fb-76fa-4211-9ee7-5423db9f08a0", "c3f77b7a-65a0-4cc6-a9cc-fab31a4a547f", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4194f76-1993-4a8d-8505-58cd21e73279", "5b5f04fa-f7b6-4da3-8bcc-43d9564fb5e7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0c4d579d-2758-48c4-848a-19afa675662f", 0, "45fa4e62-b821-4409-b6a8-5411e58ff760", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEMCZxiWtTqyOjUTt5eiSG7Mw81yVE50FTP2iwKLxGj9n2v26X2Y7dnAhgPCrhRd0FA==", null, false, "07a48724-34bc-4126-9c45-1b2c57210401", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6efb49fb-76fa-4211-9ee7-5423db9f08a0", "0c4d579d-2758-48c4-848a-19afa675662f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4194f76-1993-4a8d-8505-58cd21e73279");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6efb49fb-76fa-4211-9ee7-5423db9f08a0", "0c4d579d-2758-48c4-848a-19afa675662f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6efb49fb-76fa-4211-9ee7-5423db9f08a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4d579d-2758-48c4-848a-19afa675662f");
        }
    }
}
