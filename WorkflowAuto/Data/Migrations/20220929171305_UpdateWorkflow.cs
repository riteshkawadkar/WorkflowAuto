using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkflowAuto.Data.Migrations
{
    public partial class UpdateWorkflow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workflows_WorkflowTypes_WorkflowTypeId",
                table: "Workflows");

            migrationBuilder.DropTable(
                name: "WorkflowTypes");

            migrationBuilder.DropIndex(
                name: "IX_Workflows_WorkflowTypeId",
                table: "Workflows");

            migrationBuilder.RenameColumn(
                name: "WorkflowTypeId",
                table: "Workflows",
                newName: "WorkflowType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkflowType",
                table: "Workflows",
                newName: "WorkflowTypeId");

            migrationBuilder.CreateTable(
                name: "WorkflowTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workflows_WorkflowTypeId",
                table: "Workflows",
                column: "WorkflowTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workflows_WorkflowTypes_WorkflowTypeId",
                table: "Workflows",
                column: "WorkflowTypeId",
                principalTable: "WorkflowTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
