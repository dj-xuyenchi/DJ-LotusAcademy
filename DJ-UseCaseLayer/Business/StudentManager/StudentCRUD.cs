using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentCRUDDTOs;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Properties.Address;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.StudentManagerEnums;

namespace DJ_UseCaseLayer.Business.StudentManager
{
    public class StudentCRUD : BaseDB, IStudentCRUD
    {
        StudentFindByIdDTO IStudentCRUD.findStudentById(int? studentId)
        {
            StudentFindByIdDTO res = new StudentFindByIdDTO();
            StudentLA data;
            if (studentId == null)
            {
                res.Status = StudentReadEnums.NULLID;
                res.ShortDetail = "Không nhận được id cần tìm";
                return res;
            }
            data = _context.studentLAs.Find(studentId);
            if (data == null)
            {
                res.Status = StudentReadEnums.NOTFOUND;
                res.ShortDetail = "Không tồn tại học viên có id là: " + studentId;
                return res;
            }
            res.Status = StudentReadEnums.FOUND;
            res.Data = data;
            res.ShortDetail = "Tìm thấy!";
            return res;

        }

        StudentCreateDTO IStudentCRUD.createStudent(StudentLA newData)
        {
            StudentCreateDTO res = new StudentCreateDTO();

            if (newData.StudentLAName == null)
            {
                res.Status = StudentCreateEnums.NOT_VALUE;
                res.ShortDetail = "Trường họ tên phải là bắt buộc";
                return res;
            }
            if (newData.StudentLAName.Length < 6)
            {
                res.Status = StudentCreateEnums.LENGTH_TOO_SHORT;
                res.ShortDetail = "Họ tên tối thiểu phải là 6 ký tự";
                return res;
            }

            if (newData.WardCode == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chưa nhận được ward id";
                return res;
            }
            Ward ward = _context.wards.Find(newData.WardCode);
            if (ward == null)
            {
                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = $"Không tồn tại ward có id là {newData.WardCode}";
                return res;
            }

            if (newData.DistrictCode == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chưa nhận được district id";
                return res;
            }
            District district = _context.districts.Find(newData.DistrictCode);
            if (district == null)
            {
                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = $"Không tồn tại district có id là {newData.DistrictCode}";
                return res;
            }

            if (newData.ProvinceCode == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chưa nhận được province id";
                return res;
            }
            Province province = _context.provinces.Find(newData.ProvinceCode);
            if (province == null)
            {
                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = $"Không tồn tại province có id là {newData.ProvinceCode}";
                return res;
            }

            if (newData.StudentLABirthDay == null)
            {
                res.Status = StudentCreateEnums.NOT_VALUE;
                res.ShortDetail = "Trường ngày tháng năm sinh là bắt buộc";
                return res;
            }

            if (newData.SaleId == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chưa nhận được nhân viên sale id";
                return res;
            }
            EmployeeLA sale = _context.employeeLA.Find(newData.SaleId);
            if (sale == null)
            {
                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = $"Không tồn tại nhân viên sale có id là {newData.SaleId}";
                return res;
            }

            if (newData.GenderId == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chưa nhận được giới tính id";
                return res;
            }
            Gender gender = _context.genders.Find(newData.GenderId);
            if (gender == null)
            {
                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = $"Không tồn tại giới tính có id là {newData.SaleId}";
                return res;
            }

            StudentStatus studentStatus = _context.studentStatuses.FirstOrDefault(x => x.StudentStatusCode == "Off Studying");
            newData.StudentStatusId = studentStatus.Id;

            newData.HolidayTotal = 0;
            newData.ReserveTotal = 0;
            newData.UnauthorizedAbsencesTotal = 0;
            newData.LateMinuteTotal = 0;
            newData.UnactiveTotal = 0;
            _context.studentLAs.Add(newData);
            _context.SaveChanges();

            res.Status = StudentCreateEnums.SUCCESSFULLY;
            res.ShortDetail = "Thêm học viên thành công!";
            res.Data = newData;
            return res;
        }

