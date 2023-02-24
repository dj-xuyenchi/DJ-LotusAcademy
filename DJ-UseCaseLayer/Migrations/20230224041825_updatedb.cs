using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJUseCaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class updatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FacebookUrl",
                table: "studentLAs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentDatalogId",
                table: "studentLAs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "StudentLAAvatar",
                table: "studentLAs",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZaloUrl",
                table: "studentLAs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentDatalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentDatalogCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDatalogName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDatalog", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_StudentDatalogId",
                table: "studentLAs",
                column: "StudentDatalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_studentLAs_StudentDatalog_StudentDatalogId",
                table: "studentLAs",
                column: "StudentDatalogId",
                principalTable: "StudentDatalog",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentLAs_StudentDatalog_StudentDatalogId",
                table: "studentLAs");

            migrationBuilder.DropTable(
                name: "StudentDatalog");

            migrationBuilder.DropIndex(
                name: "IX_studentLAs_StudentDatalogId",
                table: "studentLAs");

            migrationBuilder.DropColumn(
                name: "FacebookUrl",
                table: "studentLAs");

            migrationBuilder.DropColumn(
                name: "StudentDatalogId",
                table: "studentLAs");

            migrationBuilder.DropColumn(
                name: "StudentLAAvatar",
                table: "studentLAs");

            migrationBuilder.DropColumn(
                name: "ZaloUrl",
                table: "studentLAs");
        }
    }
}
