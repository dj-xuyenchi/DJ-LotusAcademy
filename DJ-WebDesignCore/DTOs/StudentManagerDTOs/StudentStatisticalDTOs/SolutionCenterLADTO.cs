using System;
namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs
{
	public class SolutionCenterLADTO
	{
		public int? TotalStudentLA { get; set; }
        public double? TotalStudentLAMonthPercent { get; set; }
        public int? OfflineStudentLA { get; set; }
        public double? OfflineStudentLAMonthPercent { get; set; }
        public int? OnlineStudentLA { get; set; }
        public double? OnlineStudentLAMonthPercent { get; set; }
        public int? ReserveStudentLA { get; set; }
        public double? ReserveStudentLAMonthPercent { get; set; }
    }
}

