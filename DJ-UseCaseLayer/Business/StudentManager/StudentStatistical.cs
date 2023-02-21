using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_UseCaseLayer.Business.StudentManager
{
    public class StudentStatistical : BaseDB, IStudentStatistical
    {
        public StudentLAPagingDTO getListStudentLA(int? page)
        {
            StudentLAPagingDTO resultData = new StudentLAPagingDTO();
            if (page == null)
            {
                resultData.Mes = "Không nhận được page!";
                resultData.Status = 2;
                return resultData;

            }
            SolutionCenterLADTO solutionCenterLADTO = new SolutionCenterLADTO();
            List<StudentLADTO> data = new List<StudentLADTO>();
            //try
            //{
            var listPage = _context.studentLAs.Include(x => x.studentCourses).OrderBy(x => x.CreateAccountDatetime).Skip((int)page - 1).Take(10).ToList();
            listPage.ForEach(x =>
            {
                StudentLADTO studentLa = new StudentLADTO();
                studentLa.StudentLAId = x.Id;
                studentLa.StudentLAName = x.StudentLAName;
                studentLa.StudentLASdt = x.StudentLASdt;
                studentLa.StudentCourses = x.studentCourses;
                if (x.StudentStatusId == 1 || x.StudentStatusId == 2)
                {
                    studentLa.IsActive = DJ_WebDesignCore.Enums.StudentActiveManagerEnums.ActiveStatus.ACTIVE;
                }
                studentLa.IsActive = DJ_WebDesignCore.Enums.StudentActiveManagerEnums.ActiveStatus.UNACTIVE;
                var t = _context.studentEmployees.Where(x => x.StudentLAId == x.StudentLAId).ToList();
                studentLa.EmployeeLAName = _context.studentEmployees.Include(x => x.EmployeeLA).Where(x => x.StudentLAId == x.StudentLAId).OrderByDescending(x => x.SortNumber).FirstOrDefault().EmployeeLA.EmployeeLAName;
                data.Add(studentLa);
            });
            solutionCenterLADTO.TotalStudentLA = _context.studentLAs.Where(x => x.StudentStatusId == 1 || x.StudentStatusId == 2 || x.StudentStatusId == 5).Count();
            DateTime now = DateTime.Now;
            solutionCenterLADTO.TotalStudentLAThisMonth = _context.studentLAs.Where(x => (x.CreateAccountDatetime.Value.Month == now.Month && x.CreateAccountDatetime.Value.Year == now.Year) && (x.StudentStatusId == 1 || x.StudentStatusId == 2 || x.StudentStatusId == 5)).Count();
            solutionCenterLADTO.TotalStudentOFF = _context.studentLAs.Where(x => x.StudentStatusId == 1).Count();
            solutionCenterLADTO.TotalStudentON = _context.studentLAs.Where(x => x.StudentStatusId == 2).Count();
            solutionCenterLADTO.TotalStudentReserve = _context.studentLAs.Where(x => x.StudentStatusId == 5).Count();
            resultData.SolutionCenterLADTO = solutionCenterLADTO;
            resultData.Status = 1;
            resultData.Data = data;
            resultData.Mes = "Lấy dữ liệu thành công";
            return resultData;
            //}
            //catch (Exception e)
            //{
            //    resultData.Status = 3;
            //    resultData.Mes = "Lấy dữ liệu thất bại!";
            //    return resultData;
            //}
        }

        StatisticsStudyTimeDTO IStudentStatistical.getListStatisticsStudyTime()
        {
            return null;
        }


    }
}
