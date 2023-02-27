using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Business
{
    public class StudentCourseEmployeeReview :BaseEntity
    {
        public int? StudentCourseId { get; set; }
        public StudentCourse? StudentCourse { get; set; }
        public DateTime? ConfirmDateTime { get; set; }
        public string? ReviewDetail { get; set; }
        public int? SortNumber { get; set; }

    }
}
