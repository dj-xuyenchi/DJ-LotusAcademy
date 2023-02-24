using DJ_WebDesignCore.Business.CourseManager;
using DJ_WebDesignCore.DTOs.CourseManagerDTOs.CourseLessonStatusesCRUDDTOs;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Enums.CourseManagerEnums.CourseLessonStatusesEnums;

namespace DJ_UseCaseLayer.Business.CourseManager
{
    public class CourseLessonStatusesCRUD : BaseDB, ICourseLessonStatusesCRUD
    {
        public CourseLessonStatusesCreateDTO createCourseLessonStatuses(CourseLessonStatus newData)
        {
            CourseLessonStatusesCreateDTO res = new CourseLessonStatusesCreateDTO();
            if (newData.CourseLessonStatusCode == null)
            {
                res.Status = CourseLessonStatusesCreateEnums.NOT_VALUE;
                res.ShortDetail = "Vui lòng điền course lesson status code";
                return res;
            }

            if (newData.CourseLessonStatusName == null)
            {
                res.Status = CourseLessonStatusesCreateEnums.NOT_VALUE;
                res.ShortDetail = "Vui lòng điền course lesson status name";
                return res;
            }

            _context.courseLessonStatuses.Add(newData);
            _context.SaveChanges();

            res.Status = CourseLessonStatusesCreateEnums.SUCCESSFULLY;
            res.Data = newData;
            res.ShortDetail = "Thêm course lesson status thành công!";
            return res;
        }
        public CourseLessonStatusesUpdateDTO updateCourseLessonStatuses(CourseLessonStatus newData)
        {
            CourseLessonStatusesUpdateDTO res = new CourseLessonStatusesUpdateDTO();

            using (var transaction = _context.Database.BeginTransaction())
            {
                if (newData.Id == null)
                {
                    res.Status = CourseLessonStatusesUpdateEnums.NULLID;
                    res.ShortDetail = "Không tìm thấy course lesson status id";
                    return res;
                }
                CourseLessonStatus courseLessonStatus = _context.courseLessonStatuses.Find(newData.Id);
                if (courseLessonStatus == null)
                {
                    res.Status = CourseLessonStatusesUpdateEnums.NOTFOUND;
                    res.ShortDetail = $"Không tồn tại course lesson status có id là {newData.Id}";
                    return res;
                }
                if (newData.CourseLessonStatusCode != null)
                {
                    courseLessonStatus.CourseLessonStatusCode = newData.CourseLessonStatusCode;
                    _context.Update(courseLessonStatus);
                    _context.SaveChanges();
                }
                if (newData.CourseLessonStatusName != null)
                {
                    courseLessonStatus.CourseLessonStatusName = newData.CourseLessonStatusName;
                    _context.Update(courseLessonStatus);
                    _context.SaveChanges();
                }

                transaction.Commit();

                res.Status = CourseLessonStatusesUpdateEnums.SUCCESSFULLY;
                res.ShortDetail = "Sửa course lesson status thành công!";
                return res;
            }
        }
        public CourseLessonStatusesDeleteDTO deleteCourseLessonStatuses(int? courseId)
        {
            //CourseLessonStatusesDeleteDTO res = new CourseLessonStatusesDeleteDTO();
            //if (courseId == null)
            //{
            //    res.Status = CourseLessonStatusesDeleteEnums.NULLID;
            //    res.ShortDetail = "Không nhận được course lesson status id";
            //    return res;
            //}
            //CourseLessonStatus courseLessonStatus = _context.courseLessonStatuses.Find(courseId);
            //if (courseLessonStatus == null)
            //{
            //    res.Status = CourseLessonStatusesDeleteEnums.NOTFOUND;
            //    res.ShortDetail = $"Không tồn tại course lesson status có id là {courseId}";
            //    return res;
            //}

            return null;
        }
    }
}
