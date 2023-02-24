using DJ_WebDesignCore.Entites.Business;
using DJ_WebDesignCore.Entites.Courses;
using DJ_WebDesignCore.Enums.StudentActiveManagerEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs
{
    public class StudentLADTO
    {
        public int? StudentLAId { get; set; }
        public string? StudentLAName { get; set; }
        public string? StudentLASdt { get; set; }
        public List<string>? StudentCourses { get; set; }
        public int? EmployeeLAId { get; set; }
        public string? EmployeeLAName { get;set; }
        public string? Status { get; set; }

    }
}
