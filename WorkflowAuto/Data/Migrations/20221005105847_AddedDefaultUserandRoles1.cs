using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkflowAuto.Data.Migrations
{
    public partial class AddedDefaultUserandRoles1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6efb49fb-76fa-4211-9ee7-5423db9f08a0",
                column: "ConcurrencyStamp",
                value: "c3f77b7a-65a0-4cc6-a9cc-fab31a4a547f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4194f76-1993-4a8d-8505-58cd21e73279",
                column: "ConcurrencyStamp",
                value: "5b5f04fa-f7b6-4da3-8bcc-43d9564fb5e7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4d579d-2758-48c4-848a-19afa675662f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45fa4e62-b821-4409-b6a8-5411e58ff760", "AQAAAAEAACcQAAAAEMCZxiWtTqyOjUTt5eiSG7Mw81yVE50FTP2iwKLxGj9n2v26X2Y7dnAhgPCrhRd0FA==", "07a48724-34bc-4126-9c45-1b2c57210401" });
        }
    }
}
