using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentCRUDDTOs;
using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Properties.Address;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.StudentManagerEnums;
using Microsoft.IdentityModel.Tokens;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DJ_UseCaseLayer.Business.StudentManager
{
    public class StudentCRUD : BaseDB, IStudentCRUD
    {
        public StudentCreateDTO createStudent(StudentCreateLA newData)
        {
            StudentCreateDTO res = new StudentCreateDTO();
            //  StudentLAName
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

            }
            //  studentLAuserName
            newData.StudentLAUserName = convertToUnSign2(newData.StudentLAUserName);

            if (newData.StudentLAPassword == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Trường Password Là Bắt Buộc";
                return res;
            }

            newData.StudentLAPassword = convertToUnSign2(newData.StudentLAPassword).Replace(" ", "");
            if (newData.StudentLAPassword.Length < 8)
            {
                res.Status = StudentCreateEnums.LENGTH_TOO_SHORT;
                res.ShortDetail = "Mật Khuẩu Phải Tối Thiếu 8 Ký Tự";
                return res;
            }
            //studentLASDT
            if (newData.StudentLASdt == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Truong Này Là Bắt Buộc Và SDT Phải Hợp Lệ ";
                return res;
            }
            if (newData.StudentLASdt.Length < 9 || newData.StudentLASdt.Length > 12)
            {
                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = "SDT Phải Hợp Lệ Và Là 10 Số Hoặc 11 Số";
                return res;
            }
            // StudentDataLogId
            if (newData.StudentDatalogId == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chưa Nhận Được Id " + newData.StudentDatalogId;
                return res;
            }
            var studentDatalog = _context.studentGreateLAs.Select(x => x.StudentDatalogId == newData.StudentDatalog.Id);
            if (studentDatalog == null)
            {
                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = "Không Tồn Tại Sinh Viên Dữ Liệu Có Id Là:" + newData.StudentDatalogId;
                return res;
            }

            newData.CreateAccountDatetime = DateTime.Now; // CreateAcountDatatime
            // WradCode
            if (newData.WardCode == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chưa Nhận Được Id Của Phường:" + newData.WardCode;
                return res;
            }
            var ward = _context.studentGreateLAs.Select(x => x.WardCode == newData.Ward.code);
            if (ward == null)
            {
                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = "Không Tồn Id Của Phường Này" + newData.WardCode;
                return res;
            }
            // districtCode

            if (newData.DistrictCode == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chưa Nhận Được Id Của Huyện Này:" + newData.DistrictCode;
                return res;
            }
            var districtCode = _context.studentGreateLAs.Select(x => x.DistrictCode == newData.District.code);
            if (districtCode == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Không Tồn Tại Id Của Huyện Này" + newData.DistrictCode;
                return res;
            }

            // ProvinceCode

            if (newData.ProvinceCode == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chưa Nhận Được Id Của Tỉnh Này;" + newData.ProvinceCode;
                return res;
            }

            var provinceCode = _context.studentGreateLAs.Select(x => x.ProvinceCode == newData.Province.code);
            if (provinceCode == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Không Tồn Tại Id Của Tỉnh Này: ";
                return res;
            }

           // sales
            if (newData.SaleId == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chưa Nhận Id Của Sales Này:" + newData.SaleId;
                return res;
            }
            var sales = _context.studentGreateLAs.Select(x => x.SaleId == newData.Sale.Id);
            if (sales == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Không Tồn Tại Id Của Sales Này :" + newData.SaleId;
                return res;
            }

            //Gender

            if (newData.GenderId == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chưa Nhận Được Giới Tính";
                return res;
            }
            if (newData.GenderId < 0 || newData.GenderId > 4)
            {
                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = "Id Phải Nằm trong Khoảng Từ 1-3";
                return res;
            }
            var gender = _context.studentGreateLAs.Select(x => x.GenderId == newData.Gender.Id);
            if (gender == null)
            {
                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = "Không tồn tại giới tính có id là " + newData.GenderId;
                return res;
            }

            //KnowByWhatId
            if (newData.KnowByWhatId == null)
            {
                res.Status = StudentCreateEnums.NULLID;
                res.ShortDetail = "Chưa Nhận Được Id " + newData.KnowByWhatId;
                return res;
            }
            if (newData.KnowByWhatId < 0 || newData.KnowByWhatId > 10)
            {
                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = " Id Nằm Trong Khoảng Từ 1-9" + newData.KnowByWhatId;
                return res;

            }
            var knowByWhat = _context.studentGreateLAs.Select(x => x.KnowByWhatId == newData.KnowByWhat.Id);
            if (knowByWhat == null)
            {
                res.Status = StudentCreateEnums.NOTFOUNDID;
                res.ShortDetail = "Không Tồn Tại Id Này " + newData.KnowByWhatId;
                return res;
            }

            // StudentStatus studentStatus = _context.studentStatuses.FirstOrDefault(x => x.StudentStatusCode == "Off Studying");


            newData.HolidayTotal = 0;
            newData.ReserveTotal = 0;
            newData.UnauthorizedAbsencesTotal = 0;
            newData.LateMinuteTotal = 0;
            newData.UnactiveTotal = 0;
             _context.studentGreateLAs.Add(newData);
            _context.SaveChanges();

            res.Status = StudentCreateEnums.SUCCESSFULLY;
            res.ShortDetail = "Thêm học viên thành công!";
            res.Data = newData;
            return res;
        }
        public string convertToUnSign2(string s)
        {

            string stFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD));
        }

    }
    
}


