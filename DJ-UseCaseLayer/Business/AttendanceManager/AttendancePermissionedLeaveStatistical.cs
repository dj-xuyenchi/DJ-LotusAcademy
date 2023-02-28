using DJ_WebDesignCore.Business.AttendanceManager;
using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendancePermissionedLeave;
using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.AttendanceManagerEnums;

namespace DJ_UseCaseLayer.Business.AttendanceManager
{
    public class AttendancePermissionedLeaveStatistical : BaseDB, IAttendancePermissonedLeaveStatistical
    {
        AttendancePermissionedLeaveGetDTO IAttendancePermissonedLeaveStatistical.getAttendancePermissonedLeave(int? studentLAId)
        {
            AttendancePermissionedLeaveGetDTO res = new AttendancePermissionedLeaveGetDTO();
            if (studentLAId == null)
            {
                res.Status = AttendancePermissionedLeaveGetEnum.NULLID;
                res.ShortDetail = "Không có giá trị của studentLAId";
                return res;
            }

            StudentLA studentLA = _context.studentLAs.Find(studentLAId);
            if (studentLA == null)
            {
                res.Status = AttendancePermissionedLeaveGetEnum.NOTFOUND;
                res.ShortDetail = $"Không tồn tại studentLA có id là {studentLAId}";
                return res;
            }

            List<AttendancePermissionedLeaveGetter> lst = new List<AttendancePermissionedLeaveGetter>();
            List<Attendance> attendances = _context.attendance.Where(x => x.StudentLAId == studentLAId).ToList();
            attendances.ForEach(attendances =>
            {
                if (attendances.AttendanceTypeStatusId == 8)
                {
                    AttendancePermissionedLeaveGetter item = new AttendancePermissionedLeaveGetter();
                    item.DayOff = attendances.ComfirmDateTime;

                    AttendanceTypeStatus attendanceTypeStatus = _context.attendanceTypeStatuses.Find(attendances.AttendanceTypeStatusId);
                    item.OffShitf = attendanceTypeStatus.AttendanceTypeName;

                    item.Reason = attendances.UnactiveReason;

                    item.ConfirmDateTime = attendances.ComfirmDateTime;

                    item.EmployeeConfirmId = attendances.EmployeeConfirmId;
                    EmployeeLA employeeLA = _context.employeeLA.Find(attendances.EmployeeConfirmId);
                    item.EmployeeConfirmName = employeeLA.EmployeeLAName;
                    lst.Add(item);
                }
            });

            res.Status = AttendancePermissionedLeaveGetEnum.SUCCESSFULLY;
            res.ShortDetail = "Lấy dữ liệu thành công";
            res.Data = lst;
            return res;

        }
    }
}
