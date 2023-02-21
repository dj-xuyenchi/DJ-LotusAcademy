import Table from "react-bootstrap/Table";
import "./EvaluteStudent.css";
import SimpleStudentDataEvalute from "./SimpleEval/SimpleStudentDataEvalute";
import {
    mapData,
    SimpleStudentEvalute,
} from "../../../../entities/BusinessDTO/StudentManager/StudentEvalute/SimpleStudentEvalute";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {
    faUsers,
    faArrowUp,
    faSearch,
} from "@fortawesome/free-solid-svg-icons";
import Dropdown from "react-bootstrap/Dropdown";
import Button from "react-bootstrap/Button";
import { Link } from "react-router-dom";
import { useEffect, useState } from "react";
import studentStatisticalApi from "../../../../api/BusinessApi/StudentManagerAPIs/StudentStatisticalApi";
function EvaluteStudent() {
    const [studentPaging10, setStudentPaging10] = useState([
        {
            studentAvatar:
                "https://img.meta.com.vn/Data/image/2021/09/22/anh-meo-cute-de-thuong-dang-yeu-41.jpg",
            studentName: "Đỗ Quang Anh",
            studentSdt: "0987123123",
            studentCourse: "java",
            studentTurtor: "Chị Giang",
            studentActive: true,
        },
    ]);

    useEffect(() => {
        const callApi = async () => {
            const data = await studentStatisticalApi.getListStudentByPaging(1);
            console.log(data);
            setStudentPaging10(mapData(data.data));
        };
        callApi();
    }, []);
    return (
        <div
            className="EvaStudent"
            style={{
                padding: "24px 32px",
                width: "100%",
                margin: "0 auto",
            }}
        >
            <div className="table-title">
                <h3>Thống kê</h3>
            </div>
            <div className="statistical row g-2">
                <div className="statistical_item col-md-6 col-lg-4 col-xl-3">
                    <div
                        className="content items-center h-100"
                        style={{
                            display: "flex",
                            justifyContent: "space-between",
                            border: "1px solid #ccc",
                            borderRadius: "10px",
                            padding: "20px",
                        }}
                    >
                        <div
                            className="content-left items-center"
                            style={{ display: "flex" }}
                        >
                            <div
                                className="logo"
                                style={{
                                    // width: "55px",
                                    // height: "55px",
                                    marginRight: "15px",
                                }}
                            >
                                <FontAwesomeIcon
                                    icon={faUsers}
                                    style={{
                                        fontSize: "30px",
                                        padding: "10px 10px",
                                    }}
                                />
                            </div>
                            <div>
                                <span
                                    style={{
                                        display: "block",
                                        marginBottom: "8px",
                                    }}
                                >
                                    Total Customers
                                </span>
                                <h3 className="mb-0">2,420</h3>
                            </div>
                        </div>
                        <div
                            className="content-right"
                            style={{
                                // height: "55px",
                                display: "flex",
                                alignItems: "center",
                            }}
                        >
                            <div
                                style={{
                                    fontSize: "13px",
                                    padding: "3px 8px",
                                    backgroundColor: "#D1FAE5",
                                    borderRadius: "25px",
                                }}
                            >
                                <FontAwesomeIcon icon={faArrowUp} />
                                <span style={{ marginLeft: "5px" }}>17.2%</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="statistical_item col-md-6 col-lg-4 col-xl-3">
                    <div
                        className="content items-center h-100"
                        style={{
                            display: "flex",
                            justifyContent: "space-between",
                            border: "1px solid #ccc",
                            borderRadius: "10px",
                            padding: "20px",
                        }}
                    >
                        <div
                            className="content-left items-center"
                            style={{ display: "flex" }}
                        >
                            <div
                                className="logo"
                                style={{
                                    // width: "55px",
                                    // height: "55px",
                                    marginRight: "15px",
                                }}
                            >
                                <FontAwesomeIcon
                                    icon={faUsers}
                                    style={{
                                        fontSize: "30px",
                                        padding: "10px 10px",
                                    }}
                                />
                            </div>
                            <div>
                                <span
                                    style={{
                                        display: "block",
                                        marginBottom: "8px",
                                    }}
                                >
                                    Total Customers
                                </span>
                                <h3 className="mb-0">2,420</h3>
                            </div>
                        </div>
                        <div
                            className="content-right"
                            style={{
                                // height: "55px",
                                display: "flex",
                                alignItems: "center",
                            }}
                        >
                            <div
                                style={{
                                    fontSize: "13px",
                                    padding: "3px 8px",
                                    backgroundColor: "#D1FAE5",
                                    borderRadius: "25px",
                                }}
                            >
                                <FontAwesomeIcon icon={faArrowUp} />
                                <span style={{ marginLeft: "5px" }}>17.2%</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="statistical_item col-md-6 col-lg-4 col-xl-3">
                    <div
                        className="content items-center h-100"
                        style={{
                            display: "flex",
                            justifyContent: "space-between",
                            border: "1px solid #ccc",
                            borderRadius: "10px",
                            padding: "20px",
                        }}
                    >
                        <div
                            className="content-left items-center"
                            style={{ display: "flex" }}
                        >
                            <div
                                className="logo"
                                style={{
                                    // width: "55px",
                                    // height: "55px",
                                    marginRight: "15px",
                                }}
                            >
                                <FontAwesomeIcon
                                    icon={faUsers}
                                    style={{
                                        fontSize: "30px",
                                        padding: "10px 10px",
                                    }}
                                />
                            </div>
                            <div>
                                <span
                                    style={{
                                        display: "block",
                                        marginBottom: "8px",
                                    }}
                                >
                                    Total Customers
                                </span>
                                <h3 className="mb-0">2,420</h3>
                            </div>
                        </div>
                        <div
                            className="content-right"
                            style={{
                                // height: "55px",
                                display: "flex",
                                alignItems: "center",
                            }}
                        >
                            <div
                                style={{
                                    fontSize: "13px",
                                    padding: "3px 8px",
                                    backgroundColor: "#D1FAE5",
                                    borderRadius: "25px",
                                }}
                            >
                                <FontAwesomeIcon icon={faArrowUp} />
                                <span style={{ marginLeft: "5px" }}>17.2%</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="statistical_item col-md-6 col-lg-4 col-xl-3">
                    <div
                        className="content items-center h-100"
                        style={{
                            display: "flex",
                            justifyContent: "space-between",
                            border: "1px solid #ccc",
                            borderRadius: "10px",
                            padding: "20px",
                        }}
                    >
                        <div
                            className="content-left items-center"
                            style={{ display: "flex" }}
                        >
                            <div
                                className="logo"
                                style={{
                                    // width: "55px",
                                    // height: "55px",
                                    marginRight: "15px",
                                }}
                            >
                                <FontAwesomeIcon
                                    icon={faUsers}
                                    style={{
                                        fontSize: "30px",
                                        padding: "10px 10px",
                                    }}
                                />
                            </div>
                            <div>
                                <span
                                    style={{
                                        display: "block",
                                        marginBottom: "8px",
                                    }}
                                >
                                    Total Customers
                                </span>
                                <h3 className="mb-0">2,420</h3>
                            </div>
                        </div>
                        <div
                            className="content-right"
                            style={{
                                // height: "55px",
                                display: "flex",
                                alignItems: "center",
                            }}
                        >
                            <div
                                style={{
                                    fontSize: "13px",
                                    padding: "3px 8px",
                                    backgroundColor: "#D1FAE5",
                                    borderRadius: "25px",
                                }}
                            >
                                <FontAwesomeIcon icon={faArrowUp} />
                                <span style={{ marginLeft: "5px" }}>17.2%</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div
                className="feature"
                style={{
                    height: "36px",
                    marginBottom: "20px",
                    display: "flex",
                    justifyContent: "space-between",
                }}
            >
                <div style={{ display: "flex" }}>
                    <div
                        className="search"
                        style={{
                            border: "1px solid #ccc",
                            borderRadius: "10px",
                            height: "100%",
                            display: "flex",
                            alignItems: "center",
                        }}
                    >
                        <FontAwesomeIcon
                            icon={faSearch}
                            style={{ padding: "0px 10px" }}
                        />
                        <input
                            type="text"
                            style={{ border: "none", outline: "none" }}
                            placeholder="Search"
                        />
                    </div>
                    <div className="filter">
                        <Dropdown>
                            <Dropdown.Toggle
                                variant="success"
                                id="dropdown-basic"
                            >
                                All
                            </Dropdown.Toggle>
                            <Dropdown.Menu>
                                <Dropdown.Item href="#/action-1">
                                    All
                                </Dropdown.Item>
                                <Dropdown.Item href="#/action-2">
                                    Active
                                </Dropdown.Item>
                                <Dropdown.Item href="#/action-3">
                                    Block
                                </Dropdown.Item>
                            </Dropdown.Menu>
                        </Dropdown>
                    </div>
                </div>
                <div className="export">
                    <Button variant="outline-secondary">Export</Button>{" "}
                </div>
            </div>
            <Table className="table-default" hover responsive="sm">
                <thead>
                    <tr style={{ backgroundColor: "#ccc" }}>
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
                    {studentPaging10.map(
                        (element: SimpleStudentEvalute, index: number) => {
                            return (
                                <SimpleStudentDataEvalute
                                    key={index}
                                    {...element}
                                />
                            );
                        }
                    )}
                </tbody>
            </Table>
        </div>
    );
}

export default EvaluteStudent;
