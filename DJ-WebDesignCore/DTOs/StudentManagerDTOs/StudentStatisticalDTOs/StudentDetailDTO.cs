using DJ_WebDesignCore.Enums.StatisticsEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs
{
    public class StudentDetailDTO
    {
        public StatisticStatusAPIEnum Status { get; set; }
        public StudentLADTO? InfoAndContact { get; set; }
        public List<EvaluteACourse>? EvaluteACourses { get; set; }
        public List<StudentActiveSolutionDTO>? StudentActiveSolutions { get; set; }
        public string? mes { get; set; }
    }
}
