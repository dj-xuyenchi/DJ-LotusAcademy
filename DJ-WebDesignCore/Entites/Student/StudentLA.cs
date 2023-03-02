using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Properties.Address;
using System.ComponentModel.DataAnnotations.Schema;

namespace DJ_WebDesignCore.Entites.Student
{
    public class StudentLA : BaseEntity
    {
        public string? StudentLAName { get; set; }
        public string? StudentLAUserName { get; set; }
        public string? StudentLAPassword { get; set; }
        public string? StudentLASdt { get; set; }
        public byte[]? StudentLAAvatar { get; set; }
        public string? Email { get; set; }
        public string? ZaloUrl { get; set; }
        public string? FacebookUrl { get; set; }
        public int? StudentDatalogId { get; set; }
        public StudentDatalog? StudentDatalog { get; set; }
        public string? WardCode { get; set; }
        [ForeignKey("WardCode")]
        public Ward? Ward { get; set; }
        public string? DistrictCode { get; set; }
        [ForeignKey("DistrictCode")]
        public District? District { get; set; }
        public string? ProvinceCode { get; set; }
        [ForeignKey("ProvinceCode")]
        public Province? Province { get; set; }
        public DateTime? StudentLABirthDay { get; set; }
        public int? SaleId { get; set; }
        public EmployeeLA? Sale { get; set; }
        public int? GenderId { get; set; }
        public Gender? Gender { get; set; }
        public string? InsightName { get; set; }
        public DateTime? CreateAccountDatetime { get; set; }
        public int? StudentStatusId { get; set; }
        public StudentStatus? StudentStatus { get; set; }
        public float? HolidayTotal { get; set; }
        public float? ReserveTotal { get; set; }
        public float? UnauthorizedAbsencesTotal { get; set; }
        public int? LateMinuteTotal { get; set; }
        public int? UnactiveTotal { get; set; }
        public IEnumerable<StudentCourse> studentCourses { get; set; }
    }
}
