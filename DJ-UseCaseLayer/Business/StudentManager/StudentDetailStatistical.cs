using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentDetailStatisticalDTO;
using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Properties.Address;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.StudentDetailStatisticalEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_UseCaseLayer.Business.StudentManager
{
    public class StudentDetailStatistical : BaseDB, IStudentDetailStatistical
    {
        public StudentDetailStatisticalGetDTO getStudentDetailStatistical(int? studentLAId)
        {
            StudentDetailStatisticalGetDTO res = new StudentDetailStatisticalGetDTO();
            if (studentLAId == null)
            {
                res.Static = StudentFetailStatisticalEnum.NULLID;
                res.ShortDetail = "Không có giá trị của studentLA";
                return res;
            }
            StudentLA studentLA = _context.studentLAs.Find(studentLAId);
            if (studentLA == null)
            {
                res.Static = StudentFetailStatisticalEnum.NOTFOUND;
                res.ShortDetail = $"Không tồn tại studentLA có id là {studentLAId}";
                return res;
            }
            List<StudentDetailStatisticalGetter> lst = new List<StudentDetailStatisticalGetter>();
            List<StudentLA> studentLAs = _context.studentLAs.Where(x => x.Id == studentLAId).ToList();
            studentLAs.ForEach(studentLA =>
            {
                StudentDetailStatisticalGetter item = new StudentDetailStatisticalGetter();
                item.studentLAName = studentLA.StudentLAName;
                item.email = studentLA.Email;
                item.studentLASdt = studentLA.StudentLASdt;

                item.DistrictCode = studentLA.DistrictCode;
                District district = _context.districts.Find(studentLA.DistrictCode);
                item.DistrictName = district.name;

                item.ProvinceCode = studentLA.ProvinceCode;
                Province province = _context.provinces.Find(studentLA.ProvinceCode);
                item.ProvinceName = province.name;

                item.addressDetail = $"{item.DistrictName} - {item.ProvinceName}";

                item.birthday = studentLA.StudentLABirthDay;

                item.GenderId = studentLA.GenderId;
                Gender gender = _context.genders.Find(studentLA.GenderId);
                item.gender = gender.GenderName;

                item.StudentStatusId = studentLA.StudentStatusId;
                StudentStatus studentStatus = _context.studentStatuses.Find(studentLA.StudentStatusId);
                item.status = studentStatus.StudentStatusName;

                item.StudentDatalogId = studentLA.StudentDatalogId;
                StudentDatalog studentDatalog = _context.studentDatalogs.Find(studentLA.StudentDatalogId);
                item.job = studentDatalog.StudentDatalogName;

                item.zaloUrl = studentLA.ZaloUrl;
                item.facebookUrl = studentLA.FacebookUrl;

                lst.Add(item);
                res.infoAndContact = item;

            });
            res.Static = StudentFetailStatisticalEnum.SUCCESSFULLY;
            res.ShortDetail = "Lấy dữ liệu thành công!";
            return res;
        }
    }
}
