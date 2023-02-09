import Table from 'react-bootstrap/Table';
import './EvaluteStudent.css';
import SimpleStudentDataEvalute from './SimpleEval/SimpleStudentDataEvalute';
import { SimpleStudentEvalute } from '../../../../entities/BusinessDTO/StudentManager/StudentEvalute/SimpleStudentEvalute';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faUsers, faArrowUp, faSearch } from '@fortawesome/free-solid-svg-icons';
import Dropdown from 'react-bootstrap/Dropdown';
import Button from 'react-bootstrap/Button';
import { Link } from 'react-router-dom';
function EvaluteStudent() {
    let data: SimpleStudentEvalute = {
        studentAvatar: 'https://img.meta.com.vn/Data/image/2021/09/22/anh-meo-cute-de-thuong-dang-yeu-41.jpg',
        studentName: 'abc',
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
            <div className="statistical">
                <div className="statistical_item">
                    <div className="content" style={{ display: 'flex', justifyContent: 'space-between' }}>
                        <div className="content-left" style={{ display: 'flex' }}>
                            <div className="logo" style={{ width: '55px', height: '55px', marginRight: '15px' }}>
                                <FontAwesomeIcon icon={faUsers} style={{ fontSize: '30px', padding: '10px 10px' }} />
                            </div>
                            <div>
                                <span style={{ display: 'block', marginBottom: '8px' }}>Total Customers</span>
                                <h3>2,420</h3>
                            </div>
                        </div>
                        <div
                            className="content-right"
                            style={{ height: '55px', display: 'flex', alignItems: 'center' }}
                        >
                            <div
                                style={{
                                    fontSize: '13px',
                                    padding: '3px 8px',
                                    backgroundColor: '#D1FAE5',
                                    borderRadius: '25px',
                                }}
                            >
                                <FontAwesomeIcon icon={faArrowUp} />
                                <span style={{ marginLeft: '5px' }}>17.2%</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="statistical_item">
                    <div className="content" style={{ display: 'flex', justifyContent: 'space-between' }}>
                        <div className="content-left" style={{ display: 'flex' }}>
                            <div className="logo" style={{ width: '55px', height: '55px', marginRight: '15px' }}>
                                <FontAwesomeIcon icon={faUsers} style={{ fontSize: '30px', padding: '10px 10px' }} />
                            </div>
                            <div>
                                <span style={{ display: 'block', marginBottom: '8px' }}>Online Customers</span>
                                <h3>2,420</h3>
                            </div>
                        </div>
                        <div
                            className="content-right"
                            style={{ height: '55px', display: 'flex', alignItems: 'center' }}
                        >
                            <div
                                style={{
                                    fontSize: '13px',
                                    padding: '3px 8px',
                                    backgroundColor: '#D1FAE5',
                                    borderRadius: '25px',
                                }}
                            >
                                <FontAwesomeIcon icon={faArrowUp} />
                                <span style={{ marginLeft: '5px' }}>17.2%</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="statistical_item">
                    <div className="content" style={{ display: 'flex', justifyContent: 'space-between' }}>
                        <div className="content-left" style={{ display: 'flex' }}>
                            <div className="logo" style={{ width: '55px', height: '55px', marginRight: '15px' }}>
                                <FontAwesomeIcon icon={faUsers} style={{ fontSize: '30px', padding: '10px 10px' }} />
                            </div>
                            <div>
                                <span style={{ display: 'block', marginBottom: '8px' }}>Offline Customers</span>
                                <h3>2,420</h3>
                            </div>
                        </div>
                        <div
                            className="content-right"
                            style={{ height: '55px', display: 'flex', alignItems: 'center' }}
                        >
                            <div
                                style={{
                                    fontSize: '13px',
                                    padding: '3px 8px',
                                    backgroundColor: '#D1FAE5',
                                    borderRadius: '25px',
                                }}
                            >
                                <FontAwesomeIcon icon={faArrowUp} />
                                <span style={{ marginLeft: '5px' }}>17.2%</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div
                className="feature"
                style={{ height: '36px', marginBottom: '20px', display: 'flex', justifyContent: 'space-between' }}
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
                            <Link to="/evalutestudent/1">
                                <span>Tên</span>
                            </Link>
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
