using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentCRUDDTOs;
using DJ_WebDesignCore.Entites.Student;

namespace DJ_WebDesignCore.Business.StudentManager
{
    public interface IStudentCRUD
    {
        StudentCreateDTO createStudent
        StudentDeleteDTO deleteStudent(int? studentId);
        StudentUpdateDTO updateStudent(StudentLA newData);
        StudentFindByIdDTO findStudentById(int? studentId);

    }
}
