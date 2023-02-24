using DJ_WebDesignCore.DTOs.CourseManagerDTOs.CourseLessonsCRUDDTOs;
using DJ_WebDesignCore.Entites.Courses;

namespace DJ_WebDesignCore.Business.CourseManager
{
    public interface ICourseLessonsCRUD
    {
        CourseLessonsCreateDTO createCourseLessons(CourseLesson newData);
        CourseLessonsUpdateDTO updateCourseLessons(CourseLesson newData);
        CourseLessonsDeleteDTO deleteCourseLessons(int? courseLessonId);
    }
}
