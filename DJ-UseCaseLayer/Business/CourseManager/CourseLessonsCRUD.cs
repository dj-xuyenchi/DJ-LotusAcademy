using DJ_WebDesignCore.Business.CourseManager;
using DJ_WebDesignCore.DTOs.CourseManagerDTOs.CourseLessonsCRUDDTOs;
using DJ_WebDesignCore.Entites.Courses;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Enums.CourseManagerEnums.CourseLesson;

namespace DJ_UseCaseLayer.Business.CourseManager
{
    public class CourseLessonsCRUD : BaseDB, ICourseLessonsCRUD
    {
        public CourseLessonsCreateDTO createCourseLessons(CourseLesson newData)
        {
            CourseLessonsCreateDTO res = new CourseLessonsCreateDTO();

            if (newData.CourseLessonCode == null)
            {
                res.Status = CourseLessonsCreateEnums.NOT_VALUE;
                res.ShortDetail = "Không nhận được course lesson code";
                return res;
            }
            if (newData.CourseLessonName == null)
            {
                res.Status = CourseLessonsCreateEnums.NOT_VALUE;
                res.ShortDetail = "Không nhận được Course Cesson Name";
                return res;
            }

            if (newData.CourseLAId == null)
            {
                res.Status = CourseLessonsCreateEnums.NULLID;
                res.ShortDetail = "Không nhận được Course LA id";
                return res;
            }
            CourseLA courseLA = _context.courses.Find(newData.CourseLAId);
            if (courseLA == null)
            {
                res.Status = CourseLessonsCreateEnums.NOTFOUND;
                res.ShortDetail = $"Không tồn tại Course LA có id là {newData.CourseLAId}";
                return res;
            }

            if (newData.CourseLessonStatusId == null)
            {
                res.Status = CourseLessonsCreateEnums.NULLID;
                res.ShortDetail = "Không nhận được Course Lesson Status id";
                return res;
            }
            CourseLessonStatus courseLessonStatus = _context.courseLessonStatuses.Find(newData.CourseLessonStatusId);
            if (courseLessonStatus == null)
            {
                res.Status = CourseLessonsCreateEnums.NOTFOUND;
                res.ShortDetail = $"Không tồn tại Course Lesson Status có id là {newData.CourseLessonStatusId}";
                return res;
            }

            if (newData.SortNumber == null)
            {
                res.Status = CourseLessonsCreateEnums.NOT_VALUE;
                res.ShortDetail = "Vui lòng điền sort number";
                return res;
            }

            _context.courseLessons.Add(newData);
            _context.SaveChanges();

            res.Status = CourseLessonsCreateEnums.SUCCESSFULLY;
            res.Data = newData;
            res.ShortDetail = "Thêm course lesson thành công!";

            return res;
        }

        public CourseLessonsUpdateDTO updateCourseLessons(CourseLesson newData)
        {
            CourseLessonsUpdateDTO res = new CourseLessonsUpdateDTO();

            using (var transaction = _context.Database.BeginTransaction())
            {
                if (newData.Id == null)
                {
                    res.Status = CourseLessonsUpdateEnums.NULLID;
                    res.ShortDetail = "Không nhận được course lesson id";
                    return res;
                }
                CourseLesson courseLesson = _context.courseLessons.Find(newData.Id);
                if (courseLesson == null)
                {
                    res.Status = CourseLessonsUpdateEnums.NOTFOUND;
                    res.ShortDetail = $"Không tồn tại course lesson có id là {newData.Id}";
                    return res;
                }

                if (newData.CourseLessonCode != null)
                {
                    courseLesson.CourseLessonCode = newData.CourseLessonCode;
                    _context.Update(courseLesson);
                    _context.SaveChanges();
                }

                if (newData.CourseLessonName != null)
                {
                    courseLesson.CourseLessonName = newData.CourseLessonName;
                    _context.Update(courseLesson);
                    _context.SaveChanges();
                }

                if (newData.CourseLAId != null)
                {
                    CourseLA courseLA = _context.courses.Find(newData.CourseLAId);
                    if (courseLA == null)
                    {
                        res.Status = CourseLessonsUpdateEnums.NOTFOUND;
                        res.ShortDetail = $"Không tồn tại course LA có id là {newData.CourseLAId}";
                        return res;
                    }
                    courseLesson.CourseLAId = newData.CourseLAId;
                    _context.Update(courseLesson);
                    _context.SaveChanges();
                }

                if (newData.SortNumber != null)
                {
                    courseLesson.SortNumber = newData.SortNumber;
                    _context.Update(courseLesson);
                    _context.SaveChanges();
                }

                if (newData.CourseLessonStatusId != null)
                {
                    CourseLessonStatus courseLessonStatus = _context.courseLessonStatuses.Find(newData.CourseLessonStatusId);
                    if (courseLessonStatus == null)
                    {
                        res.Status = CourseLessonsUpdateEnums.NOTFOUND;
                        res.ShortDetail = $"Không tìm thấy course lesson status có id là {newData.CourseLessonStatusId}";
                        return res;
                    }
                    courseLesson.CourseLessonStatusId = newData.CourseLessonStatusId;
                    _context.Update(courseLesson);
                    _context.SaveChanges();
                }

                transaction.Commit();

                res.Status = CourseLessonsUpdateEnums.SUCCESSFULLY;
                res.Data = courseLesson;
                res.ShortDetail = "Sửa course lesson thành công!";

                return res;
            }
        }

        public CourseLessonsDeleteDTO deleteCourseLessons(int? courseLessonsId)
        {
            return null;
        }
    }
}
