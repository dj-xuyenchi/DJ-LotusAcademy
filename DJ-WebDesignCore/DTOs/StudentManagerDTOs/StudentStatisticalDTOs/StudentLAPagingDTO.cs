using DJ_WebDesignCore.Enums.StatisticsEnums;

namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs
{
    public class StudentLAPagingDTO
    {
        public StatisticStatusAPIEnum Status { get; set; }
        public IEnumerable<StudentLADTO> Data { get; set; }
        public SolutionCenterLADTO SolutionCenterLADTO { get; set; }
        public string? Mes { get; set; }
    }
}
