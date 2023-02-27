namespace DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceProgressStatisticalDTOs
{
    public class AttendanceProgressStatisticalGetter
    {
        public string? SortNumber { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int? SlotId { get; set; }
        public string? SlotName { get; set; }
        public string? Status { get; set; }
        public string? Reason { get; set; }
        public DateTime? ComfirmDateTime { get; set; }
        public int? EmployeeLAId { get; set; }
        public string? ConfirmEmployee { get; set; }
    }
}
