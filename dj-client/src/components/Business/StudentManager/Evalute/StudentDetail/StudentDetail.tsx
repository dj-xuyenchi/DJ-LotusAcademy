import Button from 'react-bootstrap/Button';
import Table from 'react-bootstrap/Table';
import './StudentDetail.css';
import zalo from '../../../../../assets/icons/zalo-icon.svg';
import facebook from '../../../../../assets/icons/facebook-icon.svg';
import { useState } from 'react';
function StudentDetail() {
    const [studentDetail, setStudentDetail] = useState({
        avatar: "",
        name: "Thái Lan Hương",
        email: "huongkute@gmail.com",
        phone: "+84 968491797",
        location: "Thái Thụy - Thái Bình",
        birthday: "09-02-1999",
        gender: "Nữ",
        job: "Sinh viên cấp 2",
        active: "Đang học",
        zalo: "https://zalo.me/0968491797",
        facebook: "https://www.facebook.com/xuyenchi0902hihihi/",
        scoreBoard: [{
            stt: 1,
            lesson: "Java Method",
            score: 10,
            openTime: "02-01-2023",
            closeTime: "12-01-2023",
            employeeCheck: "Sếp Bình",
            evaluate: "Đạt",
            linkStudentTest: "gggdrive/123"
        }, {
            stt: 2,
            lesson: "C# Method",
            score: 10,
            openTime: "02-01-2023",
            closeTime: "12-01-2023",
            employeeCheck: "Sếp Bình",
            evaluate: "Đạt",
            linkStudentTest: "gggdrive/123"
        },]
    })
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
                        <div>
                            <span>Công việc</span>
                            <p>{studentDetail.job}</p>
                        </div>
                        <div>
                            <span>Trạng thái</span>
                            <p>{studentDetail.active}</p>
                        </div>
                        <div className="icons-social">
                            <span>Mạng xã hội</span>
                            <div style={{ display: 'flex' }}>
                                <a target="_blank" href={studentDetail.zalo}>
                                    <div className="icon-cirle">
                                        <img src={require('../../../../../assets/icons/zalo-icon-filled-256.png')} alt="" />
                                    </div>
                                </a>
                                <a target="_blank" href={studentDetail.facebook}>
                                    <div className="icon-cirle">
                                        <img src={require('../../../../../assets/icons/Facebook-200x200.jpg')} alt="" />
                                    </div>
                                </a>
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
                <div style={{ marginLeft: "20px", width: "100%" }}>
                    <h6 style={{ fontSize: '16px', marginBottom: '16px' }}>Các khóa học đăng ký</h6>
                    <Table className="table-default" hover>
                        <thead>
                            <tr style={{ backgroundColor: "#ccc" }}>
                                <th style={{ width: "10%" }}>
                                    <span>STT</span>
                                </th>
                                <th style={{ width: "20%" }}>
                                    <span>Tên khóa học</span>
                                </th>
                                <th style={{ width: "15%" }}>
                                    <span>Ngày đăng ký</span>
                                </th>
                                <th style={{ width: "15%" }}>
                                    <span>Thời gian hỗ trợ</span>
                                </th>
                                <th style={{ width: "15%" }}>
                                    <span>Dự kiến kết thúc</span>
                                </th>
                                <th style={{ width: "15%" }}>
                                    <span>Tiến độ hiện tại</span>
                                </th>
                                <th style={{ width: "10%" }}>
                                    <span>Đánh giá</span>
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <th>
                                    <span>1</span>
                                </th>
                                <th>
                                    <span>Back end Java</span>
                                </th>
                                <th>
                                    <span>20-10-2023</span>
                                </th>
                                <th>
                                    <span>4 tháng</span>
                                </th>
                                <th>
                                    <span>20-10-2023</span>
                                </th>
                                <th>
                                    <span>Java Basic</span>
                                </th>
                                <th>
                                    <span>Khá</span>
                                </th>
                            </tr>
                        </tbody>
                    </Table>
                    <h6 style={{ fontSize: '16px', marginBottom: '16px' }}>Nghỉ không phép</h6>
                    <Table className="table-default" hover>
                        <thead>
                            <tr style={{ backgroundColor: "#ccc" }}>
                                <th style={{ width: "10%" }}>
                                    <span>STT</span>
                                </th>
                                <th style={{ width: "25%" }}>
                                    <span>Ngày nghỉ</span>
                                </th>
                                <th style={{ width: "25%" }}>
                                    <span>Ca nghỉ</span>
                                </th>
                                <th style={{ width: "20%" }}>
                                    <span>Xác nhận </span>
                                </th>
                                <th style={{ width: "20%" }}>
                                    <span>Người xác nhận</span>
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <th>
                                    <span>1</span>
                                </th>
                                <th>
                                    <span>20-01-2023</span>
                                </th>
                                <th>
                                    <span>Ca 1-2</span>
                                </th>
                                <th>
                                    <span>20-01-2023:14h-30p</span>
                                </th>
                                <th>
                                    <span>Gấu mập</span>
                                </th>
                            </tr>
                        </tbody>
                    </Table>
                    <h6 style={{ fontSize: '16px', marginBottom: '16px' }}>Nghỉ có phép</h6>
                    <Table className="table-default" hover>
                        <thead>
                            <tr style={{ backgroundColor: "#ccc" }}>
                                <th style={{ width: "10%" }}>
                                    <span>STT</span>
                                </th>
                                <th style={{ width: "20%" }}>
                                    <span>Ngày nghỉ</span>
                                </th>
                                <th style={{ width: "10%" }}>
                                    <span>Ca nghỉ</span>
                                </th>
                                <th style={{ width: "20%" }}>
                                    <span>Lý do</span>
                                </th>
                                <th style={{ width: "25%" }}>
                                    <span>Xác nhận </span>
                                </th>
                                <th style={{ width: "15%" }}>
                                    <span>Người xác nhận</span>
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <th>
                                    <span>1</span>
                                </th>
                                <th>
                                    <span>20-01-2023</span>
                                </th>
                                <th>
                                    <span>Ca 1-2</span>
                                </th>
                                <th>
                                    <span>Đi pắn pia</span>
                                </th>
                                <th>
                                    <span>20-01-2023:14h-30p</span>
                                </th>
                                <th>
                                    <span>Gấu mập</span>
                                </th>
                            </tr>
                        </tbody>
                    </Table>
                    <h6 style={{ fontSize: '16px', marginBottom: '16px' }}>Bảo lưu</h6>
                    <Table className="table-default" hover>
                        <thead>
                            <tr style={{ backgroundColor: "#ccc" }}>
                                <th style={{ width: "10%" }}>
                                    <span>STT</span>
                                </th>
                                <th style={{ width: "20%" }}>
                                    <span>Lý do</span>
                                </th>
                                <th style={{ width: "20%" }}>
                                    <span>Bắt đầu</span>
                                </th>
                                <th style={{ width: "20%" }}>
                                    <span>Kết thúc dự kiến</span>
                                </th>
                                <th style={{ width: "15%" }}>
                                    <span>Số ngày bảo lưu</span>
                                </th>
                                <th style={{ width: "15%" }}>
                                    <span>Người xác nhận</span>
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <th>
                                    <span>1</span>
                                </th>
                                <th>
                                    <span>Việc bận gia đình</span>
                                </th>
                                <th>
                                    <span>30-01-2023</span>
                                </th>
                                <th>
                                    <span>19-02-2023</span>
                                </th>
                                <th>
                                    <span>20 ngày</span>
                                </th>
                                <th>
                                    <span>Gấu mập</span>
                                </th>
                            </tr>
                            <tr>
                                <th>
                                    <span>2</span>
                                </th>
                                <th>
                                    <span>Đi chơi</span>
                                </th>
                                <th>
                                    <span>23-02-2023</span>
                                </th>
                                <th>
                                    <span>29-02-2023</span>
                                </th>
                                <th>
                                    <span>6 ngày</span>
                                </th>
                                <th>
                                    <span>Gấu mập</span>
                                </th>
                            </tr>
                        </tbody>
                    </Table>
                    <h6 style={{ fontSize: '16px', marginBottom: '16px' }}>Bảng điểm</h6>
                    <Table className="table-default" hover>
                        <thead>
                            <tr style={{ backgroundColor: "#ccc" }}>
                                <th style={{ width: "10%" }}>
                                    <span>STT</span>
                                </th>
                                <th style={{ width: "15%" }}>
                                    <span>Học phần</span>
                                </th>
                                <th style={{ width: "15%" }}>
                                    <span>Ngày kiểm tra</span>
                                </th>
                                <th style={{ width: "15%" }}>
                                    <span>Ngày chấm</span>
                                </th>
                                <th style={{ width: "5%" }}>
                                    <span>Điểm</span>
                                </th>
                                <th style={{ width: "10%" }}>
                                    <span>Đánh giá</span>
                                </th>
                                <th style={{ width: "15%" }}>
                                    <span>Người check</span>
                                </th>
                                <th style={{ width: "15%" }}>
                                    <span>Link bài làm</span>
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            {studentDetail.scoreBoard.map((item) => {
                                return <DetailRow item={item} />
                            })}
                        </tbody>
                    </Table>
                </div>
            </div>
        </div>
    );
}
function DetailRow({ item }: any) {
    return (
        <><tr>
            <th>
                <span>{item.stt}</span>
            </th>
            <th>
                <span>{item.lesson}</span>
            </th>
            <th>
                <span>{item.openTime}</span>
            </th>
            <th>
                <span>{item.closeTime}</span>
            </th>
            <th>
                <span>{item.score}</span>
            </th>
            <th>
                <span>{item.evaluate}</span>
            </th>
            <th>
                <span>{item.employeeCheck}</span>
            </th>
            <th>
                <span>{item.linkStudentTest}</span>
            </th>
        </tr></>
    )
}
export default StudentDetail;
