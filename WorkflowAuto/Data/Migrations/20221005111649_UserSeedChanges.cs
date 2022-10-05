using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkflowAuto.Data.Migrations
{
    public partial class UserSeedChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e00e792d-252b-4163-91a2-8e23b87732b3", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHw5Rue8AWgwiU506D9T6MiW/naw2Jz5XYbPOHuhC+Qm7LA+xkj0PHZw9VKsr9fHiw==", "a170227f-4d45-4196-90f8-e701d71d5437", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0a0d1bcb-a467-456a-9ea9-f7f35e1d1fe4", null, "AQAAAAEAACcQAAAAEHMe6roptPJyPfEqgmAjyjwJQQDO4kZuCeQxB+TIPgrPw7GO9kPzX+auLElEQ8evJg==", "5bd41370-556a-4ca7-b715-5fe73ed9fb6f", null });
        }
    }
}
