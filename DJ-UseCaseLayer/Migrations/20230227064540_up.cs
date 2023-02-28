using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJUseCaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class up : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttendanceSlotId",
                table: "attendance",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AttendanceSlot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendanceSlotCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttendanceSlotName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceSlot", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_attendance_AttendanceSlotId",
                table: "attendance",
                column: "AttendanceSlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_attendance_AttendanceSlot_AttendanceSlotId",
                table: "attendance",
                column: "AttendanceSlotId",
                principalTable: "AttendanceSlot",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attendance_AttendanceSlot_AttendanceSlotId",
                table: "attendance");

            migrationBuilder.DropTable(
                name: "AttendanceSlot");

            migrationBuilder.DropIndex(
                name: "IX_attendance_AttendanceSlotId",
                table: "attendance");

            migrationBuilder.DropColumn(
                name: "AttendanceSlotId",
                table: "attendance");
        }
    }
}
