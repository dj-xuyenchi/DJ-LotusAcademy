namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs
{
    public class StatisticsStudyTimePagingDTO
    {
        public int Status { get; set; }
        public IEnumerable<StatisticsStudyTimeDTO> Data { get; set; }
        public string? Mes { get; set; }
    }
}
