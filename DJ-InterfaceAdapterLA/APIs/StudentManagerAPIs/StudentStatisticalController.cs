using DJ_UseCaseLayer.Business.StudentManager;
using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentCRUDDTOs;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs;
using DJ_WebDesignCore.Entites.Student;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.StudentManagerAPIs
{
    [Route("api/hocvien/")]
    public class StudentStatisticalController:BaseAPI
    {
        private readonly IStudentStatistical _studentStatistical;

        public StudentStatisticalController()
        {
            _studentStatistical = new StudentStatistical();
        }
        [HttpGet("paging")]
        public ActionResult<StudentLAPagingDTO> getListStudentByPaging([FromQuery] int page)
        {
            return Ok(_studentStatistical.getListStudentLA(page));
        }
        [HttpGet("studentdetailbyid")]
        public ActionResult<StudentLAPagingDTO> getStudentDetailById([FromQuery] int id)
        {
            return Ok(_studentStatistical.getStudentDetailById(id));
        }
    }
}
