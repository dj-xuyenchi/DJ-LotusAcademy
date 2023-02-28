using DJ_WebDesignCore.Business.AttendanceManager;
using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceCRUDDTOs;
using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.AttendanceManagerEnums.AttendanceEnums;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace DJ_UseCaseLayer.Business.AttendanceManager
{
    public class AttendanceCRUD : BaseDB, IAttendanceCRUD
    {
        private void UpdateStudentLA(StudentLA currentStudent = null, StudentLA studentBefore = null)
        {
            if (studentBefore != null)
            {
                List<Attendance> lstLeavePermissionBefore = _context.attendance.Where(x => x.StudentLAId == studentBefore.Id && x.AttendanceTypeStatusId == 8).ToList();
                List<Attendance> lstUnauthorizedAbsencesBefore = _context.attendance.Where(x => x.StudentLAId == studentBefore.Id && x.AttendanceTypeStatusId == 9).ToList();
                List<Attendance> lstLateMinuteBefore = _context.attendance.Where(x => x.StudentLAId == studentBefore.Id).ToList();

                studentBefore.UnactiveTotal = lstLeavePermissionBefore.Count;
                studentBefore.UnauthorizedAbsencesTotal = lstUnauthorizedAbsencesBefore.Count;
                studentBefore.LateMinuteTotal = lstLateMinuteBefore.Sum(x => x.LateMinuteTotal);
                _context.Update(studentBefore);
                _context.SaveChanges();
            }

            if (currentStudent != null)
            {
                List<Attendance> lstLeavePermissionCurrent = _context.attendance.Where(x => x.StudentLAId == currentStudent.Id && x.AttendanceTypeStatusId == 8).ToList();
                List<Attendance> lstUnauthorizedAbsencesCurrent = _context.attendance.Where(x => x.StudentLAId == currentStudent.Id && x.AttendanceTypeStatusId == 9).ToList();
                List<Attendance> lstLateMinuteCurrent = _context.attendance.Where(x => x.StudentLAId == currentStudent.Id).ToList();
                currentStudent.UnactiveTotal = lstLeavePermissionCurrent.Count;
                currentStudent.UnauthorizedAbsencesTotal = lstUnauthorizedAbsencesCurrent.Count;
                currentStudent.LateMinuteTotal = lstLateMinuteCurrent.Sum(x => x.LateMinuteTotal);
                _context.Update(currentStudent);
                _context.SaveChanges();
            }
        }
        AttendanceUpdateDTO IAttendanceCRUD.updateAttendance(Attendance newData, DateTime? requestTime)
        {
            AttendanceUpdateDTO res = new AttendanceUpdateDTO();

            using (var transaction = _context.Database.BeginTransaction())
            {

                if (newData.Id == null)
                {
                    res.Status = AttendanceEnum.NULLID;
                    res.ShortDetail = "Không tìm thấy attendance id";
                    return res;
                }
                Attendance attendance = _context.attendance.Find(newData.Id);
                if (attendance == null)
                {
                    res.Status = AttendanceEnum.FAILED;
                    res.ShortDetail = $"Không tồn tại attendance có id là {newData.Id}";
                    return res;
                }

                // Student Before -> Không được xóa dòng này
                StudentLA studentBefore = _context.studentLAs.Find(attendance.StudentLAId);

                if (newData.StudentLAId != null)
                {
                    if (_context.studentLAs.Find(newData.StudentLAId) == null)
                    {
                        res.Status = AttendanceEnum.FAILED;
                        res.ShortDetail = $"Không tồn tại student có id là {newData.StudentLAId}";
                        return res;
                    }
                    attendance.StudentLAId = newData.StudentLAId;
                    _context.Update(attendance);
                    _context.SaveChanges();
                }

                // Current Student -> Không được xóa dòng này
                StudentLA currentStudent = _context.studentLAs.Find(attendance.StudentLAId);

                if (newData.EmployeeComfirmId == null)
                {
                    res.Status = AttendanceEnum.FAILED;
                    res.ShortDetail = $"Chưa nhận được id nhân viên";
                    return res;
                }
                EmployeeLA employeeLA = _context.employeeLA.Find(newData.EmployeeComfirmId);
                if (employeeLA == null)
                {
                    res.Status = AttendanceEnum.FAILED;
                    res.ShortDetail = $"Không tồn tại nhân viên có id là {newData.EmployeeComfirmId}";
                    return res;
                }
                if (employeeLA.EmployeeRoleId != 2)
                {
                    res.Status = AttendanceEnum.FAILED;
                    res.ShortDetail = $"Bạn không có quyền truy cập vào thông tin học sinh, vui lòng liên hệ với admin";
                    return res;
                }
                attendance.EmployeeComfirmId = newData.EmployeeComfirmId;
                _context.Update(attendance);
                _context.SaveChanges();

                AttendanceTypeStatus attendanceTypeStatus;
                if (newData.AttendanceTypeStatusId != null)
                {
                    attendanceTypeStatus = _context.attendanceTypeStatuses.Find(newData.AttendanceTypeStatusId);
                    if (attendanceTypeStatus == null)
                    {
                        res.Status = AttendanceEnum.FAILED;
                        res.ShortDetail = $"Không tồn tại attendace type status có id là {newData.AttendanceTypeStatusId}";
                        return res;
                    }
                    if (attendanceTypeStatus.Id == 8)
                    {
                        if (newData.UnactiveReason == null)
                        {
                            res.Status = AttendanceEnum.FAILED;
                            res.ShortDetail = $"Vui lòng điền lý do nghỉ";
                            return res;
                        }
                        attendance.UnactiveReason = newData.UnactiveReason;
                        _context.Update(attendance);
                        _context.SaveChanges();
                    }
                    else
                    {
                        attendance.UnactiveReason = null;
                        _context.Update(attendance);
                        _context.SaveChanges();
                    }
                    attendance.AttendanceTypeStatusId = newData.AttendanceTypeStatusId;
                    _context.Update(attendance);
                    _context.SaveChanges();
                }

                if (newData.IsLate == true)
                {
                    if (requestTime == null)
                    {
                        res.Status = AttendanceEnum.FAILED;
                        res.ShortDetail = "Vui lòng điền thời gian điểm danh cần sửa";
                        return res;
                    }
                    attendance.IsLate = true;
                    TimeSpan t = requestTime.Value - attendance.CreateDateTime.Value;
                    attendance.LateMinuteTotal = Convert.ToInt32(t.TotalMinutes);
                    attendance.ActiveRealTime = requestTime;
                    _context.Update(attendance);
                    _context.SaveChanges();
                }
                else
                {
                    attendance.IsLate = null;
                    attendance.LateMinuteTotal = null;
                    attendance.ActiveRealTime = null;
                    _context.Update(attendance);
                    _context.SaveChanges();
                }

                if (newData.AttendanceSlotId != null)
                {
                    AttendanceSlot attendanceSlot = _context.attendanceSlot.Find(newData.AttendanceSlotId);
                    if (attendanceSlot == null)
                    {
                        res.Status = AttendanceEnum.FAILED;
                        res.ShortDetail = $"Không tồn tại attendance slot có id là {newData.AttendanceSlotId}";
                        return res;
                    }

                    attendance.AttendanceSlotId = newData.AttendanceSlotId;
                    _context.Update(attendance);
                    _context.SaveChanges();
                }

                UpdateStudentLA(currentStudent, studentBefore);
                transaction.Commit();

                res.Status = AttendanceEnum.SUCCESSFULLY;
                res.ShortDetail = $"Sửa điểm danh thành công!";
                return res;
            }
        }
        AttendanceCreateDTO IAttendanceCRUD.createAttendance(Attendance newData, DateTime? resquestTime)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                AttendanceCreateDTO res = new AttendanceCreateDTO();
                if (newData.StudentLAId == null)
                {
                    res.Status = AttendanceEnum.NULLID;
                    res.ShortDetail = "Không tìm thấy học viên id";
                    return res;
                }
                StudentLA studentLA = _context.studentLAs.Find(newData.StudentLAId);
                if (studentLA == null)
                {
                    res.Status = AttendanceEnum.FAILED;
                    res.ShortDetail = $"Không tồn tại học viên có id là {newData.StudentLAId}";
                    return res;
                }

                if (resquestTime == null)
                {
                    res.Status = AttendanceEnum.FAILED;
                    res.ShortDetail = "Vui lòng điền request time";
                    return res;
                }
                int day = resquestTime.Value.Day;
                int month = resquestTime.Value.Month;
                int year = resquestTime.Value.Year;

                if (day != DateTime.Now.Day || month != DateTime.Now.Month || year != DateTime.Now.Year)
                {
                    res.Status = AttendanceEnum.FAILED;
                    res.ShortDetail = "Thời gian tạo điểm danh không chính xác";
                    return res;
                }
                newData.ComfirmDateTime = DateTime.Now;

                if (newData.EmployeeComfirmId == null)
                {
                    res.Status = AttendanceEnum.NULLID;
                    res.ShortDetail = "Không tìm thấy nhân viên id";
                    return res;
                }

                EmployeeLA employeeLA = _context.employeeLA.Find(newData.EmployeeComfirmId);
                if (employeeLA == null)
                {
                    res.Status = AttendanceEnum.FAILED;
                    res.ShortDetail = $"Không tồn tại nhân viên có id là ${newData.EmployeeComfirmId}";
                    return res;
                }

                if (newData.AttendanceTypeStatusId == 8)
                {
                    if (newData.UnactiveReason == null)
                    {
                        res.Status = AttendanceEnum.FAILED;
                        res.ShortDetail = $"Vui lòng điền lý do nghỉ";
                        return res;
                    }
                }

                if (newData.AttendanceSlotId == null)
                {
                    res.Status = AttendanceEnum.NULLID;
                    res.ShortDetail = "Không nhận được attendance slot id";
                    return res;
                }
                AttendanceSlot attendanceSlot = _context.attendanceSlot.Find(newData.AttendanceSlotId);
                if (attendanceSlot == null)
                {
                    res.Status = AttendanceEnum.FAILED;
                    res.ShortDetail = $"Không tồn tại attendance slot có id {newData.AttendanceSlotId}";
                    return res; 
                }

                newData.CreateDateTime = resquestTime;

                _context.attendance.Add(newData);
                _context.SaveChanges();
                UpdateStudentLA(studentLA);

                transaction.Commit();
                res.Status = AttendanceEnum.SUCCESSFULLY;
                res.ShortDetail = "Thêm điểm danh thành công!";
                return res;
            }
        }
    }
}
