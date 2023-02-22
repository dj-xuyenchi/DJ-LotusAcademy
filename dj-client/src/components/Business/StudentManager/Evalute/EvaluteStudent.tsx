import Table from 'react-bootstrap/Table';
import './EvaluteStudent.css';
import SimpleStudentDataEvalute from './SimpleStudentDataEvalute';
import {
    mapData,
    SimpleStudentEvalute,
} from '../../../../entities/BusinessDTO/StudentManager/StudentEvalute/SimpleStudentEvalute';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faUsers, faArrowUp, faSearch } from '@fortawesome/free-solid-svg-icons';
import Dropdown from 'react-bootstrap/Dropdown';
import Button from 'react-bootstrap/Button';
import { useEffect, useState } from 'react';
import studentStatisticalApi from '../../../../api/BusinessApi/StudentManagerAPIs/StudentStatisticalApi';
function EvaluteStudent() {
    const [evaluteData, setEvaluteData] = useState({
        data: [
            {
                studentAvatar: 'https://img.meta.com.vn/Data/image/2021/09/22/anh-meo-cute-de-thuong-dang-yeu-41.jpg',
                studentName: 'Đỗ Quang Anh',
                studentSdt: '0987123123',
                studentCourse: 'java',
                studentTurtor: 'Chị Giang',
                studentActive: true,
            },
        ],
        solutionCenterLADTO: {
            totalStudentOFF: 0,
            totalStudentLA: 0,
            totalStudentLAThisMonth: 0,
            totalStudentON: 0,
            totalStudentReserve: 0,
        },
        mes: '',
        status: 0,
    });

    useEffect(() => {
        const dt = setInterval(() => {
            const callApi = async () => {
                const data = await studentStatisticalApi.getListStudentByPaging(1);
                console.log(data);
                setEvaluteData(data);
            };
            callApi();
        }, 10000);
        return () => {
            clearInterval(dt);
        };
    }, []);

    return (
        <div
            className="EvaStudent"
            style={{
                padding: '24px 32px',
                width: '100%',
                margin: '0 auto',
            }}
        >
            <div className="table-title">
                <h3>Danh sách học viên</h3>
            </div>
            <div className="statistical row g-2">
                <div className="statistical_item col-md-6 col-lg-4 col-xl-3">
                    <div
                        className="content items-center h-100"
                        style={{
                            display: 'flex',
                            justifyContent: 'space-between',
                            border: '1px solid #ccc',
                            borderRadius: '10px',
                            padding: '20px',
                        }}
                    >
                        <div className="content-left items-center" style={{ display: 'flex' }}>
                            <div
                                className="logo"
                                style={{
                                    // width: "55px",
                                    // height: "55px",
                                    marginRight: '15px',
                                }}
                            >
                                <FontAwesomeIcon
                                    icon={faUsers}
                                    style={{
                                        fontSize: '30px',
                                        padding: '10px 10px',
                                    }}
                                />
                            </div>
                            <div>
                                <span
                                    style={{
                                        display: 'block',
                                        marginBottom: '8px',
                                    }}
                                >
                                    Đang theo học
                                </span>
                                <h4 className="mb-0">{evaluteData.solutionCenterLADTO.totalStudentLA}</h4>
                            </div>
                        </div>
                        <div
                            className="content-right"
                            style={{
                                // height: "55px",
                                display: 'flex',
                                alignItems: 'center',
                            }}
                        >
                            <div
                                style={{
                                    fontSize: '20px',
                                    padding: '3px 8px',
                                    backgroundColor: '#D1FAE5',
                                    borderRadius: '25px',
                                }}
                            >
                                <FontAwesomeIcon icon={faArrowUp} />
                                <span style={{ marginLeft: '5px' }}>
                                    {evaluteData.solutionCenterLADTO.totalStudentLAThisMonth}
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="statistical_item col-md-6 col-lg-4 col-xl-3">
                    <div
                        className="content items-center h-100"
                        style={{
                            display: 'flex',
                            justifyContent: 'space-between',
                            border: '1px solid #ccc',
                            borderRadius: '10px',
                            padding: '20px',
                        }}
                    >
                        <div className="content-left items-center" style={{ display: 'flex' }}>
                            <div
                                className="logo"
                                style={{
                                    // width: "55px",
                                    // height: "55px",
                                    marginRight: '15px',
                                }}
                            >
                                <FontAwesomeIcon
                                    icon={faUsers}
                                    style={{
                                        fontSize: '30px',
                                        padding: '10px 10px',
                                    }}
                                />
                            </div>
                            <div>
                                <span
                                    style={{
                                        display: 'block',
                                        marginBottom: '8px',
                                    }}
                                >
                                    Học Offline
                                </span>
                                <h4 className="mb-0">{evaluteData.solutionCenterLADTO.totalStudentOFF}</h4>
                            </div>
                        </div>
                        <div
                            className="content-right"
                            style={{
                                // height: "55px",
                                display: 'flex',
                                alignItems: 'center',
                            }}
                        >
                            {/* <div
                                style={{
                                    fontSize: "13px",
                                    padding: "3px 8px",
                                    backgroundColor: "#D1FAE5",
                                    borderRadius: "25px",
                                }}
                            >
                                <FontAwesomeIcon icon={faArrowUp} />
                                <span style={{ marginLeft: "5px" }}>17.2%</span>
                            </div> */}
                        </div>
                    </div>
                </div>
                <div className="statistical_item col-md-6 col-lg-4 col-xl-3">
                    <div
                        className="content items-center h-100"
                        style={{
                            display: 'flex',
                            justifyContent: 'space-between',
                            border: '1px solid #ccc',
                            borderRadius: '10px',
                            padding: '20px',
                        }}
                    >
                        <div className="content-left items-center" style={{ display: 'flex' }}>
                            <div
                                className="logo"
                                style={{
                                    // width: "55px",
                                    // height: "55px",
                                    marginRight: '15px',
                                }}
                            >
                                <FontAwesomeIcon
                                    icon={faUsers}
                                    style={{
                                        fontSize: '30px',
                                        padding: '10px 10px',
                                    }}
                                />
                            </div>
                            <div>
                                <span
                                    style={{
                                        display: 'block',
                                        marginBottom: '8px',
                                    }}
                                >
                                    Học Online
                                </span>
                                <h4 className="mb-0">{evaluteData.solutionCenterLADTO.totalStudentON}</h4>
                            </div>
                        </div>
                        <div
                            className="content-right"
                            style={{
                                // height: "55px",
                                display: 'flex',
                                alignItems: 'center',
                            }}
                        >
                            {/* <div
                                style={{
                                    fontSize: "13px",
                                    padding: "3px 8px",
                                    backgroundColor: "#D1FAE5",
                                    borderRadius: "25px",
                                }}
                            >
                                <FontAwesomeIcon icon={faArrowUp} />
                                <span style={{ marginLeft: "5px" }}>17.2%</span>
                            </div> */}
                        </div>
                    </div>
                </div>
                <div className="statistical_item col-md-6 col-lg-4 col-xl-3">
                    <div
                        className="content items-center h-100"
                        style={{
                            display: 'flex',
                            justifyContent: 'space-between',
                            border: '1px solid #ccc',
                            borderRadius: '10px',
                            padding: '20px',
                        }}
                    >
                        <div className="content-left items-center" style={{ display: 'flex' }}>
                            <div
                                className="logo"
                                style={{
                                    // width: "55px",
                                    // height: "55px",
                                    marginRight: '15px',
                                }}
                            >
                                <FontAwesomeIcon
                                    icon={faUsers}
                                    style={{
                                        fontSize: '30px',
                                        padding: '10px 10px',
                                    }}
                                />
                            </div>
                            <div>
                                <span
                                    style={{
                                        display: 'block',
                                        marginBottom: '8px',
                                    }}
                                >
                                    Đang bảo lưu
                                </span>
                                <h4 className="mb-0">{evaluteData.solutionCenterLADTO.totalStudentReserve}</h4>
                            </div>
                        </div>
                        <div
                            className="content-right"
                            style={{
                                // height: "55px",
                                display: 'flex',
                                alignItems: 'center',
                            }}
                        >
                            {/* <div
                                style={{
                                    fontSize: "13px",
                                    padding: "3px 8px",
                                    backgroundColor: "#D1FAE5",
                                    borderRadius: "25px",
                                }}
                            >
                                <FontAwesomeIcon icon={faArrowUp} />
                                <span style={{ marginLeft: "5px" }}>17.2%</span>
                            </div> */}
                        </div>
                    </div>
                </div>
            </div>
            <div
                className="feature"
                style={{
                    height: '36px',
                    marginBottom: '20px',
                    display: 'flex',
                    justifyContent: 'space-between',
                }}
            >
                <div style={{ display: 'flex' }}>
                    <div
                        className="search"
                        style={{
                            border: '1px solid #ccc',
                            borderRadius: '10px',
                            height: '100%',
                            display: 'flex',
                            alignItems: 'center',
                        }}
                    >
                        <FontAwesomeIcon icon={faSearch} style={{ padding: '0px 10px' }} />
                        <input type="text" style={{ border: 'none', outline: 'none' }} placeholder="Search" />
                    </div>
                    <div className="filter">
                        <Dropdown>
                            <Dropdown.Toggle variant="success" id="dropdown-basic">
                                All
                            </Dropdown.Toggle>
                            <Dropdown.Menu>
                                <Dropdown.Item href="#/action-1">All</Dropdown.Item>
                                <Dropdown.Item href="#/action-2">Active</Dropdown.Item>
                                <Dropdown.Item href="#/action-3">Block</Dropdown.Item>
                            </Dropdown.Menu>
                        </Dropdown>
                    </div>
                </div>
                <div className="export">
                    <Button variant="outline-secondary">Export</Button>{' '}
                </div>
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
                    {evaluteData.data
                        ? mapData(evaluteData.data).map((element: SimpleStudentEvalute, index: number) => {
                              return <SimpleStudentDataEvalute key={index} {...element} />;
                          })
                        : ''}
                </tbody>
            </Table>
        </div>
    );
}

export default EvaluteStudent;
