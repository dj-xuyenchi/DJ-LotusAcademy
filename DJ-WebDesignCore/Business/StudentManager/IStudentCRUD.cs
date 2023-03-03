namespace DJ_WebDesignCore.Business.StudentManager
{
    public interface IStudentCRUD
    {
        StudentCreateDTO createStudent(StudentLA newData);
        StudentDeleteDTO deleteStudent(int? studentId);
        StudentUpdateDTO updateStudent(StudentLA newData);
        StudentFindByIdDTO findStudentById(int? studentId);

    }
}
