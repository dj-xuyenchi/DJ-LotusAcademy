namespace DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceUnauthorizedAbsences
{
    public class AttendanceUnauthorizedAbsencesGetter
    {
        public DateTime? Dayoff { get; set; }
        public string? OffShift { get; set; }
        public DateTime? ConfirmDateTime { get; set; }
        public int? EmployeeConfirmId { get; set; }
        public string? EmployeeConfirmName { get; set; }
    }
}
