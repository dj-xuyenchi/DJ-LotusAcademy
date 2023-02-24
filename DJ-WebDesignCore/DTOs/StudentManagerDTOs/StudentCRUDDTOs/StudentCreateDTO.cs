using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.StudentManagerEnums;

namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentCRUDDTOs
{
    public class StudentCreateDTO
    {
        public StudentCreateEnums? Status { get; set; }
        public StudentLA? Data { get; set; }
        public string? ShortDetail { get; set; }
    }
}
