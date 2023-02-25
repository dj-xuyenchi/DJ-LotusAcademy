using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJUseCaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class createtblreview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "administrative_regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nameen = table.Column<string>(name: "name_en", type: "nvarchar(max)", nullable: true),
                    codename = table.Column<string>(name: "code_name", type: "nvarchar(max)", nullable: true),
                    codenameen = table.Column<string>(name: "code_name_en", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administrative_regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "administrative_units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullname = table.Column<string>(name: "full_name", type: "nvarchar(max)", nullable: true),
                    fullnameen = table.Column<string>(name: "full_name_en", type: "nvarchar(max)", nullable: true),
                    shortname = table.Column<string>(name: "short_name", type: "nvarchar(max)", nullable: true),
                    shortnameen = table.Column<string>(name: "short_name_en", type: "nvarchar(max)", nullable: true),
                    codename = table.Column<string>(name: "code_name", type: "nvarchar(max)", nullable: true),
                    codenameen = table.Column<string>(name: "code_name_en", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administrative_units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "attendanceTypeStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendanceTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttendanceTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attendanceTypeStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "courseLessonStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseLessonStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseLessonStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseLessonStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "courseStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employeeRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeRoleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeRoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employeeStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "holidayStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HolidayCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HolidayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_holidayStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "internStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InternStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_internStatuses", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "studentStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "provinces",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nameen = table.Column<string>(name: "name_en", type: "nvarchar(max)", nullable: true),
                    fullname = table.Column<string>(name: "full_name", type: "nvarchar(max)", nullable: true),
                    fullnameen = table.Column<string>(name: "full_name_en", type: "nvarchar(max)", nullable: true),
                    codename = table.Column<string>(name: "code_name", type: "nvarchar(max)", nullable: true),
                    administrativeunitid = table.Column<int>(name: "administrative_unit_id", type: "int", nullable: true),
                    administrativeregionid = table.Column<int>(name: "administrative_region_id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provinces", x => x.code);
                    table.ForeignKey(
                        name: "FK_provinces_administrative_regions_administrative_region_id",
                        column: x => x.administrativeregionid,
                        principalTable: "administrative_regions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_provinces_administrative_units_administrative_unit_id",
                        column: x => x.administrativeunitid,
                        principalTable: "administrative_units",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "courseLessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseLessonCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseLessonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseLessonStatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseLessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_courseLessons_courseLessonStatuses_CourseLessonStatusId",
                        column: x => x.CourseLessonStatusId,
                        principalTable: "courseLessonStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseLACode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseLAName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseLAPrice = table.Column<double>(type: "float", nullable: true),
                    CourseStatusId = table.Column<int>(type: "int", nullable: true),
                    SupportMonth = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_courses_courseStatuses_CourseStatusId",
                        column: x => x.CourseStatusId,
                        principalTable: "courseStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "districts",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nameen = table.Column<string>(name: "name_en", type: "nvarchar(max)", nullable: true),
                    fullname = table.Column<string>(name: "full_name", type: "nvarchar(max)", nullable: true),
                    fullnameen = table.Column<string>(name: "full_name_en", type: "nvarchar(max)", nullable: true),
                    codename = table.Column<string>(name: "code_name", type: "nvarchar(max)", nullable: true),
                    provincecode = table.Column<string>(name: "province_code", type: "nvarchar(450)", nullable: true),
                    administrativeunitid = table.Column<int>(name: "administrative_unit_id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_districts", x => x.code);
                    table.ForeignKey(
                        name: "FK_districts_administrative_units_administrative_unit_id",
                        column: x => x.administrativeunitid,
                        principalTable: "administrative_units",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_districts_provinces_province_code",
                        column: x => x.provincecode,
                        principalTable: "provinces",
                        principalColumn: "code");
                });

            migrationBuilder.CreateTable(
                name: "courseLACourseLessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseLAId = table.Column<int>(type: "int", nullable: true),
                    CourseLessonId = table.Column<int>(type: "int", nullable: true),
                    SortNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseLACourseLessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_courseLACourseLessons_courseLessons_CourseLessonId",
                        column: x => x.CourseLessonId,
                        principalTable: "courseLessons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_courseLACourseLessons_courses_CourseLAId",
                        column: x => x.CourseLAId,
                        principalTable: "courses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "wards",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nameen = table.Column<string>(name: "name_en", type: "nvarchar(max)", nullable: true),
                    fullname = table.Column<string>(name: "full_name", type: "nvarchar(max)", nullable: true),
                    fullnameen = table.Column<string>(name: "full_name_en", type: "nvarchar(max)", nullable: true),
                    codename = table.Column<string>(name: "code_name", type: "nvarchar(max)", nullable: true),
                    districtcode = table.Column<string>(name: "district_code", type: "nvarchar(450)", nullable: true),
                    administrativeunitid = table.Column<int>(name: "administrative_unit_id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wards", x => x.code);
                    table.ForeignKey(
                        name: "FK_wards_administrative_units_administrative_unit_id",
                        column: x => x.administrativeunitid,
                        principalTable: "administrative_units",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_wards_districts_district_code",
                        column: x => x.districtcode,
                        principalTable: "districts",
                        principalColumn: "code");
                });

            migrationBuilder.CreateTable(
                name: "employeeLA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeLAUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLAPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeRoleId = table.Column<int>(type: "int", nullable: true),
                    EmployeeAvatar = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    WardCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DistrictCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProvinceCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    NumberPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZaloUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkyUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLAName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLABirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeStatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeLA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employeeLA_districts_DistrictCode",
                        column: x => x.DistrictCode,
                        principalTable: "districts",
                        principalColumn: "code");
                    table.ForeignKey(
                        name: "FK_employeeLA_employeeRoles_EmployeeRoleId",
                        column: x => x.EmployeeRoleId,
                        principalTable: "employeeRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_employeeLA_employeeStatuses_EmployeeStatusId",
                        column: x => x.EmployeeStatusId,
                        principalTable: "employeeStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_employeeLA_genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "genders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_employeeLA_provinces_ProvinceCode",
                        column: x => x.ProvinceCode,
                        principalTable: "provinces",
                        principalColumn: "code");
                    table.ForeignKey(
                        name: "FK_employeeLA_wards_WardCode",
                        column: x => x.WardCode,
                        principalTable: "wards",
                        principalColumn: "code");
                });

            migrationBuilder.CreateTable(
                name: "holidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalDay = table.Column<int>(type: "int", nullable: true),
                    HolidayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenDay = table.Column<int>(type: "int", nullable: true),
                    OpenMonth = table.Column<int>(type: "int", nullable: true),
                    CloseDay = table.Column<int>(type: "int", nullable: true),
                    CloseMonth = table.Column<int>(type: "int", nullable: true),
                    HolidayDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLACreateId = table.Column<int>(type: "int", nullable: true),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HolidayStatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_holidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_holidays_employeeLA_EmployeeLACreateId",
                        column: x => x.EmployeeLACreateId,
                        principalTable: "employeeLA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_holidays_holidayStatuses_HolidayStatusId",
                        column: x => x.HolidayStatusId,
                        principalTable: "holidayStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "interns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpenDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CloseDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StudentSlot = table.Column<int>(type: "int", nullable: true),
                    EmployeeLeadId = table.Column<int>(type: "int", nullable: true),
                    InternStatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_interns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_interns_employeeLA_EmployeeLeadId",
                        column: x => x.EmployeeLeadId,
                        principalTable: "employeeLA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_interns_internStatuses_InternStatusId",
                        column: x => x.InternStatusId,
                        principalTable: "internStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "studentLAs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentLAUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentLAPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentLASdt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentLAAvatar = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ZaloUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDatalogId = table.Column<int>(type: "int", nullable: true),
                    StudentDatalogDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentIntroduceId = table.Column<int>(type: "int", nullable: true),
                    WardCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DistrictCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProvinceCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StudentLABirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SaleId = table.Column<int>(type: "int", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    InsightName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAccountDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StudentStatusId = table.Column<int>(type: "int", nullable: true),
                    HolidayTotal = table.Column<float>(type: "real", nullable: true),
                    ReserveTotal = table.Column<float>(type: "real", nullable: true),
                    UnauthorizedAbsencesTotal = table.Column<float>(type: "real", nullable: true),
                    LateMinuteTotal = table.Column<int>(type: "int", nullable: true),
                    UnactiveTotal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentLAs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentLAs_StudentDatalog_StudentDatalogId",
                        column: x => x.StudentDatalogId,
                        principalTable: "StudentDatalog",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLAs_districts_DistrictCode",
                        column: x => x.DistrictCode,
                        principalTable: "districts",
                        principalColumn: "code");
                    table.ForeignKey(
                        name: "FK_studentLAs_employeeLA_SaleId",
                        column: x => x.SaleId,
                        principalTable: "employeeLA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLAs_genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "genders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLAs_provinces_ProvinceCode",
                        column: x => x.ProvinceCode,
                        principalTable: "provinces",
                        principalColumn: "code");
                    table.ForeignKey(
                        name: "FK_studentLAs_studentLAs_StudentIntroduceId",
                        column: x => x.StudentIntroduceId,
                        principalTable: "studentLAs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLAs_studentStatuses_StudentStatusId",
                        column: x => x.StudentStatusId,
                        principalTable: "studentStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLAs_wards_WardCode",
                        column: x => x.WardCode,
                        principalTable: "wards",
                        principalColumn: "code");
                });

            migrationBuilder.CreateTable(
                name: "employeeLAHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeLAId = table.Column<int>(type: "int", nullable: true),
                    HolidayId = table.Column<int>(type: "int", nullable: true),
                    TotalDay = table.Column<int>(type: "int", nullable: true),
                    IsSalary = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeLAHolidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employeeLAHolidays_employeeLA_EmployeeLAId",
                        column: x => x.EmployeeLAId,
                        principalTable: "employeeLA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_employeeLAHolidays_holidays_HolidayId",
                        column: x => x.HolidayId,
                        principalTable: "holidays",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "attendance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
                    ComfirmDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UnactiveReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeComfirmId = table.Column<int>(type: "int", nullable: true),
                    AttendanceTypeStatusId = table.Column<int>(type: "int", nullable: true),
                    ActiveRealTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsLate = table.Column<bool>(type: "bit", nullable: true),
                    LateMinuteTotal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_attendance_attendanceTypeStatuses_AttendanceTypeStatusId",
                        column: x => x.AttendanceTypeStatusId,
                        principalTable: "attendanceTypeStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_attendance_employeeLA_EmployeeComfirmId",
                        column: x => x.EmployeeComfirmId,
                        principalTable: "employeeLA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_attendance_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "internTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InternId = table.Column<int>(type: "int", nullable: true),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
                    EmployeeLAConfirmId = table.Column<int>(type: "int", nullable: true),
                    EmployeeLAEmployeeConfirmId = table.Column<int>(type: "int", nullable: true),
                    LeadEvaluate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvaluateScore = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_internTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_internTasks_employeeLA_EmployeeLAEmployeeConfirmId",
                        column: x => x.EmployeeLAEmployeeConfirmId,
                        principalTable: "employeeLA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_internTasks_interns_InternId",
                        column: x => x.InternId,
                        principalTable: "interns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_internTasks_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "reserves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
                    OpenTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CloseTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDiff = table.Column<int>(type: "int", nullable: true),
                    ReserveReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeComfirmId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reserves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reserves_employeeLA_EmployeeComfirmId",
                        column: x => x.EmployeeComfirmId,
                        principalTable: "employeeLA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_reserves_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "studentCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
                    CourseLAId = table.Column<int>(type: "int", nullable: true),
                    OpenCourse = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CloseCourse = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SupportMonth = table.Column<int>(type: "int", nullable: true),
                    SortNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentCourses_courses_CourseLAId",
                        column: x => x.CourseLAId,
                        principalTable: "courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentCourses_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "studentEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
                    EmployeeLAId = table.Column<int>(type: "int", nullable: true),
                    SetMentorDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChangeReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentEmployees_employeeLA_EmployeeLAId",
                        column: x => x.EmployeeLAId,
                        principalTable: "employeeLA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentEmployees_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "studentLACourseLessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
                    CourseLessonId = table.Column<int>(type: "int", nullable: true),
                    CourseLAId = table.Column<int>(type: "int", nullable: true),
                    OpenCourse = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CloseCourse = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Score = table.Column<double>(type: "float", nullable: true),
                    EmployeeLAComfirmId = table.Column<int>(type: "int", nullable: true),
                    EmployeeEvaluate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkStudentTest = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentLACourseLessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentLACourseLessons_courseLessons_CourseLessonId",
                        column: x => x.CourseLessonId,
                        principalTable: "courseLessons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLACourseLessons_courses_CourseLAId",
                        column: x => x.CourseLAId,
                        principalTable: "courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLACourseLessons_employeeLA_EmployeeLAComfirmId",
                        column: x => x.EmployeeLAComfirmId,
                        principalTable: "employeeLA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLACourseLessons_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "studentLAHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
                    HolidayId = table.Column<int>(type: "int", nullable: true),
                    TotalDay = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentLAHolidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentLAHolidays_holidays_HolidayId",
                        column: x => x.HolidayId,
                        principalTable: "holidays",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLAHolidays_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "studentLAInterns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
                    InternId = table.Column<int>(type: "int", nullable: true),
                    JoinDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentLAInterns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentLAInterns_interns_InternId",
                        column: x => x.InternId,
                        principalTable: "interns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLAInterns_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "studentCourseEmployeeReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentCourseId = table.Column<int>(type: "int", nullable: true),
                    ConfirmDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReviewDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentCourseEmployeeReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentCourseEmployeeReviews_studentCourses_StudentCourseId",
                        column: x => x.StudentCourseId,
                        principalTable: "studentCourses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_attendance_AttendanceTypeStatusId",
                table: "attendance",
                column: "AttendanceTypeStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_attendance_EmployeeComfirmId",
                table: "attendance",
                column: "EmployeeComfirmId");

            migrationBuilder.CreateIndex(
                name: "IX_attendance_StudentLAId",
                table: "attendance",
                column: "StudentLAId");

            migrationBuilder.CreateIndex(
                name: "IX_courseLACourseLessons_CourseLAId",
                table: "courseLACourseLessons",
                column: "CourseLAId");

            migrationBuilder.CreateIndex(
                name: "IX_courseLACourseLessons_CourseLessonId",
                table: "courseLACourseLessons",
                column: "CourseLessonId");

            migrationBuilder.CreateIndex(
                name: "IX_courseLessons_CourseLessonStatusId",
                table: "courseLessons",
                column: "CourseLessonStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_courses_CourseStatusId",
                table: "courses",
                column: "CourseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_districts_administrative_unit_id",
                table: "districts",
                column: "administrative_unit_id");

            migrationBuilder.CreateIndex(
                name: "IX_districts_province_code",
                table: "districts",
                column: "province_code");

            migrationBuilder.CreateIndex(
                name: "IX_employeeLA_DistrictCode",
                table: "employeeLA",
                column: "DistrictCode");

            migrationBuilder.CreateIndex(
                name: "IX_employeeLA_EmployeeRoleId",
                table: "employeeLA",
                column: "EmployeeRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_employeeLA_EmployeeStatusId",
                table: "employeeLA",
                column: "EmployeeStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_employeeLA_GenderId",
                table: "employeeLA",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_employeeLA_ProvinceCode",
                table: "employeeLA",
                column: "ProvinceCode");

            migrationBuilder.CreateIndex(
                name: "IX_employeeLA_WardCode",
                table: "employeeLA",
                column: "WardCode");

            migrationBuilder.CreateIndex(
                name: "IX_employeeLAHolidays_EmployeeLAId",
                table: "employeeLAHolidays",
                column: "EmployeeLAId");

            migrationBuilder.CreateIndex(
                name: "IX_employeeLAHolidays_HolidayId",
                table: "employeeLAHolidays",
                column: "HolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_holidays_EmployeeLACreateId",
                table: "holidays",
                column: "EmployeeLACreateId");

            migrationBuilder.CreateIndex(
                name: "IX_holidays_HolidayStatusId",
                table: "holidays",
                column: "HolidayStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_interns_EmployeeLeadId",
                table: "interns",
                column: "EmployeeLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_interns_InternStatusId",
                table: "interns",
                column: "InternStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_internTasks_EmployeeLAEmployeeConfirmId",
                table: "internTasks",
                column: "EmployeeLAEmployeeConfirmId");

            migrationBuilder.CreateIndex(
                name: "IX_internTasks_InternId",
                table: "internTasks",
                column: "InternId");

            migrationBuilder.CreateIndex(
                name: "IX_internTasks_StudentLAId",
                table: "internTasks",
                column: "StudentLAId");

            migrationBuilder.CreateIndex(
                name: "IX_provinces_administrative_region_id",
                table: "provinces",
                column: "administrative_region_id");

            migrationBuilder.CreateIndex(
                name: "IX_provinces_administrative_unit_id",
                table: "provinces",
                column: "administrative_unit_id");

            migrationBuilder.CreateIndex(
                name: "IX_reserves_EmployeeComfirmId",
                table: "reserves",
                column: "EmployeeComfirmId");

            migrationBuilder.CreateIndex(
                name: "IX_reserves_StudentLAId",
                table: "reserves",
                column: "StudentLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentCourseEmployeeReviews_StudentCourseId",
                table: "studentCourseEmployeeReviews",
                column: "StudentCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_studentCourses_CourseLAId",
                table: "studentCourses",
                column: "CourseLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentCourses_StudentLAId",
                table: "studentCourses",
                column: "StudentLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentEmployees_EmployeeLAId",
                table: "studentEmployees",
                column: "EmployeeLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentEmployees_StudentLAId",
                table: "studentEmployees",
                column: "StudentLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLACourseLessons_CourseLAId",
                table: "studentLACourseLessons",
                column: "CourseLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLACourseLessons_CourseLessonId",
                table: "studentLACourseLessons",
                column: "CourseLessonId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLACourseLessons_EmployeeLAComfirmId",
                table: "studentLACourseLessons",
                column: "EmployeeLAComfirmId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLACourseLessons_StudentLAId",
                table: "studentLACourseLessons",
                column: "StudentLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAHolidays_HolidayId",
                table: "studentLAHolidays",
                column: "HolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAHolidays_StudentLAId",
                table: "studentLAHolidays",
                column: "StudentLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAInterns_InternId",
                table: "studentLAInterns",
                column: "InternId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAInterns_StudentLAId",
                table: "studentLAInterns",
                column: "StudentLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_DistrictCode",
                table: "studentLAs",
                column: "DistrictCode");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_GenderId",
                table: "studentLAs",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_ProvinceCode",
                table: "studentLAs",
                column: "ProvinceCode");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_SaleId",
                table: "studentLAs",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_StudentDatalogId",
                table: "studentLAs",
                column: "StudentDatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_StudentIntroduceId",
                table: "studentLAs",
                column: "StudentIntroduceId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_StudentStatusId",
                table: "studentLAs",
                column: "StudentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_WardCode",
                table: "studentLAs",
                column: "WardCode");

            migrationBuilder.CreateIndex(
                name: "IX_wards_administrative_unit_id",
                table: "wards",
                column: "administrative_unit_id");

            migrationBuilder.CreateIndex(
                name: "IX_wards_district_code",
                table: "wards",
                column: "district_code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attendance");

            migrationBuilder.DropTable(
                name: "courseLACourseLessons");

            migrationBuilder.DropTable(
                name: "employeeLAHolidays");

            migrationBuilder.DropTable(
                name: "internTasks");

            migrationBuilder.DropTable(
                name: "reserves");

            migrationBuilder.DropTable(
                name: "studentCourseEmployeeReviews");

            migrationBuilder.DropTable(
                name: "studentEmployees");

            migrationBuilder.DropTable(
                name: "studentLACourseLessons");

            migrationBuilder.DropTable(
                name: "studentLAHolidays");

            migrationBuilder.DropTable(
                name: "studentLAInterns");

            migrationBuilder.DropTable(
                name: "attendanceTypeStatuses");

            migrationBuilder.DropTable(
                name: "studentCourses");

            migrationBuilder.DropTable(
                name: "courseLessons");

            migrationBuilder.DropTable(
                name: "holidays");

            migrationBuilder.DropTable(
                name: "interns");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "studentLAs");

            migrationBuilder.DropTable(
                name: "courseLessonStatuses");

            migrationBuilder.DropTable(
                name: "holidayStatuses");

            migrationBuilder.DropTable(
                name: "internStatuses");

            migrationBuilder.DropTable(
                name: "courseStatuses");

            migrationBuilder.DropTable(
                name: "StudentDatalog");

            migrationBuilder.DropTable(
                name: "employeeLA");

            migrationBuilder.DropTable(
                name: "studentStatuses");

            migrationBuilder.DropTable(
                name: "employeeRoles");

            migrationBuilder.DropTable(
                name: "employeeStatuses");

            migrationBuilder.DropTable(
                name: "genders");

            migrationBuilder.DropTable(
                name: "wards");

            migrationBuilder.DropTable(
                name: "districts");

            migrationBuilder.DropTable(
                name: "provinces");

            migrationBuilder.DropTable(
                name: "administrative_regions");

            migrationBuilder.DropTable(
                name: "administrative_units");
        }
    }
}
