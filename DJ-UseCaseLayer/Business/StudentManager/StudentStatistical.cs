using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs;
using DJ_WebDesignCore.Enums.StudentActiveManagerEnums;
using Microsoft.EntityFrameworkCore;

namespace DJ_UseCaseLayer.Business.StudentManager
{
    public class StudentStatistical : BaseDB, IStudentStatistical
    {
        StudentLAPagingDTO IStudentStatistical.getListStudentLA(int? page)
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
            var listPage = _context.studentLAs.Include(x => x.studentCourses).OrderBy(x => x.CreateAccountDatetime).Skip((int)page - 1).Take(10).OrderByDescending(x => x.CreateAccountDatetime).ToList();
            listPage.ForEach(x =>
            {
                StudentLADTO studentLa = new StudentLADTO();
                studentLa.StudentLAId = x.Id;
                studentLa.StudentLAName = x.StudentLAName;
                studentLa.StudentLASdt = x.StudentLASdt;
                List<string> studentCoursesName = new List<string>();
                foreach (var element in x.studentCourses)
                {
                    studentCoursesName.Add(_context.courses.Find(element.CourseLAId).CourseLAName);
                }
                studentLa.StudentCourses = studentCoursesName;
                // studentLa.StudentCourses = x.studentCourses;
                studentLa.Status = _context.studentStatuses.Find(x.StudentStatusId).StudentStatusName;
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

        StatisticsStudyTimePagingDTO IStudentStatistical.getListStatisticsStudyTime(int? page)
        {
            StatisticsStudyTimePagingDTO res = new StatisticsStudyTimePagingDTO();
            List<StatisticsStudyTimeDTO> data = new List<StatisticsStudyTimeDTO>();
            var listPages = _context.studentLAs.Include(x => x.studentCourses).OrderBy(x => x.CreateAccountDatetime).Skip(((int)page - 1) * 10).Take(10).ToList();
            listPages.ForEach(x =>
            {
                StatisticsStudyTimeDTO item = new StatisticsStudyTimeDTO();
                item.StudentLAId = x.Id;
                item.StudentLAName = x.StudentLAName;
                item.StudentCourses = x.studentCourses;
                if (x.StudentStatusId == 1 || x.StudentStatusId == 2)
                {
                    item.IsActive = ActiveStatus.ACTIVE;
                }
                else
                {
                    item.IsActive = ActiveStatus.UNACTIVE;
                }
                item.HolidayTotal = x.HolidayTotal;
                item.UnactiveTotal = x.UnactiveTotal;
                item.ReserveTotal = x.ReserveTotal;
                data.Add(item);
            });
            res.Status = 1;
            res.Data = data;
            res.Mes = "Lấy dữ liệu thành công!";
            return res;
        }
    }
}
