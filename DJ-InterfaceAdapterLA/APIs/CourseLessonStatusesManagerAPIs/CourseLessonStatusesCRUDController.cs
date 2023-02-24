using DJ_UseCaseLayer.Business.CourseManager;
using DJ_WebDesignCore.Business.CourseManager;
using DJ_WebDesignCore.DTOs.CourseManagerDTOs.CourseLessonStatusesCRUDDTOs;
using DJ_WebDesignCore.Entites.Properties;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.CourseLessonStatusesManagerAPIs
{
    public class CourseLessonStatusesCRUDController : BaseAPI
    {
        private readonly ICourseLessonStatusesCRUD _courseLessonStatusesCRUD;
        public CourseLessonStatusesCRUDController()
        {
            _courseLessonStatusesCRUD = new CourseLessonStatusesCRUD();
        }
        [HttpPost("CourseLessonStatusesCRUD")]
        public ActionResult<CourseLessonStatusesCreateDTO> createCourseLessonStatuses([FromBody] CourseLessonStatus newData)
        {
            return Ok(_courseLessonStatusesCRUD.createCourseLessonStatuses(newData));
        }
        [HttpPut("CourseLessonStatusesCRUD")]
        public ActionResult<CourseLessonStatusesUpdateDTO> updateCourseLessonStatuses([FromBody] CourseLessonStatus newData)
        {
            return Ok(_courseLessonStatusesCRUD.updateCourseLessonStatuses(newData));
        }
    }
}
