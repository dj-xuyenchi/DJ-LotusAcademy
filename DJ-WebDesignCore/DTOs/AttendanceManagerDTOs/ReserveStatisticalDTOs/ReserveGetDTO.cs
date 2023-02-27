using DJ_WebDesignCore.Enums.AttendanceManagerEnums;

namespace DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.ReserveCRUDDTOs
{
    public class ReserveGetDTO
    {
        public ReservesGetEnums status { get; set; }
        public string? ShortDetail { get; set; }
        public List<ReserveGetter> Data { get; set; }
    }
}
