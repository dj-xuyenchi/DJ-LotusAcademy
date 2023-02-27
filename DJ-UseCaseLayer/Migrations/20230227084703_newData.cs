using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJUseCaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class newData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttendanceSlotId",
                table: "attendance",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateTime",
                table: "attendance",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "attendanceSlots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendanceSlotCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttendanceSlotName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attendanceSlots", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_attendance_AttendanceSlotId",
                table: "attendance",
                column: "AttendanceSlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_attendance_attendanceSlots_AttendanceSlotId",
                table: "attendance",
                column: "AttendanceSlotId",
                principalTable: "attendanceSlots",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attendance_attendanceSlots_AttendanceSlotId",
                table: "attendance");

            migrationBuilder.DropTable(
                name: "attendanceSlots");

            migrationBuilder.DropIndex(
                name: "IX_attendance_AttendanceSlotId",
                table: "attendance");

            migrationBuilder.DropColumn(
                name: "AttendanceSlotId",
                table: "attendance");

            migrationBuilder.DropColumn(
                name: "CreateDateTime",
                table: "attendance");
        }
    }
}
