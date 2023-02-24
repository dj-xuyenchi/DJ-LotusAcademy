using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Properties.Address;
using System.ComponentModel.DataAnnotations.Schema;

namespace DJ_WebDesignCore.Entites.Employee
{
    public class EmployeeLA : BaseEntity
    {
        public string? EmployeeLAUserName { get; set; }
        public string? EmployeeLAPassword { get; set; }
        public int? EmployeeRoleId { get; set; }
        public EmployeeRole? EmployeeRole { get; set; }
        //  public byte[]? EmployeeAvatar { get; set; }
        public string? WardCode { get; set; }
        [ForeignKey("WardCode")]
        public Ward? Ward { get; set; }
        public string? DistrictCode { get; set; }
        [ForeignKey("DistrictCode")]
        public District? District { get; set; }
        public string? ProvinceCode { get; set; }
        [ForeignKey("ProvinceCode")]
        public Province? Province { get; set; }
        public int? GenderId { get; set; }
        public Gender? Gender { get; set; }
        public string? NumberPhone { get; set; }
        public string? FacebookUrl { get; set; }
        public string? SkyUrl { get; set; }
        public string? EmployeeLAName { get; set; }
        public DateTime? EmployeeLABirthDay { get; set; }
        public int? EmployeeStatusId { get; set; }
        public EmployeeStatus? EmployeeStatus { get; set; }
    }
}
