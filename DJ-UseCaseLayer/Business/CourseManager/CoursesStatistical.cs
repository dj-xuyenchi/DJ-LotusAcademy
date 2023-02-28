using DJ_WebDesignCore.Business.CourseManager;
using DJ_WebDesignCore.DTOs.CourseManagerDTOs.CoursesStatisticalDTOs;
using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Courses;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.CourseManagerEnums.CoursesStatisticalEnums;

namespace DJ_UseCaseLayer.Business.CourseManager
{
    public class CoursesStatistical : BaseDB, ICoursesStatistical
    {
        CoursesStatisticalGetDTO ICoursesStatistical.getCoursesStatistical(int? studentId)
        {
            CoursesStatisticalGetDTO res = new CoursesStatisticalGetDTO();

            if (studentId == null)
            {
                res.Status = CoursesStatisticalEnum.NULLID;
                res.ShortDetail = "Không nhận được studentLA id";
                return res;
            }
            StudentLA studentLA = _context.studentLAs.Find(studentId);
            if (studentLA == null)
            {
                res.Status = CoursesStatisticalEnum.NOTFOUND;
                res.ShortDetail = $"Không tồn tại studentLA có id là {studentId}";
                return res;
            }

            List<CoursesStatisticalGetter> coursesStatisticalGetters = new List<CoursesStatisticalGetter>();
            List<StudentCourse> studentCourseList = _context.studentCourses.Where(x => x.StudentLAId == studentId).ToList();
            studentCourseList.ForEach(studentCourse =>
            {
                CoursesStatisticalGetter item = new CoursesStatisticalGetter();
                item.CourseId = studentCourse.CourseLAId;
                CourseLA course = _context.courses.Find(studentCourse.CourseLAId);
                item.courseName = course.CourseLAName;
                item.signInDateTime = studentCourse.OpenCourse;
                item.supportTime = studentCourse.SupportMonth;
                item.doneExpectedDateTime = studentCourse.CloseCourse;

                List<CourseLACourseLesson> courseLACourseLessons = _context.courseLACourseLessons.Where(x => x.CourseLAId == course.Id).OrderByDescending(x => x.SortNumber).ToList();
                CourseLesson courseLesson = _context.courseLessons.Find(courseLACourseLessons.FirstOrDefault().CourseLessonId);
                item.lessonNow = courseLesson.CourseLessonName;

                List<StudentLACourseLesson> studentLACourseLessons = _context.studentLACourseLessons.Where(x => x.StudentLAId == studentId && x.CourseLAId == course.Id).OrderByDescending(x => x.SortNumber).ToList();
                if (studentLACourseLessons.FirstOrDefault() != null)
                {
                    item.evalute = studentLACourseLessons.FirstOrDefault().EmployeeEvaluate;
                }

                coursesStatisticalGetters.Add(item);
            });

            res.Status = CoursesStatisticalEnum.SUCCESSFULLY;
            res.Data = coursesStatisticalGetters;
            res.ShortDetail = "Lấy dữ liệu thành công!";
            return res;
        }
    }
}
