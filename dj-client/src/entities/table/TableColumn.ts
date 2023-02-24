import { ColumnsType } from "antd/es/table";
import { SimpleStudentEvalute } from "../BusinessDTO/StudentManager/StudentEvalute/SimpleStudentEvalute";

export const columnsCourses: ColumnsType<SimpleStudentEvalute> = [
    {
        title: 'STT',
        dataIndex: 'info',
        key: 'info',
        width: '10%',

    },
    {
        title: 'Tên khóa học',
        dataIndex: 'courseName',
        key: 'courseName',
        width: '15%',
    },
    {
        title: 'Ngày đăng ký',
        dataIndex: 'openDateTime',
        key: 'openDateTime',
        width: '15%',
    },
    {
        title: 'Thời gian hỗ trợ',
        key: 'mentorTime',
        dataIndex: 'mentorTime',
        width: '15%',
    },
    {
        title: 'Dự kiến kết thúc',
        key: 'closeDateTime',
        dataIndex: 'closeDateTime',
        width: '15%',
    },
    {
        title: 'Tiến độ hiện tại',
        key: 'currentProgress',
        dataIndex: 'currentProgress',
        width: '15%',
    },
    {
        title: 'Đánh giá',
        key: 'evalute',
        dataIndex: 'evalute',
        width: '15%',
    },
];
export const columnsUnactiveReason: ColumnsType<SimpleStudentEvalute> = [
    {
        title: 'STT',
        dataIndex: 'stt',
        key: 'stt',
        width: '10%',

    },
    {
        title: 'Ngày nghỉ',
        dataIndex: 'yasumiDate',
        key: 'yasumiDate',
        width: '15%',
    },
    {
        title: 'Ca nghỉ',
        dataIndex: 'slot',
        key: 'slot',
        width: '10%',
    },
    {
        title: 'Lý do',
        key: 'reason',
        dataIndex: 'reason',
        width: '30%',
    },
    {
        title: 'Xác nhận',
        key: 'confirmDateTime',
        dataIndex: 'confirmDateTime',
        width: '20%',
    },
    {
        title: 'Người xác nhận',
        key: 'confirmEmployee',
        dataIndex: 'confirmEmployee',
        width: '15%',
    }
];
