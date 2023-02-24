using DJ_UseCaseLayer.Business.AttendanceManager;
using DJ_WebDesignCore.Business.AttendanceManager;
using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceUnauthorizedAbsences;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.AttendanceUnauthorizedAbsencesGetAPIs
{
    public class AttendanceUnauthorizedAbsencesStatisticalController : BaseAPI
    {
        public readonly IAttendanceUnauthorizedAbsencesStatistical _attendanceUnauthorizedAbsencesCRUD;
        public AttendanceUnauthorizedAbsencesStatisticalController()
        {
            _attendanceUnauthorizedAbsencesCRUD = new AttendanceUnauthorizedAbsencesStatistical();
        }
        [HttpGet("AttendanceUnauthorizedAbsencesCRUD/{studentId}")]
        public ActionResult<AttendanceUnauthorizedAbsencesGetDTO> getAttendanceUnauthorizedAbsences(int? studentId)
        {
            return Ok(_attendanceUnauthorizedAbsencesCRUD.getAttendanceUnauthorizedAbsences(studentId));
        }
    }
}
