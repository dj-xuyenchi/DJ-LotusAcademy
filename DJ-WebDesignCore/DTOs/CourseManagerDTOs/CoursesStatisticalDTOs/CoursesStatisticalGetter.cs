namespace DJ_WebDesignCore.DTOs.CourseManagerDTOs.CoursesStatisticalDTOs
{
    public class CoursesStatisticalGetter
    {
        public int? sortNumber { get; set; }
        public int? CourseId { get; set; }
        public string? courseName { get; set; }
        public DateTime? signInDateTime { get; set; }
        public int? supportTime { get; set; }
        public DateTime? doneExpectedDateTime { get; set; }
        public string? lessonNow { get; set; }
        public string? evalute { get; set; }
    }
}
