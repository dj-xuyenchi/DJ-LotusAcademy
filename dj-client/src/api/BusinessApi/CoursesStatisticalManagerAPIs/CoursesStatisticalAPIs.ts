import axiosClient from '../../AxiosApi';

const coursesStatisticalApi: any = {
    getCoursesStatistical: (id: number) => {
        const url = `/api/CoursesStatistical?studentId=${id}`;
        return axiosClient.get(url);
    },
};

export default coursesStatisticalApi;
