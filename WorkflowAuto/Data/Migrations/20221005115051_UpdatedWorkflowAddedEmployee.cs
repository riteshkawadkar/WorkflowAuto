using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkflowAuto.Data.Migrations
{
    public partial class UpdatedWorkflowAddedEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeID",
                table: "Workflows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6efb49fb-76fa-4211-9ee7-5423db9f08a0",
                column: "ConcurrencyStamp",
                value: "5a2d6a92-6ad5-49ab-8a20-fee64fd55856");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4194f76-1993-4a8d-8505-58cd21e73279",
                column: "ConcurrencyStamp",
                value: "dbd28e03-a29f-40dc-9463-8590d067557d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4d579d-2758-48c4-848a-19afa675662f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6906689-a2af-4f69-acd0-2154b2be6918", "AQAAAAEAACcQAAAAEPax5vZ9EgqBakRauJp9AruZqNHbl0bdepGewEk9iUJoCHvMCFi48SMDXvdyxzk94w==", "c5a95fd5-a19c-4ffe-a93b-ae204950477c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Workflows");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6efb49fb-76fa-4211-9ee7-5423db9f08a0",
                column: "ConcurrencyStamp",
                value: "67710ce7-7d13-4ba2-88e2-e0739fb88e10");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4194f76-1993-4a8d-8505-58cd21e73279",
                column: "ConcurrencyStamp",
                value: "d360dd6e-9779-402a-9aa1-3f455c8e9659");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4d579d-2758-48c4-848a-19afa675662f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e00e792d-252b-4163-91a2-8e23b87732b3", "AQAAAAEAACcQAAAAEHw5Rue8AWgwiU506D9T6MiW/naw2Jz5XYbPOHuhC+Qm7LA+xkj0PHZw9VKsr9fHiw==", "a170227f-4d45-4196-90f8-e701d71d5437" });
        }
    }
}
