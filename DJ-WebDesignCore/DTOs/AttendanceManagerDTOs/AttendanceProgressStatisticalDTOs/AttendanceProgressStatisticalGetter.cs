namespace DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceProgressStatisticalDTOs
{
    public class AttendanceProgressStatisticalGetter
    {
        //    sortNumber:string;
        //createDateTime:string;
        //slot:string;
        //activeStatus:string;
        //reason:string;
        //confirmDateTime:string;
        //employeeConfirm:string;
        public string? sortNumber { get; set; }
        public DateTime? createDateTime { get; set; }
        public int? slotId { get; set; }
        public string? slot { get; set; }
        public string? activeStatus { get; set; }
        public string? reason { get; set; }
        public DateTime? confirmDateTime { get; set; }
        public int? employeeConfirmId { get; set; }
        public string? employeeConfirm { get; set; }
    }
}
