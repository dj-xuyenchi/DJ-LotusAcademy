using DJ_WebDesignCore.Entites.Courses;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Student;

namespace DJ_WebDesignCore.Entites.Business
{
    public class StudentLACourseLesson : BaseEntity
    {
        public int? StudentLAId { get; set; }
        public StudentLA? StudentLA { get; set; }
        public int? CourseLessonId { get; set; }
        public CourseLesson? CourseLesson { get; set; }
        public int? CourseLAId { get; set; }
        public CourseLA? CourseLA { get; set; }
        public DateTime? OpenCourse { get; set; }
        public DateTime? CloseCourse { get; set; }
        public double? Score { get; set; }
        public int? EmployeeLAComfirmId { get; set; }
        public EmployeeLA? EmployeeLAComfirm { get; set; }
        public string? EmployeeEvaluate { get; set; }
        // Link bài kiểm tra học viên làm
        public string? LinkStudentTest { get; set; }
        public int? SortNumber { get; set; }
    }
}
