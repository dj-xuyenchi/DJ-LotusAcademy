using DJ_UseCaseLayer.Business.CourseManager;
using DJ_WebDesignCore.Business.CourseManager;
using DJ_WebDesignCore.DTOs.CourseManagerDTOs.CourseCRUDDTOs;
using DJ_WebDesignCore.DTOs.CourseManagerDTOs.StudentLACourseLessonsCRUDDTOs;
using DJ_WebDesignCore.Entites.Business;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.StudentLACourseLessonsAPIs
{
    public class StudentLACourseLessonsCRUDController : BaseAPI
    {
        public readonly IStudentLACourseLessonsCRUD _studentLACourseLessonsCRUD;
        public StudentLACourseLessonsCRUDController()
        {
            _studentLACourseLessonsCRUD = new StudentLACourseLessonsCRUD();
        }

        [HttpPost("StudentLACourseLessonsCRUD")]
        public ActionResult<StudentLACourseLessonsCreateDTO> createStudentLACourseLessons([FromBody] StudentLACourseLesson newData)
        {
            return Ok(_studentLACourseLessonsCRUD.createStudentLACourseLessons(newData));
        }
        [HttpPut("StudentLACourseLessonsCRUD")]
        public ActionResult<StudentLACourseLessonsUpdateDTO> deleteStudentLACourseLessons([FromBody] StudentLACourseLesson newData)
        {
            return Ok(_studentLACourseLessonsCRUD.updateStudentLACourseLessons(newData));
        }
    }
}
