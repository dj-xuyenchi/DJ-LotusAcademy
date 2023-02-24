using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceCRUDDTOs;
using DJ_WebDesignCore.Entites.Business;

namespace DJ_WebDesignCore.Business.AttendanceManager
{
    public interface IAttendanceCRUD
    {
        AttendanceUpdateDTO updateAttendance(Attendance newData, DateTime? requestTime);
        AttendanceCreateDTO createAttendance(Attendance newData, DateTime? resquestTime);
    }
}
