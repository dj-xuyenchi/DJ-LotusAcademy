using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs
{
    public class EvaluteACourse
    {
        public int SortNumber { get; set; }
        public string? CourseName { get; set; }
        public string? SignInDateTime { get; set; }
        public string? SupportTime { get; set; }
        public string? DoneExpectedDateTime { get; set; }
        // tiến độ hiện tại
        public string? LessonNow { get; set; }
        public string? Evalute { get; set; }

    }
}
