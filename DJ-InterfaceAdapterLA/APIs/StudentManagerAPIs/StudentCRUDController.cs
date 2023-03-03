using DJ_UseCaseLayer.Business.StudentManager;
using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentCRUDDTOs;
using DJ_WebDesignCore.Entites.Student;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.StudentManagerAPIs

{
    [Route("api/hocvien/")]
    public class StudentCRUDController : BaseAPI
    {
        private readonly IStudentCRUD _studentCRUD;

        public StudentCRUDController()
        {
            _studentCRUD = new StudentCRUD();
        }
        [HttpPost("createStudent")]
        public ActionResult<StudentCreateDTO> createStudent([FromBody] StudentCreateLA newData)
        {
            return Ok(_studentCRUD.createStudent(newData));
        }
    }
}
