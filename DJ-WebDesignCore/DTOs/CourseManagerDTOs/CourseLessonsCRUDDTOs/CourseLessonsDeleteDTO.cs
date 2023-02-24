using DJ_WebDesignCore.Entites.Courses;
using DJ_WebDesignCore.Enums.CourseManagerEnums.CourseLesson;

namespace DJ_WebDesignCore.DTOs.CourseManagerDTOs.CourseLessonsCRUDDTOs
{
    public class CourseLessonsDeleteDTO
    {
        public CourseLessonsDeleteEnums? Status { get; set; }
        public CourseLesson? Data { get; set; }
        public string? ShortDetail { get; set; }
    }
}
