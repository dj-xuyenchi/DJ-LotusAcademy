import './EditStudentProfile.css';
import { SettingOutlined, UserOutlined } from '@ant-design/icons';
import AccountInformation from './AccountInformation';
function EditStudentProfile() {
    return (
        <div className="infor-edit">
            <div className="wrapper">
                <div className="row">
                    <div className="col-md-15">
                        <nav>
                            <ul>
                                <li className="nav_item mb-2 d-flex">
                                    <SettingOutlined style={{ fontSize: '20px' }} />
                                    <span className="ml-3">Thông tin tài khoản</span>
                                </li>
                                <li className="nav_item mb-2 d-flex">
                                    <UserOutlined style={{ fontSize: '20px' }} />
                                    <span className="ml-3">Thông tin cá nhân</span>
                                </li>
                            </ul>
                        </nav>
                    </div>
                    <div className="col-md-45">
                        <div>
                            <AccountInformation />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
}

export default EditStudentProfile;
