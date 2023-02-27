using DJ_WebDesignCore.Entites.Courses;
using DJ_WebDesignCore.Enums.CourseManagerEnums.CourseLessonStatusesEnums;

namespace DJ_WebDesignCore.DTOs.CourseManagerDTOs.CourseLessonStatusesCRUDDTOs
{
    public class CourseLessonStatusesUpdateDTO
    {
        public CourseLessonStatusesUpdateEnums? Status { get; set; }
        public CourseLesson Data { get; set; }
        public string? ShortDetail { get; set; }
    }
}
