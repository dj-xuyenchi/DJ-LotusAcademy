import Button from 'react-bootstrap/Button';
import './StudentDetail.css';
import { useEffect, useRef, useState } from 'react';
import Table, { ColumnsType } from 'antd/es/table';
import { SimpleStudentEvalute } from '../../../../../entities/BusinessDTO/StudentManager/StudentEvalute/SimpleStudentEvalute';
import { columnsActiveSolution, columnsCourses } from '../../../../../entities/table/TableColumn';
import { LeftOutlined, RightOutlined } from '@ant-design/icons';
import studentStatisticalApi from '../../../../../api/BusinessApi/StudentManagerAPIs/StudentStatisticalApi';
import { mapData } from '../../../../../entities/BusinessDTO/StudentManager/StudentEvalute/StudentCourseSolution';
import { mapDataActiveSolution } from '../../../../../entities/BusinessDTO/StudentManager/StudentEvalute/ActiveSolution';
import { ActiveNote } from '../../../../../entities/BusinessDTO/StudentManager/StudentEvalute/ActiveNote';
import { activeType } from '../../../../../enums/ActiveType';
import { slotEnum } from '../../../../../enums/SlotEnum';
function StudentDetail() {
    const [tableView, setTableView] = useState(3)
    function handleSetTableView(opt: number) {
        setTableView(opt)
    }
    const [studentDetail, setStudentDetail] = useState(
        {
            status: 1,
            infoAndContact: {
                studentLAId: 1,
                studentLAName: "Ngọc Bảo Châu",
                studentLASdt: "098765523",
                studentCourses: null,
                employeeLAId: null,
                email: null,
                addressDetail: null,
                birthDay: "1-12-2003",
                gender: "Nam",
                job: null,
                zaloUrl: "0968491707",
                facebook: "fb/xuyenchi",
                employeeLAName: null,
                status: null
            },
            evaluteACourses: [
                {
                    sortNumber: 1,
                    courseName: "Full Stack Java",
                    signInDateTime: "1-1-2023",
                    supportTime: "4",
                    doneExpectedDateTime: "1-5-2023",
                    lessonNow: "C Basic",
                    evalute: "Yếu OOP"
                }
            ],
            studentActiveSolutions:
                [
                    {
                        sortNumber: 1,
                        createDateTime: "28-2-2023",
                        slot: "Ca 1",
                        activeStatus: "Đi muộn 20 phút",
                        reason: null,
                        confirmDateTime: "28-2-2023",
                        employeeConfirm: "Sếp Nguyên"
                    }
                ],
            mes: "Lấy dữ liệu thành công!"
        })
    useEffect(() => {
        const getData = async () => {
            const data = await studentStatisticalApi.getStudentDetailById(1)
            setStudentDetail(data)
        }
        getData()
    }, [])
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
                        <h4 style={{ marginTop: '20px', fontWeight: 'bold' }}>{studentDetail.infoAndContact.studentLAName}</h4>

                    </div>
                    <div className="info" style={{ marginTop: '32px', fontSize: '14px' }}>
                        <div>
                            <span>Email</span>
                            <p>{studentDetail.infoAndContact.email}</p>
                        </div>
                        <div>
                            <span>Số điện thoại</span>
                            <p>{studentDetail.infoAndContact.studentLASdt}</p>
                        </div>
                        <div>
                            <span>Địa chỉ</span>
                            <p>{studentDetail.infoAndContact.addressDetail}</p>
                        </div>
                        <div>
                            <span>Ngày sinh</span>
                            <p>{studentDetail.infoAndContact.birthDay}</p>
                        </div>
                        <div>
                            <span>Giới tính</span>
                            <p>{studentDetail.infoAndContact.gender}</p>
                        </div>
                        <div>
                            <span>Công việc</span>
                            <p>{studentDetail.infoAndContact.job}</p>
                        </div>
                        <div>
                            <span>Trạng thái</span>
                            <p>{studentDetail.infoAndContact.status}</p>
                        </div>
                        <div className="icons-social">
                            <span>Mạng xã hội</span>
                            <div style={{ display: 'flex' }}>
                                <a target="_blank" href={studentDetail.infoAndContact.zaloUrl}>
                                    <div className="icon-cirle">
                                        <img src={require('../../../../../assets/icons/zalo-icon-filled-256.png')} alt="" />
                                    </div>
                                </a>
                                <a target="_blank" href={studentDetail.infoAndContact.facebook}>
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
                    {tableView === 1 ? <TableViewSolution handleSetTableView={handleSetTableView} studentActiveSolutions={studentDetail.studentActiveSolutions} solutionEvalute={studentDetail.evaluteACourses} /> : ""
                    }
                    {tableView === 3 ? <TableViewActiveChart handleSetTableView={handleSetTableView} /> : ""
                    }
                </div>
            </div>
        </div>
    );
}
function TableViewSolution({ handleSetTableView, solutionEvalute, studentActiveSolutions }: any) {

    return (
        <>
            <h6 style={{ fontSize: '16px', marginBottom: '16px' }}>Các khóa học đăng ký</h6>
            <Table columns={columnsCourses} dataSource={mapData(solutionEvalute)} bordered={false} loading={false} pagination={{ position: ["bottomCenter"] }} />
            <h6 style={{ fontSize: '16px', marginBottom: '16px', marginTop: '16px' }}>Hoạt động - <span id='active-chart' onClick={() => {
                handleSetTableView(3)
            }}>Xem biểu đồ hoạt động</span></h6>
            <Table columns={columnsActiveSolution} dataSource={mapDataActiveSolution(studentActiveSolutions)} bordered={false} loading={false} pagination={{ position: ["bottomCenter"] }} />
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
    const [checkOutList, setCheckOutList] = useState<ActiveNote[]>([
        {
            day: 10,
            activeType: activeType.LATE,
            confirmDate: "19h-20p 10/02/2023",
            confirmEmployee: "Pé Mai",
            lateTotal: "20 phút",
            note: "Mải chơi",
            slot: slotEnum.CA1
        },
        {
            day: 20,
            activeType: activeType.NOTLATE,
            confirmDate: "19h-20p 20/02/2023",
            confirmEmployee: "Pé Mai",
            lateTotal: "20 phút",
            note: "Mải chơi",
            slot: slotEnum.CA4
        },
        {
            day: 31,
            activeType: activeType.UNACTIVE,
            confirmDate: "19h-20p 21/02/2023",
            confirmEmployee: "Pé Mai",
            lateTotal: "20 phút",
            note: "Không rõ",
            slot: slotEnum.CA123
        },
        {
            day: 11,
            activeType: activeType.UNACTIVEREASON,
            confirmDate: "19h-20p 21/02/2023",
            confirmEmployee: "Pé Mai",
            lateTotal: "20 phút",
            note: "Không rõ",
            slot: slotEnum.CA2
        },
    ])
    const las = new Date();
    const [updateState, setUpdateState] = useState(false);
    const [now, setNow] = useState(las)
    const content = useRef<any>()
    function setCalendarView(opt: number) {
        now.setMonth(now.getMonth() + opt)
        setNow(now)
        setUpdateState(!updateState);
        let dayCounter = 1;
        let lastDayOfLastMonth = new Date(now.getFullYear(), now.getMonth() - 1, 0).getDate();
        const lastDay = new Date(now.getFullYear(), now.getMonth() + 1, 0).getDate();
        const date = new Date();
        date.setMonth(now.getMonth())
        date.setDate(1)
        date.setFullYear(now.getFullYear())
        let dateOfMonth = date.getDay()
        let dayOfNextMonth = 1;
        if (content) {
            const trArray = content.current.children;
            for (const td of trArray[0].children) {
                if (dateOfMonth > 0) {
                    const span: HTMLSpanElement = document.createElement("span")
                    span.classList.add("day-of-last-and-next-month")
                    span.innerHTML = (lastDayOfLastMonth - dateOfMonth + 1).toString()
                    td.appendChild(span)
                    dateOfMonth--
                    continue
                }
                const span: HTMLSpanElement = document.createElement("span")
                span.classList.add("day-of-month")
                span.innerHTML = dayCounter.toString()
                td.appendChild(span)
                const attendance = checkOutList.find((element) => {
                    return element.day === dayCounter;
                })
                if (attendance) {
                    createAttendance(td, attendance)
                }
                dayCounter++
            }
            for (let i = 1; i < 6; i++) {
                for (const td of trArray[i].children) {
                    if (dayCounter > lastDay) {
                        const span: HTMLSpanElement = document.createElement("span")
                        span.classList.add("day-of-last-and-next-month")
                        span.innerHTML = dayOfNextMonth.toString()
                        dayOfNextMonth++
                        td.appendChild(span)
                        continue
                    }
                    const span: HTMLSpanElement = document.createElement("span")
                    span.classList.add("day-of-month")
                    span.innerHTML = dayCounter.toString()
                    dayCounter++
                    td.appendChild(span)
                    const attendance = checkOutList.find((element) => {
                        return element.day + 1 === dayCounter;
                    })
                    if (attendance) {
                        createAttendance(td, attendance)
                    }
                }
            }
        }
        const yearView = document.getElementById("calendar-year");
    }
    function handleClearSpan() {
        while (document.querySelector(".day-of-last-and-next-month")) {
            document.querySelector(".day-of-last-and-next-month")?.remove()
        }
        while (document.querySelector(".day-of-month")) {
            document.querySelector(".day-of-month")?.remove()
        }
        while (document.querySelector(".active-detail")) {
            document.querySelector(".active-detail")?.remove()
        }
        while (document.querySelector(".unactive-detail")) {
            document.querySelector(".unactive-detail")?.remove()
        }
        while (document.querySelector(".unactiveReason-detail")) {
            document.querySelector(".unactiveReason-detail")?.remove()
        }
        while (document.querySelector(".late-detail")) {
            document.querySelector(".late-detail")?.remove()
        }
    }
    useEffect(() => {
        setCalendarView(0)
        if(attendanceDiv){
            console.log(attendanceDiv);
            
        }
    }, [])
    useEffect(() => {
    }, [updateState])
    const attendanceDiv = useRef<any>(undefined)
   
    return (
        <div onMouseMove={(e) => {
            console.log(e.clientX);
            console.log(e.clientY);
        }}>
            <div ref={attendanceDiv} className="attendance-detail">
                s
            </div>
            <div style={{
                display: 'flex',
                justifyContent: "space-between"
            }}><h3 style={{ marginBottom: '16px', display: 'inline' }}>Lịch điểm danh học viên - <span id='back-solution' onClick={() => {
                handleSetTableView(1)
            }}>Trở lại tổng quan</span></h3>
                <h3 id='calendar-year' style={{ marginBottom: '16px', display: 'inline' }}>{now.getFullYear()}</h3></div>
            <div style={{
                display: "flex",
                justifyContent: "space-between"
            }}>
                <div id='button-group'>
                    <button>
                        <LeftOutlined style={{ fontSize: '30px', margin: "20px 30px 20px 0" }} onClick={() => {
                            handleClearSpan()
                            setCalendarView(-1)
                        }} />
                    </button>
                    <button>
                        <RightOutlined style={{ fontSize: '30px', margin: "20px 0 20px 0" }} onClick={() => {
                            handleClearSpan()
                            setCalendarView(1)
                        }} />
                    </button>
                </div>
                <div><span style={{
                    fontSize: "24px"
                }}>Tháng: {now.getMonth() + 1}</span></div>
            </div>
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
                            {/* <div className="active-detail">
                                <span className='title'>Ca học: <span>Ca 1</span></span>
                                <span className='title'>Điểm danh: <span>Quang Anh</span></span>
                            </div> */}
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
        </div>
    )
}
function createAttendance(td: HTMLElement, attendance: ActiveNote) {
    const divNote: HTMLDivElement = document.createElement("div")
    const contentContainer: HTMLDivElement = document.createElement("div")
    contentContainer.style.marginLeft = "4px"
    const slot: HTMLSpanElement = document.createElement("span")
    switch (attendance.slot) {
        case slotEnum.CA1:
            slot.innerHTML = "Ca 1"
            break;
        case slotEnum.CA2:
            slot.innerHTML = "Ca 2"
            break;
        case slotEnum.CA3:
            slot.innerHTML = "Ca 3"
            break;
        case slotEnum.CA12:
            slot.innerHTML = "Ca 1 và 2"
            break;
        case slotEnum.CA23:
            slot.innerHTML = "Ca 2 và 3"
            break;
        case slotEnum.CA123:
            slot.innerHTML = "Ca 1 2 và 3"
            break;
        case slotEnum.CA4:
            slot.innerHTML = "Học online ca 4"
            break;
        default:
            alert("Không có data")
    }
    contentContainer.appendChild(slot)
    if (attendance.activeType === activeType.LATE) {
        divNote.classList.add("late-detail")
        const spanLate = document.createElement("span")
        spanLate.innerHTML = "Muộn " + attendance.lateTotal
        contentContainer.appendChild(spanLate)
    }
    if (attendance.activeType === activeType.NOTLATE) {
        divNote.classList.add("active-detail")
    }
    if (attendance.activeType === activeType.UNACTIVE) {
        divNote.classList.add("unactive-detail")
    }
    if (attendance.activeType === activeType.UNACTIVEREASON) {
        divNote.classList.add("unactiveReason-detail")
    }
    divNote.appendChild(contentContainer)
    console.log(divNote);
    td.appendChild(divNote)
}
export default StudentDetail;
