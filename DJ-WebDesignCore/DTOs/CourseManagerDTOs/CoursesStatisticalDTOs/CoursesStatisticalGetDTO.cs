using DJ_WebDesignCore.Enums.CourseManagerEnums.CoursesStatisticalEnums;

namespace DJ_WebDesignCore.DTOs.CourseManagerDTOs.CoursesStatisticalDTOs
{
    public class CoursesStatisticalGetDTO
    {
        public CoursesStatisticalEnum? Status { get; set; }
        public List<CoursesStatisticalGetter>? data { get; set; }
        public string? ShortDetail { get; set; }
    }
}
