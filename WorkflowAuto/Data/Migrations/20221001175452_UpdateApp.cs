using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkflowAuto.Data.Migrations
{
    public partial class UpdateApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Workflows_WorkflowId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_WorkflowId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "WorkflowId",
                table: "Applications");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkflowId",
                table: "Applications",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Applications_WorkflowId",
                table: "Applications",
                column: "WorkflowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Workflows_WorkflowId",
                table: "Applications",
                column: "WorkflowId",
                principalTable: "Workflows",
                principalColumn: "Id");
        }
    }
}
