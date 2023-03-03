using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs
{
    public class StudentActiveSolutionDTO
    {
        public int SortNumber { get; set; }
        public string CreateDateTime { get; set; }
        public string Slot { get; set; }
        public string ActiveStatus { get; set; }
        public string Reason { get; set; }
        public string ConfirmDateTime { get; set; }
        public string EmployeeConfirm { get; set; }
    }
}
