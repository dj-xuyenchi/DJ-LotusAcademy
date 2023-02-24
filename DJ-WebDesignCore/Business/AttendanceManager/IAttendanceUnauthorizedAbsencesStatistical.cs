using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceUnauthorizedAbsences;

namespace DJ_WebDesignCore.Business.AttendanceManager
{
    public interface IAttendanceUnauthorizedAbsencesStatistical
    {
        AttendanceUnauthorizedAbsencesGetDTO getAttendanceUnauthorizedAbsences(int? studentLAId);
    }
}
