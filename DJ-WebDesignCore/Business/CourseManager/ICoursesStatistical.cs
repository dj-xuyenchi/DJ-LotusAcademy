using DJ_WebDesignCore.DTOs.CourseManagerDTOs.CoursesStatisticalDTOs;

namespace DJ_WebDesignCore.Business.CourseManager
{
    public interface ICoursesStatistical
    {
        CoursesStatisticalGetDTO getCoursesStatistical(int? studentId);
    }
}
