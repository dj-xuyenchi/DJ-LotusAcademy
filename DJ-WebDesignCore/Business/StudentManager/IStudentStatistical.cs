namespace DJ_WebDesignCore.Business.StudentManager
{
    public interface IStudentStatistical
    {
        StudentLAPagingDTO getListStudentLA(int? page);
        StatisticsStudyTimePagingDTO getListStatisticsStudyTime(int? page);
    }
}
