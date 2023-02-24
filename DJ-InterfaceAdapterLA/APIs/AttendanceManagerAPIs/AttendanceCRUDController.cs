using DJ_UseCaseLayer.Business.AttendanceManager;
using DJ_WebDesignCore.Business.AttendanceManager;
using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceCRUDDTOs;
using DJ_WebDesignCore.Entites.Business;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.AttendanceManagerAPIs
{
    public class AttendanceCRUDController : BaseAPI
    {
        private readonly IAttendanceCRUD _attendanceCRUD;
        public AttendanceCRUDController()
        {
            _attendanceCRUD = new AttendanceCRUD();
        }
        [HttpPost("AttendanceCRUD")]
        public ActionResult<AttendanceCreateDTO> createAttendance([FromBody] Attendance attendance, [FromQuery] DateTime? resquestTime)
        {
            return Ok(_attendanceCRUD.createAttendance(attendance, resquestTime));
        }
        [HttpPut("AttendanceCRUD")]
        public ActionResult<AttendanceUpdateDTO> updateAttendance([FromBody] Attendance attendance, [FromQuery] DateTime? resquestTime)
        {
            return Ok(_attendanceCRUD.updateAttendance(attendance, resquestTime));
        }
    }
}
