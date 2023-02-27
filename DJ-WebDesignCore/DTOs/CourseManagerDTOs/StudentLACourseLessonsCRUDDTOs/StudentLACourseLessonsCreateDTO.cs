using DJ_WebDesignCore.Entites.Business;

using DJ_WebDesignCore.Enums.CourseManagerEnums;

namespace DJ_WebDesignCore.DTOs.CourseManagerDTOs.CourseCRUDDTOs
{
    public class StudentLACourseLessonsCreateDTO
    {
        public StudentLACourseLessonsCreateEnums? Status { get; set; }
        public StudentLACourseLesson Data { get; set; }
        public string? ShortDetail { get; set; }
    }
}
