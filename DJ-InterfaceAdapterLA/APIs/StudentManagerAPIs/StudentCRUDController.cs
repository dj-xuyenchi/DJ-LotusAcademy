namespace DJ_InterfaceAdapterLA.APIs.StudentManagerAPIs

{
    public class StudentCRUDController : BaseAPI
    {
        private readonly IStudentCRUD _studentCRUD;

        public StudentCRUDController()
        {
            _studentCRUD = new StudentCRUD();
        }
        [HttpPost("StudentCRUD")]
        public ActionResult<StudentCreateDTO> createStudent([FromBody] StudentLA newData)
        {
            return Ok(_studentCRUD.createStudent(newData));
        }
        [HttpGet("timtheoid")]
        public ActionResult<StudentFindByIdDTO> findStudentById(int? studentId)
        {
            return Ok(_studentCRUD.findStudentById(studentId));
        }
    }
}
