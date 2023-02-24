using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Courses
{
    public class CourseLACourseLesson : BaseEntity
    {
        public int? CourseLAId { get; set; }
        public CourseLA? CourseLA { get; set; }
        public int? CourseLessonId { get; set; }
        public CourseLesson? CourseLesson { get; set;}
        public int? SortNumber { get; set; }
    }
}
