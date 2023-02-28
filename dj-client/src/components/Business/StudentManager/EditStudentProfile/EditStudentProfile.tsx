import './EditStudentProfile.css';
import { SettingOutlined, UserOutlined } from '@ant-design/icons';
import {
    Button,
    Cascader,
    DatePicker,
    Form,
    Input,
    InputNumber,
    Radio,
    Select,
    Switch,
    TreeSelect,
    Row,
    Col,
} from 'antd';
function EditStudentProfile() {
    return (
        <div className="wrapper">
            <div className="container">
                <h4 className="title">Cập nhật thông tin cá nhân</h4>
                <form className="editinfo-main pb-4">
                    <div>
                        <div className="form-title">
                            <SettingOutlined style={{ fontSize: '14px' }} />
                            <span style={{ marginLeft: '10px' }}>Thông tin tài khoản</span>
                        </div>
                        <div className="form-container">
                            <div className="row mb-3">
                                <div className="form-group col-md-6">
                                    <label>Tên đăng nhập</label>
                                    <Input />
                                </div>
                                <div className="form-group col-md-6">
                                    <label>Họ tên</label>
                                    <Input />
                                </div>
                            </div>
                            <div className="row">
                                <div className="form-group col-md-6">
                                    <label>Email</label>
                                    <Input />
                                </div>
                                <div className="form-group col-md-6">
                                    <label>Số điện thoại</label>
                                    <Input />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div>
                        <div className="form-title">
                            <UserOutlined style={{ fontSize: '14px' }} />
                            <span style={{ marginLeft: '10px' }}>Thông tin cá nhân</span>
                        </div>
                        <div className="form-container">
                            <div className="row mb-3">
                                <div className="form-group col-md-6">
                                    <label>Ngày sinh</label>
                                    <DatePicker style={{ width: '100%' }} />
                                </div>
                                <div className="form-group col-md-6">
                                    <label>Tỉnh thành</label>
                                    <Select style={{ width: '100%' }}>
                                        <Select.Option value="demo">Demo</Select.Option>
                                    </Select>
                                </div>
                            </div>
                            <div className="row mb-3">
                                <div className="form-group col-md-6">
                                    <label>Trường CĐ / ĐH</label>
                                    <Select style={{ width: '100%' }}>
                                        <Select.Option value="demo">Demo</Select.Option>
                                    </Select>
                                </div>
                                <div className="form-group col-md-6">
                                    <label>Quận huyện</label>
                                    <Select style={{ width: '100%' }}>
                                        <Select.Option value="demo">Demo</Select.Option>
                                    </Select>
                                </div>
                            </div>
                            <div className="row mb-3">
                                <div className="form-group col-md-6">
                                    <label>Khoa (Ngành)</label>
                                    <Input />
                                </div>
                                <div className="form-group col-md-6">
                                    <label>Xã phường</label>
                                    <Select style={{ width: '100%' }}>
                                        <Select.Option value="demo">Demo</Select.Option>
                                    </Select>
                                </div>
                            </div>
                            <div className="row mb-3">
                                <div className="form-group col-md-6">
                                    <label>Năm thứ</label>
                                    <Select style={{ width: '100%' }}>
                                        <Select.Option value="1">1</Select.Option>
                                        <Select.Option value="2">2</Select.Option>
                                        <Select.Option value="3">3</Select.Option>
                                        <Select.Option value="4">4</Select.Option>
                                        <Select.Option value="5">5</Select.Option>
                                    </Select>
                                </div>
                                <div className="form-group col-md-6">
                                    <label>Số nhà</label>
                                    <Input />
                                </div>
                            </div>
                        </div>
                    </div>
                </form>
                <div className="d-flex justify-content-center">
                    <button type="submit" className="btn btn-primary mt-4">
                        Lưu thay đổi
                    </button>
                </div>
            </div>
        </div>
    );
}

export default EditStudentProfile;
