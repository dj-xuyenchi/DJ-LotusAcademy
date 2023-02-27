using DJ_WebDesignCore.Enums.AttendanceManagerEnums.AttendanceUnauthorizedAbsencesStatisticalEnums;

namespace DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceUnauthorizedAbsences
{
    public class AttendanceUnauthorizedAbsencesGetDTO
    {
        public AttendanceUnauthorizedAbsencesStatisticalEnum? Status { get; set; }
        public List<AttendanceUnauthorizedAbsencesGetter> Data { get; set; }
        public string? ShortDetail { get; set; }
    }
}
