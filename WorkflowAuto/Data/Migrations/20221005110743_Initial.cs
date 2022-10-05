using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkflowAuto.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6efb49fb-76fa-4211-9ee7-5423db9f08a0",
                column: "ConcurrencyStamp",
                value: "a642939a-b688-4ff0-b8e8-a994937d268d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4194f76-1993-4a8d-8505-58cd21e73279",
                column: "ConcurrencyStamp",
                value: "1face1ec-2ba5-47af-827f-7456b76e5ccd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4d579d-2758-48c4-848a-19afa675662f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a0d1bcb-a467-456a-9ea9-f7f35e1d1fe4", "AQAAAAEAACcQAAAAEHMe6roptPJyPfEqgmAjyjwJQQDO4kZuCeQxB+TIPgrPw7GO9kPzX+auLElEQ8evJg==", "5bd41370-556a-4ca7-b715-5fe73ed9fb6f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
