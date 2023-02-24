using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Enums.CourseManagerEnums.StudentLACourseLessonsEnums;

namespace DJ_WebDesignCore.DTOs.CourseManagerDTOs.StudentLACourseLessonsCRUDDTOs
{
    public class StudentLACourseLessonsUpdateDTO
    {
        public StudentLACourseLessonsUpdateEnums? Status { get; set; }
        public StudentLACourseLesson? Data { get; set; }
        public string? ShortDetail { get; set; }

    }
}
