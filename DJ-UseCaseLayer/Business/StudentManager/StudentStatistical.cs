using DJ_WebDesignCore.Business.StudentManager;
using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs;
using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Courses;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.StatisticsEnums;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
            StudentLADTO studentLADTO = new StudentLADTO();
            studentLADTO.StudentLASdt = studentLA.StudentLASdt;
            studentLADTO.StudentLAName = studentLA.StudentLAName;
            studentLADTO.StudentLAId = studentLA.Id;
            studentLADTO.AddressDetail = studentLA.AddressDetail;
            studentLADTO.BirthDay = studentLA.StudentLABirthDay.Value.Day + "-" + studentLA.StudentLABirthDay.Value.Month + "-" + studentLA.StudentLABirthDay.Value.Year;
            studentLADTO.ZaloUrl = studentLA.ZaloUrl;
            studentLADTO.Facebook = studentLA.FacebookUrl;
            studentLADTO.Job = _context.studentDatalogs.Find(studentLA.StudentDatalogId).StudentDatalogName;
            studentLADTO.Gender=_context.genders.Find(studentLA.GenderId).GenderName;
            studentLADTO.Email = studentLA.Email;
            studentLADTO.Status = _context.studentStatuses.Find(studentLA.StudentStatusId).StudentStatusName;
            result.Status = StatisticStatusAPIEnum.SUCCESSFULLY;
            result.InfoAndContact = studentLADTO;
            List<EvaluteACourse> evaluteACourses = new List<EvaluteACourse>();
            int sttCourse = 1;
            foreach (StudentCourse course in _context.studentCourses.Where(x => x.StudentLAId == id))
            {
                EvaluteACourse evaluteACourse = new EvaluteACourse();
                var employeeReview = _context.studentCourseEmployeeReviews.Where(x => x.StudentCourseId == course.Id);
                if (employeeReview.IsNullOrEmpty())
                {
                    evaluteACourse.Evalute = "Chưa có đánh giá";
                }
                else
                {
                    evaluteACourse.Evalute = employeeReview.OrderByDescending(x => x.SortNumber).FirstOrDefault().ReviewDetail;
                }
                evaluteACourse.SortNumber = sttCourse;
                evaluteACourse.CourseName = _context.courses.Find(course.CourseLAId).CourseLAName;
                evaluteACourse.SignInDateTime = course.OpenCourse.Value.Day + "-" + course.OpenCourse.Value.Month + "-" + course.OpenCourse.Value.Year;
                evaluteACourse.SupportTime = course.SupportMonth.ToString();
                evaluteACourse.DoneExpectedDateTime = course.CloseCourse.Value.Day + "-" + course.CloseCourse.Value.Month + "-" + course.CloseCourse.Value.Year;
                var studentCourseLesson = _context.studentLACourseLessons.Where(x => x.StudentLAId == id && x.CourseLAId == course.CourseLAId);
                if (studentCourseLesson.IsNullOrEmpty())
                {
                    evaluteACourse.LessonNow = "Chưa bắt đầu học";
                    sttCourse++;
                    evaluteACourses.Add(evaluteACourse);
                }
                else
                {
                evaluteACourse.LessonNow = studentCourseLesson.Include(x=>x.CourseLesson).OrderByDescending(x => x.SortNumber).FirstOrDefault().CourseLesson.CourseLessonName;
                sttCourse++;
                evaluteACourses.Add(evaluteACourse);
                }
            }
            foreach(Attendance attendance in _context.attendance.Where(x => x.StudentLAId == id).OrderByDescending(x => x.CreateDateTime))
            {
                StudentActiveSolutionDTO activeSolutionDTO = new StudentActiveSolutionDTO();
               // activeSolutionDTO.Slot
            }
            result.EvaluteACourses = evaluteACourses;
            result.Status = StatisticStatusAPIEnum.SUCCESSFULLY;
            result.mes = "Lấy dữ liệu thành công!";
            return result;
        }

        StatisticsStudyTimeDTO IStudentStatistical.getListStatisticsStudyTime()
        {
            return null;
        }


    }
}
