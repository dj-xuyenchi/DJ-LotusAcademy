namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs
{
    public class StudentLAPagingDTO
    {
        public int Status { get; set; }
        public IEnumerable<StudentLADTO> Data { get; set; }
        public string? Mes { get; set; }
    }
}
