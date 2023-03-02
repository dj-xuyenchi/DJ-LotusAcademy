import axiosClient from '../../AxiosApi';

const attendanceProgressStatistical: any = {
    getAttendanceProgressStatistical: (id: number) => {
        const url = `/api/AttendanceProgressStatistical?studentId=${id}`;
        return axiosClient.get(url);
    },
};

export default attendanceProgressStatistical;
