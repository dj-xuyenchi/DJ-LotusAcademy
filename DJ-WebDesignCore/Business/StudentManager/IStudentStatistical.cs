using DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentStatisticalDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Business.StudentManager
{
    public interface IStudentStatistical
    {
        StudentLAPagingDTO getListStudentLA(int? page);
        StatisticsStudyTimeDTO getListStatisticsStudyTime();
    }
}
