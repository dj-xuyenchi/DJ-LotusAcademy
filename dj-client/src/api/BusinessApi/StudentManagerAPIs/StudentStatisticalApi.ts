import axiosClient from "../../AxiosApi";

const studentStatisticalApi: any = {
    getListStudentByPaging: (page: number) => {
        const url = `/api/getListStudentLA/paging?page=${page}`;
        return axiosClient.get(url);
    },
};

export default studentStatisticalApi;
