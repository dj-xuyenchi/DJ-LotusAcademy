using DJ_WebDesignCore.Business.CourseManager;
using DJ_WebDesignCore.DTOs.CourseManagerDTOs.CoursesStatisticalDTOs;

namespace DJ_UseCaseLayer.Business.CourseManager
{
    public class CoursesStatistical : BaseDB, ICoursesStatistical
    {
        CoursesStatisticalGetDTO ICoursesStatistical.getCoursesStatistical(int? studentId)
        {
            return null;
        }
    }
}
