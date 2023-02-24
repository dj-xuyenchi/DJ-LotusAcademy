using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Enums.CourseManagerEnums.CourseLessonStatusesEnums;

namespace DJ_WebDesignCore.DTOs.CourseManagerDTOs.CourseLessonStatusesCRUDDTOs
{
    public class CourseLessonStatusesCreateDTO
    {
        public CourseLessonStatusesCreateEnums? Status { get; set; }
        public CourseLessonStatus? Data { get; set; }
        public string? ShortDetail { get; set; }
    }
}
