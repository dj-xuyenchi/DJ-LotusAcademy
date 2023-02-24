using DJ_WebDesignCore.Business.AttendanceManager;
using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceUnauthorizedAbsences;
using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.AttendanceManagerEnums.AttendanceUnauthorizedAbsencesStatisticalEnums;

namespace DJ_UseCaseLayer.Business.AttendanceManager
{
    public class AttendanceUnauthorizedAbsencesStatistical : BaseDB, IAttendanceUnauthorizedAbsencesStatistical
    {
        AttendanceUnauthorizedAbsencesGetDTO IAttendanceUnauthorizedAbsencesStatistical.getAttendanceUnauthorizedAbsences(int? studentLAId)
        {
            AttendanceUnauthorizedAbsencesGetDTO res = new AttendanceUnauthorizedAbsencesGetDTO();

            if (studentLAId == null)
            {
                res.Status = AttendanceUnauthorizedAbsencesStatisticalEnum.NULLID;
                res.ShortDetail = "Không nhận được student LA id";
                return res;
            }
            StudentLA studentLA = _context.studentLAs.Find(studentLAId);
            if (studentLA == null)
            {
                res.Status = AttendanceUnauthorizedAbsencesStatisticalEnum.NOTFOUND;
                res.ShortDetail = $"Không tồn tại student LA có id là {studentLAId}";
                return res;
            }
            List<AttendanceUnauthorizedAbsencesGetter> lst = new List<AttendanceUnauthorizedAbsencesGetter>();
            List<Attendance> attendance = _context.attendance.Where(x => x.StudentLAId == studentLAId).ToList();
            attendance.ForEach(attendance =>
            {
                if (attendance.AttendanceTypeStatusId == 9)
                {
                    AttendanceUnauthorizedAbsencesGetter item = new AttendanceUnauthorizedAbsencesGetter();
                    item.Dayoff = attendance.ComfirmDateTime;

                    AttendanceTypeStatus attendanceTypeStatus = _context.attendanceTypeStatuses.Find(attendance.AttendanceTypeStatusId);
                    item.OffShift = attendanceTypeStatus.AttendanceTypeName;

                    item.ConfirmDateTime = attendance.ComfirmDateTime;
                    item.EmployeeConfirmId = attendance.EmployeeComfirmId;

                    EmployeeLA employeeLA = _context.employeeLA.Find(attendance.EmployeeComfirmId);
                    item.EmployeeConfirmName = employeeLA.EmployeeLAName;
                    lst.Add(item);
                }
            });

            res.Status = AttendanceUnauthorizedAbsencesStatisticalEnum.SUCCESSFULLY;
            res.Data = lst;
            res.ShortDetail = "Lấy dữ liệu thành công!";
            return res;
        }
    }
}
