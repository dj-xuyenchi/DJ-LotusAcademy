using DJ_WebDesignCore.Business.CourseManager;
using DJ_WebDesignCore.DTOs.CourseManagerDTOs.CourseCRUDDTOs;
using DJ_WebDesignCore.DTOs.CourseManagerDTOs.StudentLACourseLessonsCRUDDTOs;
using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Courses;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.CourseManagerEnums;
using DJ_WebDesignCore.Enums.CourseManagerEnums.StudentLACourseLessonsEnums;

namespace DJ_UseCaseLayer.Business.CourseManager
{
    public class StudentLACourseLessonsCRUD : BaseDB, IStudentLACourseLessonsCRUD
    {
        StudentLACourseLessonsCreateDTO IStudentLACourseLessonsCRUD.createStudentLACourseLessons(StudentLACourseLesson newData)
        {
            StudentLACourseLessonsCreateDTO res = new StudentLACourseLessonsCreateDTO();
            if (newData.StudentLAId == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NULLID;
                res.ShortDetail = "Không nhận được id học sinh";
                return res;
            }
            StudentLA studentLA = _context.studentLAs.Find(newData.StudentLAId);
            if (studentLA == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NOTFOUND;
                res.ShortDetail = $"Không tồn tại student có id là {newData.StudentLAId}";
                return res;
            }

            if (newData.CourseLessonId == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NULLID;
                res.ShortDetail = "Không nhận được course lesson id";
                return res;
            }
            CourseLesson courseLesson = _context.courseLessons.Find(newData.CourseLessonId);
            if (courseLesson == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NOTFOUND;
                res.ShortDetail = $"Không tồn tại course lesson có id là {newData.CourseLessonId}";
                return res;
            }

            if (newData.OpenCourse == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NOT_VALUE;
                res.ShortDetail = "Vui lòng điền thời gian open course";
                return res;
            }

            if (newData.CloseCourse == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NOT_VALUE;
                res.ShortDetail = "Vui lòng điền thời gian close course";
                return res;
            }

            if (newData.Score == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NOT_VALUE;
                res.ShortDetail = "Vui lòng điền điểm kiểm tra của học sinh";
                return res;
            }

            if (newData.Score > 10 || newData.Score < 0)
            {
                res.Status = StudentLACourseLessonsCreateEnums.FAILED;
                res.ShortDetail = $"Điểm không chính xác";
                return res;
            }

            if (newData.EmployeeLAComfirmId == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NULLID;
                res.ShortDetail = "Không nhận được employee confirm id";
                return res;
            }
            EmployeeLA employeeLA = _context.employeeLA.Find(newData.EmployeeLAComfirmId);
            if (employeeLA == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NOTFOUND;
                res.ShortDetail = $"Không tồn tại employee có id là {newData.EmployeeLAComfirmId}";
                return res;
            }

            if (newData.EmployeeEvaluate == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NOT_VALUE;
                res.ShortDetail = "Vui lòng điền employee evaluate";
                return res;
            }

            if (newData.LinkStudentTest == null)
            {
                res.Status = StudentLACourseLessonsCreateEnums.NOT_VALUE;
                res.ShortDetail = "Vui lòng điền link bài test";
                return res;
            }

            _context.studentLACourseLessons.Add(newData);
            _context.SaveChanges();

            res.Data = newData;
            res.Status = StudentLACourseLessonsCreateEnums.SUCCESSFULLY;
            res.ShortDetail = "Thêm thành công!";
            return res;
        }
        StudentLACourseLessonsUpdateDTO IStudentLACourseLessonsCRUD.updateStudentLACourseLessons(StudentLACourseLesson newData)
        {
            StudentLACourseLessonsUpdateDTO res = new StudentLACourseLessonsUpdateDTO();
            using (var transaction = _context.Database.BeginTransaction())
            {
                if (newData.Id == null)
                {
                    res.Status = StudentLACourseLessonsUpdateEnums.NULLID;
                    res.ShortDetail = "Không nhận được Student LA Course Lessons id";
                    return res;
                }
                StudentLACourseLesson studentLACourseLesson = _context.studentLACourseLessons.Find(newData.Id);
                if (studentLACourseLesson == null)
                {
                    res.Status = StudentLACourseLessonsUpdateEnums.NOTFOUND;
                    res.ShortDetail = $"Không tồn tại Student LA Course Lessons có id là {newData.Id}";
                    return res;
                }

                if (newData.StudentLAId != null)
                {
                    StudentLA studentLA = _context.studentLAs.Find(newData.StudentLAId);
                    if (studentLA == null)
                    {
                        res.Status = StudentLACourseLessonsUpdateEnums.NOTFOUND;
                        res.ShortDetail = $"Không tồn tại Student LA có id là {newData.StudentLAId}";
                        return res;
                    }
                    studentLACourseLesson.StudentLAId = newData.StudentLAId;
                    _context.Update(studentLACourseLesson);
                    _context.SaveChanges();
                }

                if (newData.CourseLessonId != null)
                {
                    CourseLesson courseLesson = _context.courseLessons.Find(newData.CourseLessonId);
                    if (courseLesson == null)
                    {
                        res.Status = StudentLACourseLessonsUpdateEnums.NOTFOUND;
                        res.ShortDetail = $"Không tồn tại Course Lessons có id là {newData.CourseLessonId}";
                        return res;
                    }
                    studentLACourseLesson.CourseLessonId = newData.CourseLessonId;
                    _context.Update(studentLACourseLesson);
                    _context.SaveChanges();
                }

                if (newData.OpenCourse != null)
                {
                    studentLACourseLesson.OpenCourse = newData.OpenCourse;
                    _context.Update(studentLACourseLesson);
                    _context.SaveChanges();
                }

                if (newData.CloseCourse != null)
                {
                    studentLACourseLesson.CloseCourse = newData.CloseCourse;
                    _context.Update(studentLACourseLesson);
                    _context.SaveChanges();
                }

                if (newData.Score != null)
                {
                    if (newData.Score < 0 || newData.Score > 10)
                    {
                        res.Status = StudentLACourseLessonsUpdateEnums.FAILED;
                        res.ShortDetail = "Bạn điền điểm cho học sinh không hợp lệ";
                        return res;
                    }
                    studentLACourseLesson.Score = newData.Score;
                    _context.Update(studentLACourseLesson);
                    _context.SaveChanges();
                }

                if (newData.EmployeeLAComfirmId != null)
                {
                    EmployeeLA employeeLA = _context.employeeLA.Find(newData.EmployeeLAComfirmId);
                    if (employeeLA == null)
                    {
                        res.Status = StudentLACourseLessonsUpdateEnums.NOTFOUND;
                        res.ShortDetail = $"Không tồn tại Employee LA Confirm có id là {newData.EmployeeLAComfirmId}";
                        return res;
                    }
                    studentLACourseLesson.EmployeeLAComfirmId = newData.EmployeeLAComfirmId;
                    _context.Update(studentLACourseLesson);
                    _context.SaveChanges();
                }

                if (newData.EmployeeEvaluate != null)
                {
                    studentLACourseLesson.EmployeeEvaluate = newData.EmployeeEvaluate;
                    _context.Update(studentLACourseLesson);
                    _context.SaveChanges();
                }

                if (newData.LinkStudentTest != null)
                {
                    studentLACourseLesson.LinkStudentTest = newData.LinkStudentTest;
                    _context.Update(studentLACourseLesson);
                    _context.SaveChanges();
                }

                transaction.Commit();

                res.Status = StudentLACourseLessonsUpdateEnums.SUCCESSFULLY;
                res.Data = studentLACourseLesson;
                res.ShortDetail = "Sửa Student LA Course Lessons thành công!";

                return res;
            }

        }
        StudentLACourseLessonsDeleteDTO IStudentLACourseLessonsCRUD.deleteStudentLACourseLessons(int? studentLACourseLessonsId)
        {
            return null;
        }
    }
}
