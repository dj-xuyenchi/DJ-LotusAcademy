using DJ_WebDesignCore.Business.AttendanceManager;
using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceProgressStatisticalDTOs;
using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.AttendanceManagerEnums.AttendanceProgressStatisticalEnums;

namespace DJ_UseCaseLayer.Business.AttendanceManager
{
    public class AttendanceProgressStatistical : BaseDB, IAttendanceProgressStatistical
    {
        AttendanceProgressStatisticalGetDTO IAttendanceProgressStatistical.getAttendanceProgressStatistical(int? studendId)
        {
            AttendanceProgressStatisticalGetDTO res = new AttendanceProgressStatisticalGetDTO();

            if (studendId == null)
            {
                res.Status = AttendanceProgressStatisticalEnum.NULLID;
                res.ShortDetail = $"Không nhận được student có id";
                return res;
            }
            StudentLA studentLA = _context.studentLAs.Find(studendId);
            if (studentLA == null)
            {
                res.Status = AttendanceProgressStatisticalEnum.NOTFOUND;
                res.ShortDetail = $"Không tồn tại student có id là {studendId}";
                return res;
            }

            List<AttendanceProgressStatisticalGetter> lst = new List<AttendanceProgressStatisticalGetter>();
            List<Attendance> attendances = _context.attendance.Where(x => x.StudentLAId == studendId).ToList();
            attendances.ForEach(attendance =>
            {
                AttendanceProgressStatisticalGetter item = new AttendanceProgressStatisticalGetter();
                item.CreateDateTime = attendance.CreateDateTime;
                item.SlotId = attendance.AttendanceSlotId;
                AttendanceSlot attendanceSlot = _context.attendanceSlot.Find(attendance.AttendanceSlotId);
                item.SlotName = attendanceSlot.AttendanceSlotName;
                if (attendance.IsLate == null || attendance.IsLate == false)
                {
                    if (attendance.AttendanceTypeStatusId == 8)
                    {
                        item.Status = "Nghỉ có phép";
                        item.Reason = attendance.UnactiveReason;
                    }
                    else if (attendance.AttendanceTypeStatusId == 9)
                    {
                        item.Status = "Nghỉ không phép";
                        item.Reason = attendance.UnactiveReason;
                    }
                    else
                    {
                        item.Status = "Đi học đúng giờ";
                    }
                }
                else
                {
                    item.Status = $"Đi học muộn - {attendance.LateMinuteTotal} phút";
                    item.Reason = attendance.UnactiveReason;
                }

                item.ComfirmDateTime = attendance.ComfirmDateTime;
                item.EmployeeLAId = attendance.EmployeeComfirmId;
                EmployeeLA employeeLA = _context.employeeLA.Find(attendance.EmployeeComfirmId);
                item.ConfirmEmployee = employeeLA.EmployeeLAName;

                lst.Add(item);
            });

            res.Status = AttendanceProgressStatisticalEnum.SUCCESSFULLY;
            res.ShortDetail = "Lấy dữ liệu thành công!";
            res.Data = lst;
            return res;
        }
    }
}
