using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Courses;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Properties.Address;
using DJ_WebDesignCore.Entites.Student;
using Microsoft.EntityFrameworkCore;

namespace DJ_UseCaseLayer.DAO
{
    public class LAContext : DbContext
    {

        // Employee
        public DbSet<EmployeeLA> employeeLA { get; set; }
        public DbSet<EmployeeRole> employeeRoles { get; set; }
        // Properties
        //
        public DbSet<Ward> wards { get; set; }
        public DbSet<District> districts { get; set; }
        public DbSet<Province> provinces { get; set; }
        public DbSet<AdministrativeRegion> administrative_regions { get; set; }
        public DbSet<AdministrativeUnits> administrative_units { get; set; }
        //
        public DbSet<CourseStatus> courseStatuses { get; set; }
        public DbSet<EmployeeStatus> employeeStatuses { get; set; }
        public DbSet<Gender> genders { get; set; }
        public DbSet<StudentStatus> studentStatuses { get; set; }
        public DbSet<AttendanceTypeStatus> attendanceTypeStatuses { get; set; }
        public DbSet<CourseLessonStatus> courseLessonStatuses { get; set; }
        public DbSet<InternStatus> internStatuses { get; set; }
        public DbSet<HolidayStatus> holidayStatuses { get; set; }
        public DbSet<StudentDatalog> studentDatalogs { get; set; }
        // Student
        public DbSet<StudentLA> studentLAs { get; set; }

        // Course
        public DbSet<CourseLA> courses { get; set; }
        public DbSet<CourseLesson> courseLessons { get; set; }
        public DbSet<CourseLACourseLesson> courseLACourseLessons { get; set; }
        // Business
        public DbSet<Holiday> holidays { get; set; }
        public DbSet<Reserve> reserves { get; set; }
        public DbSet<Attendance> attendance { get; set; }
        public DbSet<AttendanceSlot> attendanceSlots { get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }
        public DbSet<StudentLACourseLesson> studentLACourseLessons { get; set; }
        public DbSet<Intern> interns { get; set; }
        public DbSet<InternTask> internTasks { get; set; }
        public DbSet<StudentLAIntern> studentLAInterns { get; set; }
        public DbSet<StudentEmployee> studentEmployees { get; set; }
        public DbSet<StudentLAHoliday> studentLAHolidays { get; set; }
        public DbSet<EmployeeLAHoliday> employeeLAHolidays { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(Setting.connectServerUrl());
            //optionsBuilder.UseSqlServer(Setting.connectServerUrlMacOS());
            optionsBuilder.UseSqlServer(Setting.urlWin());

        }

    }
}
