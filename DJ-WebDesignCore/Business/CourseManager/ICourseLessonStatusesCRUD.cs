using DJ_WebDesignCore.DTOs.CourseManagerDTOs.CourseLessonStatusesCRUDDTOs;
using DJ_WebDesignCore.Entites.Properties;

namespace DJ_WebDesignCore.Business.CourseManager
{
    public interface ICourseLessonStatusesCRUD
    {
        CourseLessonStatusesCreateDTO createCourseLessonStatuses(CourseLessonStatus newData);
        CourseLessonStatusesUpdateDTO updateCourseLessonStatuses(CourseLessonStatus newData);
        CourseLessonStatusesDeleteDTO deleteCourseLessonStatuses(int? courseLessonStatusId);
    }
}
