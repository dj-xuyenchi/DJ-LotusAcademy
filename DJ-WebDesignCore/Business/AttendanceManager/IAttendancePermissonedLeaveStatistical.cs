using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendancePermissionedLeave;

namespace DJ_WebDesignCore.Business.AttendanceManager
{
    public interface IAttendancePermissonedLeaveStatistical
    {
        AttendancePermissionedLeaveGetDTO getAttendancePermissonedLeave(int? studentLAId);
    }
}
