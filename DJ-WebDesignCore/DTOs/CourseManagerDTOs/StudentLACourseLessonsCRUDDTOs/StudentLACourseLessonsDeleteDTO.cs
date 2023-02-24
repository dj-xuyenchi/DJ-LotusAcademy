using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Enums.CourseManagerEnums.StudentLACourseLessonsEnums;

namespace DJ_WebDesignCore.DTOs.CourseManagerDTOs.StudentLACourseLessonsCRUDDTOs
{
    public class StudentLACourseLessonsDeleteDTO
    {
        public StudentLACourseLessonsDeleteEnums? Status { get; set; }
        public StudentLACourseLesson? Data { get; set; }
        public string? ShortDetail { get; set; }
    }
}
