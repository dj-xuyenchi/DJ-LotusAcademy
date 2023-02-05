﻿// <auto-generated />
using System;
using DJ_LAUseCase.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DJLAServices.Migrations
{
    [DbContext(typeof(LAContext))]
    partial class LAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Business.Holiday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CloseTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DateDiff")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeComfirmId")
                        .HasColumnType("int");

                    b.Property<string>("HolidayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("OpenTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StudentLAId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeComfirmId");

                    b.HasIndex("StudentLAId");

                    b.ToTable("holidays");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Business.Reserve", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CloseTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DateDiff")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeComfirmId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OpenTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReserveReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentLAId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeComfirmId");

                    b.HasIndex("StudentLAId");

                    b.ToTable("reserves");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Business.UnauthorizedAbsences", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EmployeeComfirmId")
                        .HasColumnType("int");

                    b.Property<int?>("StudentLAId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UnauthorizedAbsencesDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UnauthorizedAbsencesName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeComfirmId");

                    b.HasIndex("StudentLAId");

                    b.ToTable("unauthorizedAbsences");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Courses.CourseLA", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseLACode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseLAName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("CourseLAPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Employee.EmployeeLA", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CommuneId")
                        .HasColumnType("int");

                    b.Property<int?>("DistrictId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EmployeeLABirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeLAName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeLAPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeLAUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeRoleId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeStatusId")
                        .HasColumnType("int");

                    b.Property<string>("FacebookUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("NumberPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<string>("SkyUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CommuneId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("EmployeeRoleId");

                    b.HasIndex("EmployeeStatusId");

                    b.HasIndex("GenderId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("employeeLA");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Employee.EmployeeRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmployeeRoleCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeRoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("employeeRoles");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Employee.StudentCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CloseCourse")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CourseLAId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OpenCourse")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StudentLAId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseLAId");

                    b.HasIndex("StudentLAId");

                    b.ToTable("studentCourses");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Properties.Address.Commune", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CommuneCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommuneName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("communes");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Properties.Address.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DistrictCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DistrictName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("districtes");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Properties.Address.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ProvinceCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvinceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("provinces");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Properties.CourseStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseStatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("courseStatuses");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Properties.EmployeeStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmployeeStatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("employeeStatuses");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Properties.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GenderCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenderName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("genders");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Properties.StudentStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StudentStatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("studentStatuses");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Student.StudentLA", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CommuneId")
                        .HasColumnType("int");

                    b.Property<int?>("DistrictId")
                        .HasColumnType("int");

                    b.Property<int?>("GenderId")
                        .HasColumnType("int");

                    b.Property<float?>("HolidayTotal")
                        .HasColumnType("real");

                    b.Property<int?>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<float?>("ReserveTotal")
                        .HasColumnType("real");

                    b.Property<int?>("SaleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StudentLABirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("StudentLAName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentLAPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentLAUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentStatusId")
                        .HasColumnType("int");

                    b.Property<float?>("UnauthorizedAbsencesTotal")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CommuneId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("GenderId");

                    b.HasIndex("ProvinceId");

                    b.HasIndex("SaleId");

                    b.HasIndex("StudentStatusId");

                    b.ToTable("studentLAs");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Business.Holiday", b =>
                {
                    b.HasOne("DJ_WebDesignCore.Entites.Employee.EmployeeLA", "EmployeeComfirm")
                        .WithMany()
                        .HasForeignKey("EmployeeComfirmId");

                    b.HasOne("DJ_WebDesignCore.Entites.Student.StudentLA", "StudentLA")
                        .WithMany()
                        .HasForeignKey("StudentLAId");

                    b.Navigation("EmployeeComfirm");

                    b.Navigation("StudentLA");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Business.Reserve", b =>
                {
                    b.HasOne("DJ_WebDesignCore.Entites.Employee.EmployeeLA", "EmployeeComfirm")
                        .WithMany()
                        .HasForeignKey("EmployeeComfirmId");

                    b.HasOne("DJ_WebDesignCore.Entites.Student.StudentLA", "StudentLA")
                        .WithMany()
                        .HasForeignKey("StudentLAId");

                    b.Navigation("EmployeeComfirm");

                    b.Navigation("StudentLA");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Business.UnauthorizedAbsences", b =>
                {
                    b.HasOne("DJ_WebDesignCore.Entites.Employee.EmployeeLA", "EmployeeComfirm")
                        .WithMany()
                        .HasForeignKey("EmployeeComfirmId");

                    b.HasOne("DJ_WebDesignCore.Entites.Student.StudentLA", "StudentLA")
                        .WithMany()
                        .HasForeignKey("StudentLAId");

                    b.Navigation("EmployeeComfirm");

                    b.Navigation("StudentLA");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Employee.EmployeeLA", b =>
                {
                    b.HasOne("DJ_WebDesignCore.Entites.Properties.Address.Commune", "Commune")
                        .WithMany()
                        .HasForeignKey("CommuneId");

                    b.HasOne("DJ_WebDesignCore.Entites.Properties.Address.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId");

                    b.HasOne("DJ_WebDesignCore.Entites.Employee.EmployeeRole", "EmployeeRole")
                        .WithMany()
                        .HasForeignKey("EmployeeRoleId");

                    b.HasOne("DJ_WebDesignCore.Entites.Properties.EmployeeStatus", "EmployeeStatus")
                        .WithMany()
                        .HasForeignKey("EmployeeStatusId");

                    b.HasOne("DJ_WebDesignCore.Entites.Properties.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId");

                    b.HasOne("DJ_WebDesignCore.Entites.Properties.Address.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId");

                    b.Navigation("Commune");

                    b.Navigation("District");

                    b.Navigation("EmployeeRole");

                    b.Navigation("EmployeeStatus");

                    b.Navigation("Gender");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Employee.StudentCourse", b =>
                {
                    b.HasOne("DJ_WebDesignCore.Entites.Courses.CourseLA", "CourseLA")
                        .WithMany()
                        .HasForeignKey("CourseLAId");

                    b.HasOne("DJ_WebDesignCore.Entites.Student.StudentLA", "StudentLA")
                        .WithMany()
                        .HasForeignKey("StudentLAId");

                    b.Navigation("CourseLA");

                    b.Navigation("StudentLA");
                });

            modelBuilder.Entity("DJ_WebDesignCore.Entites.Student.StudentLA", b =>
                {
                    b.HasOne("DJ_WebDesignCore.Entites.Properties.Address.Commune", "Commune")
                        .WithMany()
                        .HasForeignKey("CommuneId");

                    b.HasOne("DJ_WebDesignCore.Entites.Properties.Address.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId");

                    b.HasOne("DJ_WebDesignCore.Entites.Properties.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId");

                    b.HasOne("DJ_WebDesignCore.Entites.Properties.Address.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId");

                    b.HasOne("DJ_WebDesignCore.Entites.Employee.EmployeeLA", "Sale")
                        .WithMany()
                        .HasForeignKey("SaleId");

                    b.HasOne("DJ_WebDesignCore.Entites.Properties.StudentStatus", "StudentStatus")
                        .WithMany()
                        .HasForeignKey("StudentStatusId");

                    b.Navigation("Commune");

                    b.Navigation("District");

                    b.Navigation("Gender");

                    b.Navigation("Province");

                    b.Navigation("Sale");

                    b.Navigation("StudentStatus");
                });
#pragma warning restore 612, 618
        }
    }
}
