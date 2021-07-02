using Microsoft.EntityFrameworkCore.Migrations;

namespace Kamban.Migrations
{
    public partial class Commancerladouchefroide : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ScrumTasks",
                columns: table => new
                {
                    ScrumTaskId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScrumTasks", x => x.ScrumTaskId);
                    table.ForeignKey(
                        name: "FK_ScrumTasks_Users_ScrumTaskId",
                        column: x => x.ScrumTaskId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Name" },
                values: new object[,]
                {
                    { 1, "Timothy" },
                    { 2, "Francis" },
                    { 3, "Ruben" },
                    { 4, "Mauro" },
                    { 5, "Jarno" }
                });

            migrationBuilder.InsertData(
                table: "ScrumTasks",
                columns: new[] { "ScrumTaskId", "Category", "Description", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 0, "Used to develop computer programs, web services, and mobile applications. ", "Microsoft Visual Studio", 2 },
                    { 2, 2, "Gaming console released in 2001", "Xbox 360", 1 },
                    { 3, 1, "The launch of Microsoft Word, followed by Excel, and Powerpoint in the mid-1980s ", "Microsoft Office", 3 },
                    { 4, 0, "The creation and release of Internet Explorer in 1995", "Internet Explorer", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScrumTasks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
