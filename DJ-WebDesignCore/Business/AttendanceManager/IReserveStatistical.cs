using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.ReserveCRUDDTOs;

namespace DJ_WebDesignCore.Business.AttendanceManager
{
    public interface IReserveStatistical
    {
        ReserveGetDTO getReserve(int? studentLAId);
    }
}
