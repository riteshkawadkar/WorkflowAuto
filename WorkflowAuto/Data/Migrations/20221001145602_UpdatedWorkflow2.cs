using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkflowAuto.Data.Migrations
{
    public partial class UpdatedWorkflow2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workflows_Applications_ApplicationID",
                table: "Workflows");

            migrationBuilder.RenameColumn(
                name: "ApplicationID",
                table: "Workflows",
                newName: "ApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Workflows_ApplicationID",
                table: "Workflows",
                newName: "IX_Workflows_ApplicationId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Workflows_Applications_ApplicationId",
                table: "Workflows",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Workflows_WorkflowId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Workflows_Applications_ApplicationId",
                table: "Workflows");

            migrationBuilder.DropIndex(
                name: "IX_Applications_WorkflowId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "WorkflowId",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "ApplicationId",
                table: "Workflows",
                newName: "ApplicationID");

            migrationBuilder.RenameIndex(
                name: "IX_Workflows_ApplicationId",
                table: "Workflows",
                newName: "IX_Workflows_ApplicationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Workflows_Applications_ApplicationID",
                table: "Workflows",
                column: "ApplicationID",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
