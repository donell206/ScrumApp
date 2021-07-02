using Microsoft.EntityFrameworkCore.Migrations;

namespace Kamban.Migrations
{
    public partial class Commancerladouchefroidetryt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScrumTasks_Users_ScrumTaskId",
                table: "ScrumTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScrumTasks",
                table: "ScrumTasks");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "UsersVendredi");

            migrationBuilder.RenameTable(
                name: "ScrumTasks",
                newName: "VendrediScrumTasks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersVendredi",
                table: "UsersVendredi",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendrediScrumTasks",
                table: "VendrediScrumTasks",
                column: "ScrumTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_VendrediScrumTasks_UsersVendredi_ScrumTaskId",
                table: "VendrediScrumTasks",
                column: "ScrumTaskId",
                principalTable: "UsersVendredi",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendrediScrumTasks_UsersVendredi_ScrumTaskId",
                table: "VendrediScrumTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VendrediScrumTasks",
                table: "VendrediScrumTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersVendredi",
                table: "UsersVendredi");

            migrationBuilder.RenameTable(
                name: "VendrediScrumTasks",
                newName: "ScrumTasks");

            migrationBuilder.RenameTable(
                name: "UsersVendredi",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScrumTasks",
                table: "ScrumTasks",
                column: "ScrumTaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScrumTasks_Users_ScrumTaskId",
                table: "ScrumTasks",
                column: "ScrumTaskId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
