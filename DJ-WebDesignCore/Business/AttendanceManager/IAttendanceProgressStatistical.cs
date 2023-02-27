using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceProgressStatisticalDTOs;

namespace DJ_WebDesignCore.Business.AttendanceManager
{
    public interface IAttendanceProgressStatistical
    {
        AttendanceProgressStatisticalGetDTO getAttendanceProgressStatistical(int? studendId);
    }
}