        StudentDeleteDTO IStudentCRUD.deleteStudent(int? studentId)
        {
            StudentDeleteDTO res = new StudentDeleteDTO();

            if (studentId == null)
            {
                res.Status = StudentDeleteEnums.NULLID;
                res.ShortDetail = "Không nhận được học viên id";
                return res;
            }
            StudentLA studentLA = _context.studentLAs.Find(studentId);
            if (studentLA == null)
            {
                res.Status = StudentDeleteEnums.IDNOTFOUND;
                res.ShortDetail = $"Không tồn tại học viên có id là ${studentId}";
                return res;
            }

            StudentStatus studentStatus = _context.studentStatuses.FirstOrDefault(x => x.StudentStatusCode == "Resign");

            studentLA.StudentStatusId = studentStatus.Id;
            _context.studentLAs.Update(studentLA);
            _context.SaveChanges();
            res.Status = StudentDeleteEnums.SUCCESSFULLY;
            res.ShortDetail = "Xóa học viên thành công";
            res.Data = studentLA;
            return res;
        }

        StudentUpdateDTO IStudentCRUD.updateStudent(StudentLA newData)
        {
            StudentUpdateDTO res = new StudentUpdateDTO();

            using (var transaction = _context.Database.BeginTransaction())
            {
                if (newData.Id == null)
                {
                    res.Status = StudentUpdateEnums.NULLID;
                    res.ShortDetail = "Không nhận được học viên id";
                    return res;
                }
                StudentLA studentLA = _context.studentLAs.Find(newData.Id);
                if (studentLA == null)
                {
                    res.Status = StudentUpdateEnums.IDNOTFOUND;
                    res.ShortDetail = $"Không tồn tại học viên có id là {newData.Id}";
                    return res;
                }

                if (newData.StudentLAName != null)
                {
                    if (newData.StudentLAName.Length < 6)
                    {
                        res.Status = StudentUpdateEnums.LENGTH_TOO_SHORT;
                        res.ShortDetail = $"Tên học viên tối thiểu phải là 6 ký tự";
                        return res;
                    }
                    studentLA.StudentLAName = newData.StudentLAName;
                    _context.studentLAs.Update(studentLA);
                    _context.SaveChanges();
                }

                if (newData.StudentLAUserName != null)
                {
                    if (newData.StudentLAUserName.Length < 6)
                    {
                        res.Status = StudentUpdateEnums.LENGTH_TOO_SHORT;
                        res.ShortDetail = $"Tên username tối thiểu phải là 6 ký tự";
                        return res;
                    }
                    studentLA.StudentLAUserName = newData.StudentLAUserName;
                    _context.studentLAs.Update(studentLA);
                    _context.SaveChanges();
                }

                if (newData.StudentLAPassword != null)
                {
                    if (newData.StudentLAPassword.Length < 6)
                    {
                        res.Status = StudentUpdateEnums.LENGTH_TOO_SHORT;
                        res.ShortDetail = $"Tên password tối thiểu phải là 6 ký tự";
                        return res;
                    }
                    studentLA.StudentLAPassword = newData.StudentLAPassword;
                    _context.studentLAs.Update(studentLA);
                    _context.SaveChanges();
                }

                if (newData.WardCode != null)
                {
                    if (_context.wards.Find(newData.WardCode) == null)
                    {
                        res.Status = StudentUpdateEnums.IDNOTFOUND;
                        res.ShortDetail = $"Không tồn tại ward có id là {newData.WardCode}";
                        return res;
                    }
                    studentLA.WardCode = newData.WardCode;
                    _context.studentLAs.Update(studentLA);
                    _context.SaveChanges();
                }

                if (newData.DistrictCode != null)
                {
                    if (_context.districts.Find(newData.DistrictCode) == null)
                    {
                        res.Status = StudentUpdateEnums.IDNOTFOUND;
                        res.ShortDetail = $"Không tồn tại district có id là {newData.DistrictCode}";
                        return res;
                    }
                    studentLA.DistrictCode = newData.DistrictCode;
                    _context.studentLAs.Update(studentLA);
                    _context.SaveChanges();
                }

                if (newData.ProvinceCode != null)
                {
                    if (_context.provinces.Find(newData.ProvinceCode) == null)
                    {
                        res.Status = StudentUpdateEnums.IDNOTFOUND;
                        res.ShortDetail = $"Không tồn tại province có id là {newData.ProvinceCode}";
                        return res;
                    }
                    studentLA.ProvinceCode = newData.ProvinceCode;
                    _context.studentLAs.Update(studentLA);
                    _context.SaveChanges();
                }

                if (newData.StudentLABirthDay != null)
                {
                    studentLA.StudentLABirthDay = newData.StudentLABirthDay;
                    _context.studentLAs.Update(studentLA);
                    _context.SaveChanges();
                }

                if (newData.SaleId != null)
                {
                    if (_context.employeeLA.Find(newData.SaleId) == null)
                    {
                        res.Status = StudentUpdateEnums.IDNOTFOUND;
                        res.ShortDetail = $"Không tồn tại nhân viên sale có id là {newData.SaleId}";
                        return res;
                    }
                    studentLA.SaleId = newData.SaleId;
                    _context.studentLAs.Update(studentLA);
                    _context.SaveChanges();
                }

                if (newData.GenderId != null)
                {
                    if (_context.genders.Find(newData.GenderId) == null)
                    {
                        res.Status = StudentUpdateEnums.IDNOTFOUND;
                        res.ShortDetail = $"Không tồn tại giới tính có id là {newData.GenderId}";
                        return res;
                    }
                    studentLA.GenderId = newData.GenderId;
                    _context.studentLAs.Update(studentLA);
                    _context.SaveChanges();
                }

                if (newData.StudentStatusId != null)
                {
                    if (_context.studentStatuses.Find(newData.StudentStatusId) == null)
                    {
                        res.Status = StudentUpdateEnums.IDNOTFOUND;
                        res.ShortDetail = $"Không tồn tại student status có id là {newData.StudentStatusId}";
                        return res;
                    }
                    studentLA.StudentStatusId = newData.StudentStatusId;
                    _context.studentLAs.Update(studentLA);
                    _context.SaveChanges();
                }

                if (newData.HolidayTotal != null)
                {
                    studentLA.HolidayTotal = newData.HolidayTotal;
                    _context.studentLAs.Update(studentLA);
                    _context.SaveChanges();
                }

                if (newData.ReserveTotal != null)
                {
                    studentLA.ReserveTotal = newData.ReserveTotal;
                    _context.studentLAs.Update(studentLA);
                    _context.SaveChanges();
                }

                if (newData.UnauthorizedAbsencesTotal != null)
                {
                    studentLA.UnauthorizedAbsencesTotal = newData.UnauthorizedAbsencesTotal;
                    _context.studentLAs.Update(studentLA);
                    _context.SaveChanges();
                }

                if (newData.LateMinuteTotal != null)
                {
                    studentLA.LateMinuteTotal = newData.LateMinuteTotal;
                    _context.studentLAs.Update(studentLA);
                    _context.SaveChanges();
                }

                if (newData.UnactiveTotal != null)
                {
                    studentLA.UnactiveTotal = newData.UnactiveTotal;
                    _context.studentLAs.Update(studentLA);
                    _context.SaveChanges();
                }

                transaction.Commit();

                res.Status = StudentUpdateEnums.SUCCESSFULLY;
                res.ShortDetail = "Sửa thông tin học viên thành công!";
                res.Data = studentLA;
                return res;
            }
        }
    }
}
