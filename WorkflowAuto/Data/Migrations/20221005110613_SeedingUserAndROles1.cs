using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkflowAuto.Data.Migrations
{
    public partial class SeedingUserAndROles1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6efb49fb-76fa-4211-9ee7-5423db9f08a0",
                column: "ConcurrencyStamp",
                value: "6927de91-328a-44ea-8489-b0a37d4f207d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4194f76-1993-4a8d-8505-58cd21e73279",
                column: "ConcurrencyStamp",
                value: "17a826d1-cdc3-46ab-b730-500bc110ffd4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4d579d-2758-48c4-848a-19afa675662f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c4bdad9-b0cc-483d-ad47-68f9c79d7385", "AQAAAAEAACcQAAAAEBQ4YDz/lQMMFvsiGykM1Yib4qUI/+oJj6ecguXKZQAo8I71Ia2vSEk2HEhfNSawtw==", "116993da-9ecb-433c-a116-5533fa5fd8fb" });
        }
    }
}
