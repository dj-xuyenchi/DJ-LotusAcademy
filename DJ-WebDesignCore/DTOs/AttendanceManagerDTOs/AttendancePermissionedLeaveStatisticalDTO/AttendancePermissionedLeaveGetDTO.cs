using DJ_WebDesignCore.Enums.AttendanceManagerEnums;

namespace DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendancePermissionedLeave
{
    public class AttendancePermissionedLeaveGetDTO
    {
        public AttendancePermissionedLeaveGetEnum Status { get; set; }
        public string? ShortDetail { get; set; }
        public List<AttendancePermissionedLeaveGetter> Data { get; set; }
    }
}
