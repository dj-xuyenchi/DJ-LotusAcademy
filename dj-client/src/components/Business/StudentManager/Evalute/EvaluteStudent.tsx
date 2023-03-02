import './EvaluteStudent.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faUsers, faArrowUp, faSearch } from '@fortawesome/free-solid-svg-icons';
import Dropdown from 'react-bootstrap/Dropdown';
import Button from 'react-bootstrap/Button';
import { useEffect, useState } from 'react';
import studentStatisticalApi from '../../../../api/BusinessApi/StudentManagerAPIs/StudentStatisticalApi';
import Table, { ColumnsType } from 'antd/es/table';
import Tag from 'antd/es/tag';
import { DataType } from '../../../../entities/table/Datatype';
import { Link } from 'react-router-dom';
import {
    mapData,
    SimpleStudentEvalute,
} from '../../../../entities/BusinessDTO/StudentManager/StudentEvalute/SimpleStudentEvalute';
function EvaluteStudent() {
    const [evaluteData, setEvaluteData] = useState({
        data: [
            {
                id: 1,
                info: {
                    avatar: 'https://thietbigiadinh.org/wp-content/uploads/2022/04/anh-3d-meo-01.jpg',
                    name: 'Thai Lan Huowng',
                },
                phoneNumber: '+84 968491797',
                mentor: '2 Mét',
                courses: ['Java', 'c#'],
                status: 'Học Online',
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

    const columns: ColumnsType<SimpleStudentEvalute> = [
        {
            title: 'Họ tên',
            dataIndex: 'info',
            key: 'info',
            width: '20%',
            render: (element) => (
                <Link to="/hocvien/1">
                    <img src={element.avatar} alt="" />
                    <span>{element.name}</span>
                </Link>
            ),
        },
        {
            title: 'Số điện thoại',
            dataIndex: 'phoneNumber',
            key: 'phoneNumber',
            width: '20%',
        },
        {
            title: 'Khóa học',
            dataIndex: 'courses',
            key: 'courses',
            width: '30%',
            render: (_, { courses }) => (
                <>
                    {courses.map((course) => {
                        return (
                            <Tag color={'green'} key={course}>
                                {course.toUpperCase()}
                            </Tag>
                        );
                    })}
                </>
            ),
        },
        {
            title: 'Trợ giảng',
            key: 'mentor',
            dataIndex: 'mentor',
            width: '15%',
        },
        {
            title: 'Trạng thái',
            key: 'status',
            dataIndex: 'status',
            width: '15%',
        },
    ];

    useEffect(() => {
        // const dt = setInterval(() => {
        const callApi = async () => {
            const data = await studentStatisticalApi.getListStudentByPaging(1);
            setEvaluteData(data);
        };
        callApi();
        // }, 10000)
        // return () => {
        //     clearInterval(dt);
        // }
    }, []);

    return (
        <div
            className="EvaStudent ml-[80px]"
            style={{
                padding: '24px 32px',
                width: '100%',
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
            <Table
                columns={columns}
                dataSource={mapData(evaluteData.data)}
                bordered={false}
                loading={false}
                pagination={{ position: ['bottomCenter'] }}
            />
            {/* <Table className="table" hover responsive="sm">
                <thead>
                        <th id="table-name">
                            <span>Tên</span>
                        </th>
                        <th id="table-contact">
                            <span>SDT liên hệ </span>
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
                </thead>
                <tbody>
                    {evaluteData.data
                        ? mapData(evaluteData.data).map((element: SimpleStudentEvalute, index: number) => {
                              return <SimpleStudentDataEvalute key={index} {...element} />;
                          })
                        : ''}
                </tbody>
            </Table> */}
        </div>
    );
}

export default EvaluteStudent;
