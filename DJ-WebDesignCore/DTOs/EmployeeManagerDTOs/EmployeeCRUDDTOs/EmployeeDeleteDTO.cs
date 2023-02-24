using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Enums.EmployeeManagerEnums;

namespace DJ_WebDesignCore.DTOs.EmployeeManagerDTOs.EmployeeCRUDDTOs
{
    public class EmployeeDeleteDTO
    {
        public EmployeeDeleteEnums? Status { get; set; }
        public EmployeeLA? Data { get; set; }
        public string? ShortDetail { get; set; }
    }
}
