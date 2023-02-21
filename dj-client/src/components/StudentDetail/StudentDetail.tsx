import Button from "react-bootstrap/Button";
import Table from "react-bootstrap/Table";
import {
    FaPinterestP,
    FaFacebookF,
    FaTwitter,
    FaLinkedinIn,
} from "react-icons/fa";
function StudentDetail() {
    return (
        <div className="StudentDetail w-100" style={{ padding: "24px 32px" }}>
            <div className="detail-title">
                <h3>Student Detail</h3>
            </div>
            <div style={{ display: "flex" }}>
                <div
                    className="card"
                    style={{ width: "400px", padding: "20px" }}
                >
                    <div className="avatar" style={{ margin: "0 auto" }}>
                        <img
                            src="https://elstar.themenate.net/img/avatars/thumb-1.jpg"
                            alt=""
                            style={{ borderRadius: "50%" }}
                        />
                        <h4 style={{ marginTop: "20px", fontWeight: "bold" }}>
                            Nguyễn Quang Anh
                        </h4>
                    </div>
                    <div
                        className="info"
                        style={{ marginTop: "32px", fontSize: "14px" }}
                    >
                        <div>
                            <span>Email</span>
                            <p>quanganh@gmail.com</p>
                        </div>
                        <div>
                            <span>Phone</span>
                            <p>quanganh@gmail.com</p>
                        </div>
                        <div>
                            <span>Location</span>
                            <p>quanganh@gmail.com</p>
                        </div>
                        <div>
                            <span>Date of birth</span>
                            <p>quanganh@gmail.com</p>
                        </div>
                        <div>
                            <span>Title</span>
                            <p>quanganh@gmail.com</p>
                        </div>
                        <div>
                            <span>Social</span>
                            <div style={{ display: "flex" }}>
                                <div
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
                                <div
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
                                <div
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
                                <div
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
                        <h6 style={{ fontSize: "16px", marginBottom: "16px" }}>
                            Sale
                        </h6>
                        <div
                            style={{
                                height: "85px",
                                backgroundColor: "#ccc",
                                borderRadius: "20px",
                            }}
                        ></div>
                    </div>
                    <h6 style={{ fontSize: "16px", marginBottom: "16px" }}>
                        Bảng điểm
                    </h6>
                    <Table className="table-default" hover>
                        <thead>
                            <tr style={{ backgroundColor: "#ccc" }}>
                                <th>
                                    <span>Học viên</span>
                                </th>
                                <th>
                                    <span>Học phần</span>
                                </th>
                                <th>
                                    <span>Điểm kiểm tra</span>
                                </th>
                                <th>
                                    <span>Đánh giá</span>
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <th>
                                    <span>Nguyễn Quang Anh</span>
                                </th>
                                <th>
                                    <span>Java</span>
                                </th>
                                <th>
                                    <span>9</span>
                                </th>
                                <th>
                                    <span>Đạt</span>
                                </th>
                            </tr>
                        </tbody>
                    </Table>
                </div>
            </div>
        </div>
    );
}
export default StudentDetail;
