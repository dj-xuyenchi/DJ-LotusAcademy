using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Enums.StudentActiveManagerEnums;

namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs
{
    public class StudentLADTO
    {
        public int? StudentLAId { get; set; }
        public string? StudentLAName { get; set; }
        public string? StudentLASdt { get; set; }
        public IEnumerable<string>? StudentCourses { get; set; }
        public int? EmployeeLAId { get; set; }
        public string? Email { get; set; }
        public string? AddressDetail { get; set; }
        public string? BirthDay { get; set; }
        public string? Gender { get; set; }
        public string? Job { get; set; }
        public string? ZaloUrl { get; set; }
        public string? Facebook { get; set; }
        public string? EmployeeLAName { get; set; }
        public string? Status { get; set; }

    }
}
