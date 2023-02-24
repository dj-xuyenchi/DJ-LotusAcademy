using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs;
using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.StatisticsEnums;
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
                resultData.Status = StatisticStatusAPIEnum.PARAMNULL;
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
            resultData.Status = StatisticStatusAPIEnum.SUCCESSFULLY;
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

        public StudentDetailDTO getStudentDetailById(int? id)
        {
            StudentDetailDTO result = new StudentDetailDTO();
            if (id == null)
            {
                result.Status = StatisticStatusAPIEnum.PARAMNULL;
                result.mes = "Không nhận được id";
                return result;
            }
            StudentLA studentLA = _context.studentLAs.Find(id);
            if (studentLA == null)
            {
                result.Status = StatisticStatusAPIEnum.NOTFOUND;
                result.mes = "Không tồn tại đối tượng";
                return result;
            }
            result.Status = StatisticStatusAPIEnum.SUCCESSFULLY;
            List<EvaluteACourse> evaluteACourses = new List<EvaluteACourse>();
            int sttCourse = 1;
            foreach (StudentCourse course in _context.studentCourses.Where(x => x.StudentLAId == id))
            {
                EvaluteACourse evaluteACourse = new EvaluteACourse();
                evaluteACourse.SortNumber = sttCourse;
                evaluteACourse.CourseName = _context.courses.Find(course.CourseLAId).CourseLAName;
                evaluteACourse.SignInDateTime = course.OpenCourse.Value.Day + "-" + course.OpenCourse.Value.Month + "-" + course.OpenCourse.Value.Year;
                evaluteACourse.SupportTime = course.SupportMonth.ToString();
                evaluteACourse.DoneExpectedDateTime = course.CloseCourse.Value.Day + "-" + course.CloseCourse.Value.Month + "-" + course.CloseCourse.Value.Year;
            //    StudentLACourseLesson lessonPhase = _context.studentLACourseLessons.Where(x=>x.Course==course.CourseLAId && x.StudentLAId == id).;
                sttCourse++;
            }
            return result;
        }

        StatisticsStudyTimeDTO IStudentStatistical.getListStatisticsStudyTime()
        {
            return null;
        }


    }
}
