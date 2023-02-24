using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Enums.EmployeeManagerEnums;

namespace DJ_WebDesignCore.DTOs.EmployeeManagerDTOs.EmployeeCRUDDTOs
{
    public class EmployeeUpdateDTO
    {
        public EmployeeUpdateEnums? Status { get; set; }
        public EmployeeLA? Data { get; set; }
        public string? ShortDetail { get; set; }
    }
}
