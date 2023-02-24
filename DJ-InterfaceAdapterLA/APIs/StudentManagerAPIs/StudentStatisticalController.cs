using DJ_UseCaseLayer.Business.StudentManager;
using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.StudentManagerAPIs
{
    public class StudentStatisticalController : BaseAPI
    {
        private readonly IStudentStatistical _studentStatistical;

        public StudentStatisticalController()
        {
            _studentStatistical = new StudentStatistical();
        }
        [HttpGet("StudentStatistical/{page}")]
        public ActionResult<StudentLAPagingDTO> getListStudentByPaging([FromQuery] int page)
        {
            return Ok(_studentStatistical.getListStudentLA(page));
        }

    }
}
