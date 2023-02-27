using DJ_WebDesignCore.Enums.AttendanceManagerEnums.AttendanceProgressStatisticalEnums;

namespace DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceProgressStatisticalDTOs
{
    public class AttendanceProgressStatisticalGetDTO
    {
        public AttendanceProgressStatisticalEnum? Status { get; set; }
        public List<AttendanceProgressStatisticalGetter>? Data { get; set; }
        public string? ShortDetail { get; set; }
    }
}
