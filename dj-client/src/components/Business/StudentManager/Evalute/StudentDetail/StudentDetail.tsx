import Button from 'react-bootstrap/Button';
import './StudentDetail.css';
import { useEffect, useRef, useState } from 'react';
import Table, { ColumnsType } from 'antd/es/table';
import { SimpleStudentEvalute } from '../../../../../entities/BusinessDTO/StudentManager/StudentEvalute/SimpleStudentEvalute';
import { Tag } from 'antd';
import { Link } from 'react-router-dom';
import { columnsCourses, columnsUnactiveReason } from '../../../../../entities/table/TableColumn';
function StudentDetail() {
    const [tableView, setTableView] = useState(3)
    function handleSetTableView(opt: number) {
        setTableView(opt)
    }
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
                <h3>Thông tin học viên </h3>
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
                                Bảo lưu
                            </Button>
                            <Button variant="primary" style={{ width: '50%' }}>
                                Sửa thông tin
                            </Button>
                        </div>
                    </div>
                </div>
                <div style={{ marginLeft: "20px", width: "100%" }}>
                    {tableView === 1 ? <TableViewSolution handleSetTableView={handleSetTableView} /> : ""
                    }
                    {tableView === 3 ? <TableViewActiveChart handleSetTableView={handleSetTableView} /> : ""
                    }
                </div>
            </div>
        </div>
    );
}
function TableViewSolution({ handleSetTableView }: any) {
    return (
        <>
            <h6 style={{ fontSize: '16px', marginBottom: '16px' }}>Các khóa học đăng ký</h6>
            <Table columns={columnsCourses} bordered={false} loading={false} pagination={{ position: ["bottomCenter"] }} />
            <h6 style={{ fontSize: '16px', marginBottom: '16px', marginTop: '16px' }}>Nghỉ học - <span id='active-chart' onClick={() => {
                handleSetTableView(3)
            }}>Xem biểu đồ hoạt động</span></h6>
            <Table columns={columnsUnactiveReason} bordered={false} loading={false} pagination={{ position: ["bottomCenter"] }} />
        </>
    )
}
function TableViewReserve() {
    return (
        <>
            <h6 style={{ fontSize: '16px', marginBottom: '16px' }}>Bảo lưu</h6>
            <Table columns={columnsCourses} bordered={false} loading={false} pagination={{ position: ["bottomCenter"] }} />
        </>
    )
}
function TableViewActiveChart({ handleSetTableView }: any) {
    const [now, setNow] = useState(new Date())
    const content = useRef<any>()
    useEffect(() => {
        let dayCounter = 1;
        const lastDay = new Date(now.getFullYear(), now.getMonth() + 1, 0).getDate();

        const date = new Date();
        date.setMonth(now.getMonth())
        date.setDate(1)
        date.setFullYear(now.getFullYear())
        let dateOfMonth = date.getDay()
        // console.log(dateOfMonth)3
        if (content) {
            const trArray = content.current.children;
            for (const td of trArray[0].children) {
                if (dateOfMonth > 0) {
                    dateOfMonth--
                    continue
                }
                const span: HTMLSpanElement = document.createElement("span")
                span.classList.add("day-of-month")
                span.innerHTML = dayCounter.toString()
                dayCounter++
                td.appendChild(span)
            }
            for (let i = 1; i < 6; i++) {
                for (const td of trArray[i].children) {
                    if (dayCounter > lastDay) {
                        break;
                    }
                    const span: HTMLSpanElement = document.createElement("span")
                    span.classList.add("day-of-month")
                    span.innerHTML = dayCounter.toString()
                    dayCounter++
                    td.appendChild(span)
                }
            }
        }
    }, [])
    return (
        <>
            <div style={{
                display: 'flex',
                justifyContent: "space-between"
            }}><h3 style={{ marginBottom: '16px', display: 'inline' }}>Biểu đồ đi học - <span id='back-solution' onClick={() => {
                handleSetTableView(1)
            }}>Trở lại tổng quan</span></h3>
                <h3 style={{ marginBottom: '16px', display: 'inline' }}>2023</h3></div>
            <table className='active-table'>
                <thead className="chart-header">
                    <tr>
                        <th className="element-week"><span>Chủ nhật</span></th>
                        <th className="element-week"><span>Thứ 2</span></th>
                        <th className="element-week"><span>Thứ 3</span></th>
                        <th className="element-week"><span>Thứ 4</span></th>
                        <th className="element-week"><span>Thứ 5</span></th>
                        <th className="element-week"><span>Thứ 6</span></th>
                        <th className="element-week"><span>Thứ 7</span></th>
                    </tr>
                </thead>
                <tbody ref={content}>
                    <tr>
                        <td>
                            <div className="active-detail">
                                <span className='title'>Ca học: <span>Ca 1</span></span>
                                <span className='title'>Điểm danh: <span>Quang Anh</span></span>
                            </div>
                        </td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>

                </tbody>
            </table>
        </>
    )
}
export default StudentDetail;
