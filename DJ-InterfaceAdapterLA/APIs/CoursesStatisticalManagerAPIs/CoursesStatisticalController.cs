using DJ_UseCaseLayer.Business.CourseManager;
using DJ_WebDesignCore.Business.CourseManager;
using DJ_WebDesignCore.DTOs.CourseManagerDTOs.CoursesStatisticalDTOs;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.CoursesStatisticalManagerAPIs
{
    public class CoursesStatisticalController : BaseAPI
    {
        public readonly ICoursesStatistical _coursesStatistical;
        public CoursesStatisticalController()
        {
            _coursesStatistical = new CoursesStatistical();
        }
        [HttpGet("CoursesStatistical/{studentId}")]
        public ActionResult<CoursesStatisticalGetDTO> getCoursesStatistical(int? studentId)
        {
            return Ok(_coursesStatistical.getCoursesStatistical(studentId));
        }
    }
}
