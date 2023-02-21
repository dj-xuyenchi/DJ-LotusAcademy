using System;
using System.ComponentModel.DataAnnotations.Schema;
using DJ_WebDesignCore.Entites.Courses;
using DJ_WebDesignCore.Entites.Student;

namespace DJ_WebDesignCore.Entites.Business
{
    public class StudentCourse : BaseEntity
    {
        public int? StudentLAId { get; set; }
        public virtual StudentLA? StudentLA { get; set; }
        public int? CourseLAId { get; set; }
        public CourseLA? CourseLA { get; set; }
        public DateTime? OpenCourse { get; set; }
        public DateTime? CloseCourse { get; set; }
        public int? SupportMonth { get; set; }
        public int? SortNumber { get; set; }
    }
}

