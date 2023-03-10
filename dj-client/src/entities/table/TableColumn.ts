import { StudentCourseSolution } from './../BusinessDTO/StudentManager/StudentEvalute/StudentCourseSolution';
import { ColumnsType } from "antd/es/table";
import { SimpleStudentEvalute } from "../BusinessDTO/StudentManager/StudentEvalute/SimpleStudentEvalute";
import ActiveSolution from '../BusinessDTO/StudentManager/StudentEvalute/ActiveSolution';

export const columnsCourses: ColumnsType<StudentCourseSolution> = [
    {
        title: 'STT',
        dataIndex: 'sortNumber',
        key: 'sortNumber',
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
        dataIndex: 'signInDateTime',
        key: 'signInDateTime',
        width: '15%',
    },
    {
        title: 'Thời gian hỗ trợ',
        key: 'supportTime',
        dataIndex: 'supportTime',
        width: '15%',
    },
    {
        title: 'Dự kiến kết thúc',
        key: 'doneExpectedDateTime',
        dataIndex: 'doneExpectedDateTime',
        width: '15%',
    },
    {
        title: 'Tiến độ hiện tại',
        key: 'lessonNow',
        dataIndex: 'lessonNow',
        width: '15%',
    },
    {
        title: 'Đánh giá',
        key: 'evalute',
        dataIndex: 'evalute',
        width: '15%',
    },
];
export const columnsActiveSolution: ColumnsType<ActiveSolution> = [
    {
        title: 'STT',
        dataIndex: 'sortNumber',
        key: 'sortNumber',
        width: '10%',

    },
    {
        title: 'Ngày tạo',
        dataIndex: 'createDateTime',
        key: 'createDateTime',
        width: '15%',
    },
    {
        title: 'Ca học',
        dataIndex: 'slot',
        key: 'slot',
        width: '15%',
    },
    {
        title: 'Trạng thái',
        key: 'activeStatus',
        dataIndex: 'activeStatus',
        width: '15%',
    },
    {
        title: 'Lý do',
        key: 'reason',
        dataIndex: 'reason',
        width: '15%',
    },
    {
        title: 'Xác nhận',
        key: 'confirmDateTime',
        dataIndex: 'confirmDateTime',
        width: '15%',
    },
    {
        title: 'Người xác nhận',
        key: 'employeeConfirm',
        dataIndex: 'employeeConfirm',
        width: '15%',
    }
];
