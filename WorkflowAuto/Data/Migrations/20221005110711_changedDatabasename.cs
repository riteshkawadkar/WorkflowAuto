using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkflowAuto.Data.Migrations
{
    public partial class changedDatabasename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6efb49fb-76fa-4211-9ee7-5423db9f08a0",
                column: "ConcurrencyStamp",
                value: "17939ce7-ea46-45e7-bbdb-067b024aa154");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4194f76-1993-4a8d-8505-58cd21e73279",
                column: "ConcurrencyStamp",
                value: "887aba26-23cc-46cc-8b10-cede402e6448");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4d579d-2758-48c4-848a-19afa675662f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bfc4c8a-14da-4480-83c5-6e56e98b929a", "AQAAAAEAACcQAAAAENa5vrGSlSeBVwjfoGUOHXJZANCLSDpIqYzFtQsVKTH2xDyTLO0K0dgjUkusFkuKYg==", "a84f1d94-300f-4939-8421-2339f0ee7bb2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6efb49fb-76fa-4211-9ee7-5423db9f08a0",
                column: "ConcurrencyStamp",
                value: "0baea2ba-1711-4f97-b328-b2ae562418fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4194f76-1993-4a8d-8505-58cd21e73279",
                column: "ConcurrencyStamp",
                value: "1fab4896-a498-43e3-9dda-e513857b54b9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4d579d-2758-48c4-848a-19afa675662f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adae1de2-4b8e-443c-96c4-41eb12f4ada7", "AQAAAAEAACcQAAAAEGWHWS7j35lcm6QVTof73DmTWRVW+f05ER+4O35V2n+1uQEJ3qdfgJIJSpSzZxknEg==", "d723312a-0164-44ca-9b16-7b3499e1a4e1" });
        }
    }
}
