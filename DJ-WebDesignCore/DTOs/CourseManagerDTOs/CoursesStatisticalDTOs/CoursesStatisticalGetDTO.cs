using DJ_WebDesignCore.Enums.CourseManagerEnums.CoursesStatisticalEnums;

namespace DJ_WebDesignCore.DTOs.CourseManagerDTOs.CoursesStatisticalDTOs
{
    public class CoursesStatisticalGetDTO
    {
        public CoursesStatisticalEnum? Id { get; set; }
        public List<CoursesStatisticalGetter>? Data { get; set; }
        public string? ShortDetail { get; set; }
    }
}
