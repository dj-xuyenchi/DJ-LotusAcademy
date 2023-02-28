using DJ_UseCaseLayer.Business.AttendanceManager;
using DJ_WebDesignCore.Business.AttendanceManager;
using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceProgressStatisticalDTOs;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.AttendanceProgressManagerAPIs
{
    public class AttendanceProgressController : BaseAPI
    {
        public readonly IAttendanceProgressStatistical _attendanceProgressStatistical;
        public AttendanceProgressController()
        {
            _attendanceProgressStatistical = new AttendanceProgressStatistical();
        }
        [HttpGet("AttendanceProgressStatistical")]
        public ActionResult<AttendanceProgressStatisticalGetDTO> getAttendanceProgressStatistical([FromQuery] int? studentId)
        {
            return Ok(_attendanceProgressStatistical.getAttendanceProgressStatistical(studentId));
        }
    }
}
