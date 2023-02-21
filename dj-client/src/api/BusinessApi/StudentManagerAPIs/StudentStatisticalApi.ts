import axiosClient from "../../AxiosApi";

const studentStatisticalApi: any = {
    getListStudentByPaging: (page: number) => {
        const url = `/api/hocvien/paging?page=${page}`;
        return axiosClient.get(url);
    },
};

export default studentStatisticalApi;
