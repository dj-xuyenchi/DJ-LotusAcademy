import Button from 'react-bootstrap/Button';
import Table from 'react-bootstrap/Table';
import './StudentDetail.css';
import zalo from '../../../../../assets/icons/zalo-icon.svg';
import facebook from '../../../../../assets/icons/facebook-icon.svg';
import { useEffect, useState } from 'react';
function StudentDetail() {
    const [studentDetail, setStudentDetail] = useState({
        avatar: '',
        name: 'Thái Lan Hương',
        email: 'huongkute@gmail.com',
        phone: '+84 968491797',
        location: 'Thái Thụy - Thái Bình',
        birthday: '09-02-1999',
        gender: 'Nữ',
        zalo: 'http://zalo.com/123',
        facebook: 'http://facebook.com/anhlin',
        scoreBoard: [
            {
                lesson: 'Java Method',
                score: 10,
                dateTime: '02-1-2023',
                employeeCheck: 'Sếp Bình',
                evaluate: 'Đạt',
                linkStudentTest: 'gggdrive/123',
            },
            {
                lesson: 'C# Method',
                score: 10,
                dateTime: '02-1-2023',
                employeeCheck: 'Sếp Bình',
                evaluate: 'Đạt',
                linkStudentTest: 'gggdrive/123',
            },
        ],
    });
    return (
        <div className="StudentDetail w-100" style={{ padding: '24px 32px' }}>
            <div className="detail-title">
                <h3>Student Detail</h3>
            </div>
            <div style={{ display: 'flex' }}>
                <div className="card" style={{ width: '30%', padding: '20px' }}>
                    <div className="avatar" style={{ display: 'flex', justifyContent: 'center' }}>
                        <img
                            src="https://elstar.themenate.net/img/avatars/thumb-1.jpg"
                            alt=""
                            style={{ borderRadius: '50%', height: '100px', width: '100px', alignItems: 'center' }}
                        />
                    </div>
                    <div className="name" style={{ alignItems: 'center', margin: '0 auto' }}>
                        <h4 style={{ marginTop: '20px', fontWeight: 'bold' }}>{studentDetail.name}</h4>
                    </div>
                    <div className="info" style={{ marginTop: '32px', fontSize: '14px' }}>
                        <div>
                            <span>Email</span>
                            <p>{studentDetail.email}</p>
                        </div>
                        <div>
                            <span>Số điện thoại</span>
                            <p>{studentDetail.phone}</p>
                        </div>
                        <div>
                            <span>Địa chỉ</span>
                            <p>{studentDetail.location}</p>
                        </div>
                        <div>
                            <span>Ngày sinh</span>
                            <p>{studentDetail.birthday}</p>
                        </div>
                        <div>
                            <span>Giới tính</span>
                            <p>{studentDetail.gender}</p>
                        </div>
                        <div className="icons-social">
                            <span>Social</span>
                            <div style={{ display: 'flex' }}>
                                <div className="icon-cirle">
                                    <img src={zalo} alt="" />
                                </div>
                                <div className="icon-cirle">
                                    <img src={facebook} alt="" />
                                </div>
                            </div>
                        </div>
                        <div style={{ display: 'flex', marginTop: '20px' }}>
                            <Button
                                variant="outline-secondary"
                                style={{
                                    width: '50%',
                                    height: '36px',
                                    marginRight: '10px',
                                }}
                            >
                                Delete
                            </Button>
                            <Button variant="primary" style={{ width: '50%' }}>
                                Edit
                            </Button>
                        </div>
                    </div>
                </div>
                <div style={{ marginLeft: '20px', width: '100%' }}>
                    <div style={{ marginBottom: '32px' }}>
                        <h6 style={{ fontSize: '16px', marginBottom: '16px' }}>Sale</h6>
                        <div
                            style={{
                                height: '85px',
                                backgroundColor: '#ffff',
                                borderRadius: '20px',
                                border: '1px solid rgba(0, 0, 0, 0.175)',
                            }}
                        ></div>
                    </div>
                    <h6 style={{ fontSize: '16px', marginBottom: '16px' }}>Bảng điểm</h6>
                    <Table className="table-default" hover>
                        <thead>
                            <tr style={{ backgroundColor: '#ccc' }}>
                                <th>
                                    <span>Học phần</span>
                                </th>
                                <th>
                                    <span>Ngày kiểm tra</span>
                                </th>
                                <th>
                                    <span>Điểm</span>
                                </th>
                                <th>
                                    <span>Đánh giá</span>
                                </th>
                                <th>
                                    <span>Người check</span>
                                </th>
                                <th>
                                    <span>Link bài làm</span>
                                </th>
                            </tr>
                        </thead>
                        {/* <tbody>
                            {studentDetail.scoreBoard.map((item) => {
                                return `<tr>
                                <th>
                                    <span>${item.lesson}</span>
                                </th>
                                <th>
                                    <span>${item.dateTime}</span>
                                </th>
                                <th>
                                    <span>${item.score}</span>
                                </th>
                                <th>
                                    <span>${item.evaluate}</span>
                                </th>
                                <th>
                                    <span>${item.employeeCheck}</span>
                                </th>
                                <th>
                                    <span>${item.linkStudentTest}</span>
                                </th>
                            </tr>`;
                            })}
                        </tbody> */}
                    </Table>
                </div>
            </div>
        </div>
    );
}
export default StudentDetail;
