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
                item.createDateTime = attendance.CreateDateTime;
                item.slotId = attendance.AttendanceSlotId;
                AttendanceSlot attendanceSlot = _context.attendanceSlots.Find(attendance.AttendanceSlotId);
                item.slot = attendanceSlot.AttendanceSlotName;
                if (attendance.IsLate == null || attendance.IsLate == false)
                {
                    if (attendance.AttendanceTypeStatusId == 8)
                    {
                        item.activeStatus = "Nghỉ có phép";
                        item.reason = attendance.UnactiveReason;
                    }
                    else if (attendance.AttendanceTypeStatusId == 9)
                    {
                        item.activeStatus = "Nghỉ không phép";
                        item.reason = attendance.UnactiveReason;
                    }
                    else
                    {
                        item.activeStatus = "Đi học đúng giờ";
                    }
                }
                else
                {
                    item.activeStatus = $"Đi học muộn - {attendance.LateMinuteTotal} phút";
                    item.reason = attendance.UnactiveReason;
                }

                item.confirmDateTime = attendance.ComfirmDateTime;
                item.employeeConfirmId = attendance.EmployeeConfirmId;
                EmployeeLA employeeLA = _context.employeeLA.Find(attendance.EmployeeConfirmId);
                item.employeeConfirm = employeeLA.EmployeeLAName;

                lst.Add(item);
            });

            res.Status = AttendanceProgressStatisticalEnum.SUCCESSFULLY;
            res.ShortDetail = "Lấy dữ liệu thành công!";
            res.Data = lst;
            return res;
        }
    }
}
