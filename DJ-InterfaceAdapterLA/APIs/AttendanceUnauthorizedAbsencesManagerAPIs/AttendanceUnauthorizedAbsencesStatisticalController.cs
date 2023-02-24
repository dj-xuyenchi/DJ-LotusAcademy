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
        [HttpGet("AttendanceUnauthorizedAbsencesCRUD")]
        public ActionResult<AttendanceUnauthorizedAbsencesGetDTO> getAttendanceUnauthorizedAbsences(int? studentLAId)
        {
            return Ok(_attendanceUnauthorizedAbsencesCRUD.getAttendanceUnauthorizedAbsences(studentLAId));
        }
    }
}
