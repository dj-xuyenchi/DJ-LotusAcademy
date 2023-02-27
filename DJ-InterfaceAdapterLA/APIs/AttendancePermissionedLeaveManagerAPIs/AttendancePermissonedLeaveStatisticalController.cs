using DJ_UseCaseLayer.Business.AttendanceManager;
using DJ_WebDesignCore.Business.AttendanceManager;
using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendancePermissionedLeave;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.AttendancePermissionedLeaveAPIs
{
    public class AttendancePermissonedLeaveStatisticalController : BaseAPI
    {
        public readonly IAttendancePermissonedLeaveStatistical _attendancePermissonedLeaveCRUD;
        public AttendancePermissonedLeaveStatisticalController()
        {
            _attendancePermissonedLeaveCRUD = new AttendancePermissionedLeaveStatistical();
        }
        [HttpGet("AttendancePermissionedLeave/{studentId}")]
        public ActionResult<AttendancePermissionedLeaveGetDTO> getAttendancePermissionedLeave(int? studentId)
        {
            return Ok(_attendancePermissonedLeaveCRUD.getAttendancePermissonedLeave(studentId));
        }
    }
}
