using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Enums.StudentActiveManagerEnums;

namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs
{
    public class StatisticsStudyTimeDTO
    {
        public int? StudentLAId { get; set; }
        public string? StudentLAName { get; set; }
        public IEnumerable<StudentCourse>? StudentCourses { get; set; }
        public float? HolidayTotal { get; set; }
        public int? UnactiveTotal { get; set; }
        public float? ReserveTotal { get; set; }
        public ActiveStatus? IsActive { get; set; }
    }
}
