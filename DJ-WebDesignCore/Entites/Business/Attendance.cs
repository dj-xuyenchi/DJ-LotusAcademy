using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Student;

namespace DJ_WebDesignCore.Entites.Business
{
    public class Attendance : BaseEntity
    {
        public int? StudentLAId { get; set; }
        public StudentLA? StudentLA { get; set; }
        public DateTime? ComfirmDateTime { get; set; }
        public string? UnactiveReason { get; set; }
        public int? EmployeeComfirmId { get; set; }
        public EmployeeLA? EmployeeComfirm { get; set; }
        public int? AttendanceTypeStatusId { get; set; }
        public AttendanceTypeStatus? AttendanceTypeStatus { get; set; }
        public DateTime? ActiveRealTime { get; set; }
        public bool? IsLate { get; set; }
        public int? LateMinuteTotal { get; set; }

    }
}

