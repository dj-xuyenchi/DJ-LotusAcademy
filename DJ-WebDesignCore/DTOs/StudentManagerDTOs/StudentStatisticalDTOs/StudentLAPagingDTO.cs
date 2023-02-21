using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs
{
    public class StudentLAPagingDTO
    {
        public int Status { get; set; }
        public IEnumerable<StudentLADTO> Data { get; set; }
        public SolutionCenterLADTO SolutionCenterLADTO { get; set; }
        public string? Mes { get; set; }
    }
}
