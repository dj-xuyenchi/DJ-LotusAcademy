import Button from "react-bootstrap/Button";
import Table from "react-bootstrap/Table";
import './StudentDetail.css'
import {
    FaPinterestP,
    FaFacebookF,
    FaTwitter,
    FaLinkedinIn,
} from "react-icons/fa";
import { useEffect, useState } from "react";
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
        zalo: "http://zalo.com/123",
        facebook: "http://facebook.com/anhlin",
        scoreBoard: [{
            lesson: "Java Method",
            score: 10,
            openTime: "02-01-2023",
            closeTime: "12-01-2023",
            employeeCheck: "Sếp Bình",
            evaluate: "Đạt",
            linkStudentTest: "gggdrive/123"
        }, {
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
        <div className="StudentDetail w-100" style={{ padding: "24px 32px" }}>
            <div className="detail-title">
                <h3>Student Detail</h3>
            </div>
            <div style={{ display: "flex" }}>
                <div
                    className="card"
                    style={{ width: "30%", padding: "20px" }}
                >
                    <div className="avatar" style={{ display: 'flex', justifyContent: 'center' }}>
                        <img
                            src="https://elstar.themenate.net/img/avatars/thumb-1.jpg"
                            alt=""
                            style={{ borderRadius: "50%", height: "100px", width: "100px", alignItems: 'center' }}
                        />
                    </div>
                    <div className="name" style={{ alignItems: "center", margin: "0 auto" }}>
                        <h4 style={{ marginTop: "20px", fontWeight: "bold" }}>
                            {studentDetail.name}

                        </h4>
                    </div>
                    <div
                        className="info"
                        style={{ marginTop: "32px", fontSize: "14px" }}
                    >
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
                            <span>Social</span>
                            <div style={{ display: "flex" }}>
                                <div className="icon-cirle"
                                    style={{
                                        width: "30px",
                                        height: "30px",
                                        borderRadius: "50%",
                                        display: "flex",
                                        alignItems: "center",
                                        justifyContent: "center",
                                        border: "1px solid #ccc",
                                    }}
                                >
                                    <FaPinterestP size={"20px"} />
                                </div>
                                <div className="icon-cirle"
                                    style={{
                                        width: "30px",
                                        height: "30px",
                                        borderRadius: "50%",
                                        display: "flex",
                                        alignItems: "center",
                                        justifyContent: "center",
                                        border: "1px solid #ccc",
                                    }}
                                >
                                    <FaFacebookF size={"20px"} />
                                </div>
                                <div className="icon-cirle"
                                    style={{
                                        width: "30px",
                                        height: "30px",
                                        borderRadius: "50%",
                                        display: "flex",
                                        alignItems: "center",
                                        justifyContent: "center",
                                        border: "1px solid #ccc",
                                    }}
                                >
                                    <FaTwitter size={"20px"} />
                                </div>
                                <div className="icon-cirle"
                                    style={{
                                        width: "30px",
                                        height: "30px",
                                        borderRadius: "50%",
                                        display: "flex",
                                        alignItems: "center",
                                        justifyContent: "center",
                                        border: "1px solid #ccc",
                                    }}
                                >
                                    <FaLinkedinIn size={"20px"} />
                                </div>
                            </div>
                        </div>
                        <div style={{ display: "flex", marginTop: "20px" }}>
                            <Button
                                variant="outline-secondary"
                                style={{
                                    width: "50%",
                                    height: "36px",
                                    marginRight: "10px",
                                }}
                            >
                                Delete
                            </Button>
                            <Button variant="primary" style={{ width: "50%" }}>
                                Edit
                            </Button>
                        </div>
                    </div>
                </div>
                <div style={{ marginLeft: "20px", width: "100%" }}>
                    <div style={{ marginBottom: "32px" }}>
                        <div
                            style={{
                                height: "85px",
                                backgroundColor: "#ffff",
                                borderRadius: "20px",
                                border: "1px solid rgba(0, 0, 0, 0.175)"
                            }}
                        >



                        </div>
                    </div>
                    <h6 style={{ fontSize: "16px", marginBottom: "16px" }}>
                        Bảng điểm
                    </h6>
                    <Table className="table-default" hover>
                        <thead>
                            <tr style={{ backgroundColor: "#ccc" }}>
                                <th style={{ width: "20%" }}>
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
                                <th style={{ width: "20%" }}>
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
