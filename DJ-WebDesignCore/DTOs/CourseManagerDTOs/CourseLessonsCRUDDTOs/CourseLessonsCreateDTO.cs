using DJ_WebDesignCore.Entites.Courses;
using DJ_WebDesignCore.Enums.CourseManagerEnums.CourseLesson;

namespace DJ_WebDesignCore.DTOs.CourseManagerDTOs.CourseLessonsCRUDDTOs
{
    public class CourseLessonsCreateDTO
    {
        public CourseLessonsCreateEnums? Status { get; set; }
        public CourseLesson? Data { get; set; }
        public string? ShortDetail { get; set; }
    }
}
