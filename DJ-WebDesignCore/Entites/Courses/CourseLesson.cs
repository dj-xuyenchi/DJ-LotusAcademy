using DJ_WebDesignCore.Entites.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Courses
{
    public class CourseLesson :BaseEntity
    {
        public string? CourseLessonCode { get; set; }
        public string? CourseLessonName { get; set;}
        public int? CourseLessonStatusId { get; set; }
        public CourseLessonStatus? CourseLessonStatus { get; set; }
    }
}
