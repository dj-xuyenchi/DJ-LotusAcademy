using DJ_WebDesignCore.Business.AttendanceManager;
using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.ReserveCRUDDTOs;
using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.AttendanceManagerEnums;

namespace DJ_UseCaseLayer.Business.AttendanceManager
{
    public class ReserveStatistical : BaseDB, IReserveStatistical
    {
        ReserveGetDTO IReserveStatistical.getReserve(int? studentLAId)
        {
            ReserveGetDTO res = new ReserveGetDTO();
            if (studentLAId == null)
            {
                res.status = ReservesGetEnums.NULLID;
                res.ShortDetail = "Không có giá trị của studentLAId";
                return res;
            }

            StudentLA studentLA = _context.studentLAs.Find(studentLAId);
            if (studentLA == null)
            {
                res.status = ReservesGetEnums.NOTFOUND;
                res.ShortDetail = $"Không tồn tại studentLA có id là {studentLA}";
                return res;
            }

            List<ReserveGetter> lst = new List<ReserveGetter>();
            List<Reserve> reserves = _context.reserves.Where(x => x.StudentLA.Id == studentLAId).ToList();
            reserves.ForEach(reserves =>
            {
                ReserveGetter item = new ReserveGetter();
                item.ReserveReason = reserves.ReserveReason;

                item.CloseTime = reserves.CloseTime;
                item.OpenTime = reserves.OpenTime;
                item.DateDiff = reserves.DateDiff;

                item.EmployeeConfirmId = reserves.EmployeeComfirm.Id;
                EmployeeLA employeeLA = _context.employeeLA.Find(reserves.EmployeeComfirm.Id);
                item.EmployeeConfirmName = employeeLA.EmployeeLAName;

                lst.Add(item);
            });
            res.status = ReservesGetEnums.SUCCESSFULLY;
            res.ShortDetail = "Lấy dữ liệu thành công";
            res.Data = lst;
            return res;
        }
    }
}
