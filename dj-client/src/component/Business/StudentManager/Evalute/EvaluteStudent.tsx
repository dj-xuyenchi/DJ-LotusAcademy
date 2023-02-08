import Table from 'react-bootstrap/Table';
import './EvaluteStudent.css';
import SimpleStudentDataEvalute from './SimpleEval/SimpleStudentDataEvalute';
import { SimpleStudentEvalute } from '../../../../entities/BusinessDTO/StudentManager/StudentEvalute/SimpleStudentEvalute';
function EvaluteStudent() {
    let data: SimpleStudentEvalute = {
        studentAvatar: 'https://img.meta.com.vn/Data/image/2021/09/22/anh-meo-cute-de-thuong-dang-yeu-41.jpg',
        studentName: 'â',
        studentSdt: '0987123123',
        studentCourse: 'java',
        studentTurtor: 'QA',
        studentActive: true,
    };
    return (
        <div className="EvaStudent" style={{ padding: '24px 32px' }}>
            <div className="table-title">
                <h3>Thống kê</h3>
            </div>

            <Table className="table-default" hover responsive="sm">
                <thead>
                    <tr style={{ backgroundColor: '#ccc' }}>
                        <th id="table-name">
                            <span>Tên</span>
                        </th>
                        <th id="table-contact">
                            <span>SDT liên hệ</span>
                        </th>
                        <th id="table-course">
                            <span>Khóa học</span>
                        </th>
                        <th id="table-turtol">
                            <span>Trợ giảng</span>
                        </th>
                        <th id="table-active">
                            <span>Active</span>
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <SimpleStudentDataEvalute {...data} />
                    <SimpleStudentDataEvalute {...data} />
                    <SimpleStudentDataEvalute {...data} />
                    <SimpleStudentDataEvalute {...data} />
                    <SimpleStudentDataEvalute {...data} />
                    <SimpleStudentDataEvalute {...data} />
                </tbody>
            </Table>
        </div>
    );
}

export default EvaluteStudent;
