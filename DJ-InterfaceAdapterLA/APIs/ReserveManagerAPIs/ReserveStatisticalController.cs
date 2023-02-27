using DJ_UseCaseLayer.Business.AttendanceManager;
using DJ_WebDesignCore.Business.AttendanceManager;
using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.ReserveCRUDDTOs;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.ReserveAPIs
{
    public class ReserveStatisticalController : BaseAPI
    {
        public readonly IReserveStatistical _getReserveCRUD;
        public ReserveStatisticalController()
        {
            _getReserveCRUD = new ReserveStatistical();
        }
        [HttpGet("ReserveStatistical/{studentLAId}")]
        public ActionResult<ReserveGetDTO> getReserve(int? studentLAId)
        {
            return Ok(_getReserveCRUD.getReserve(studentLAId));
        }
    }
}
