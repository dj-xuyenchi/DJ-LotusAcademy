using DJ_WebDesignCore.Enums.StudentDetailStatisticalEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.DTOs.StudentDetailStatisticalDTO
{
    public class StudentDetailStatisticalGetDTO
    {
        public StudentFetailStatisticalEnum? Static { get; set; }
        public string? ShortDetail { get; set; }
        public StudentDetailStatisticalGetter Data { get; set; }
    }
}
