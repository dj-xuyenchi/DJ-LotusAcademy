using DJ_WebDesignCore.DTOs.StudentDetailStatisticalDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Business.StudentManager
{
    public interface IStudentDetailStatistical
    {
        StudentDetailStatisticalGetDTO getStudentDetailStatistical(int? studentLAId);
    }
}
