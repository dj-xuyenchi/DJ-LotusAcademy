using DJ_UseCaseLayer.Business.StudentManager;
using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentDetailStatisticalDTO;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.StudentManagerAPIs
{
    public class StudentDetailStatisticalController : BaseAPI
    {
        public readonly IStudentDetailStatistical _getStudentDetailStatistical;
        public StudentDetailStatisticalController()
        {
            _getStudentDetailStatistical = new StudentDetailStatistical();
        }
        [HttpGet("StudentDetailStatistical")]
        public ActionResult<StudentDetailStatisticalGetDTO> getStudentDetailStatistical([FromQuery] int? studentLAId)
        {
            return Ok(_getStudentDetailStatistical.getStudentDetailStatistical(studentLAId));
        }
    }
}
