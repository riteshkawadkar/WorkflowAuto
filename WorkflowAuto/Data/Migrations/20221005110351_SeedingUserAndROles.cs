using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkflowAuto.Data.Migrations
{
    public partial class SeedingUserAndROles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6efb49fb-76fa-4211-9ee7-5423db9f08a0",
                column: "ConcurrencyStamp",
                value: "7f6b771b-6c60-421f-afb6-54c95b824bd9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4194f76-1993-4a8d-8505-58cd21e73279",
                column: "ConcurrencyStamp",
                value: "7dab9f79-10cd-4548-be56-7a66f8583f9f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4d579d-2758-48c4-848a-19afa675662f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b020a28-de59-4584-9c42-d46ca84cf5d3", "AQAAAAEAACcQAAAAEMWRkHoJkEbbwSWNob9x8904IveTYWpOs3D2mTxjwY46tX3OOVdNfpqnErPef9c4Tw==", "de1df273-de63-4b31-a18e-964018337a94" });
        }
    }
}
