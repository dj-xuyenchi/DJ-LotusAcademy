using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentCRUDDTOs;
using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Properties.Address;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.StudentManagerEnums;
using Microsoft.IdentityModel.Tokens;

namespace DJ_UseCaseLayer.Business.StudentManager
{
    public class StudentCRUD : BaseDB, IStudentCRUD
    {
        public StudentCreateDTO createStudent(StudentLA newData)
        {
            StudentCreateDTO res = new StudentCreateDTO();
            if (newData.StudentLAName == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Trường Họ Tên Là Bắt Buộc";
                return res;

            }
            if (newData.StudentLAName.Length < 6)
            {
                res.Status = StudentCreateEnums.LENGTH_TOO_SHORT;
                res.ShortDetail = "Họ Tên Phải Tối Thiếu 6 Ký Tự";
                return res;
                ;
            }
            if (newData.StudentLAUserName == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Trường user name là Bắt Buộc";
                return res;
            }
            if (newData.StudentLAPassword == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Trường Password Là Bắt Buộc";
                return res;
            }
            newData.StudentLAPassword = newData.StudentLAPassword.Trim();
            if (newData.StudentLAPassword.Length < 8)
            {
                res.Status = StudentCreateEnums.LENGTH_TOO_SHORT;
                res.ShortDetail = "Mật Khuẩu Phải Tối Thiếu 8 Ký Tự";
                return res;
            }
            if (newData.StudentLASdt == null && newData.StudentLASdt.Length > 9 && newData.StudentLASdt.Length < 11)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Truong Này Là Bắt Buộc Và SDT Phải Hợp Lệ ";
                return res;
            }
            if (newData.StudentDatalogId == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chưa Nhận Được Id " + newData.StudentDatalogId;
            }
            StudentDatalog studentDatalog = _context.studentDatalogs.Find(newData.StudentDatalogId);
            if (studentDatalog == null)
            {
                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = "Không Tồn Tại Sinh Viên Dữ Liệu Có Id Là:" + newData.StudentDatalogId;
                return res;
            }
            if (newData.WardCode == null )
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chưa Nhận Được Tên Của Phường:" + newData.WardCode;
                return res;
            }
            Ward ward = _context.wards.Find(newData.WardCode);
            if (ward == null)
            {
                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = "Không Tồn Tên Của Phường Này" + newData.WardCode;
                return res;
            }
            if (newData.DistrictCode == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chưa Nhận Được Tên Của Quận Này:" + newData.DistrictCode;
                return res;
            }
            District district = _context.districts.Find(newData.DistrictCode);
            if (district == null)
            {
                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = "Không Tồn Tại Tên Của Quận Này" + newData.District;
                return res;
            }
            if (newData.ProvinceCode == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chua Nhận Được Tên Của Tỉnh Này;" + newData.ProvinceCode;
                return res;

            }
            Province province = _context.provinces.Find(newData.ProvinceCode);
            if (province == null)
            {

                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = "Không Tồn Tại Tên Của Tỉnh Này;" + newData.ProvinceCode;
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
    }
}
