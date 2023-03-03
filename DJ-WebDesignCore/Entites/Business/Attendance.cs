namespace DJ_WebDesignCore.Entites.Business
{
    public class Attendance : BaseEntity
    {
        public int? StudentLAId { get; set; }
        public StudentLA? StudentLA { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? ComfirmDateTime { get; set; }
        public string? UnactiveReason { get; set; }
        public int? EmployeeConfirmId { get; set; }
        public EmployeeLA? EmployeeConfirm { get; set; }
        public int? AttendanceTypeStatusId { get; set; }
        public AttendanceTypeStatus? AttendanceTypeStatus { get; set; }
        public DateTime? ActiveRealTime { get; set; }
        public bool? IsLate { get; set; }
        public int? LateMinuteTotal { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int? AttendanceSlotId { get; set; }
        public AttendanceSlot? AttendanceSlot { get; set; }
    }
}

