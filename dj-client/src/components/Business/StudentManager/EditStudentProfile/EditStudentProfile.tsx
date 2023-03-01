import './EditStudentProfile.css';
import { SettingOutlined, UserOutlined, LoadingOutlined, PlusOutlined } from '@ant-design/icons';
import { Input, Upload } from 'antd';
import { useState } from 'react';
function EditStudentProfile() {
    const [loading, setLoading] = useState(false);
    const [imageUrl, setImageUrl] = useState('');
    const uploadButton = (
        <div>
            {loading ? <LoadingOutlined /> : <PlusOutlined />}
            <div style={{ marginTop: 8 }}>Tải ảnh lên</div>
        </div>
    );

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
                        <div className="mb-8">
                            <h3 className="mb-2">Thông tin tài khoản</h3>
                        </div>
                        <form>
                            <Upload
                                name="avatar"
                                listType="picture-circle"
                                className="avatar-uploader mb-2"
                                showUploadList={false}
                                action="https://www.mocky.io/v2/5cc8019d300000980a055e76"
                                // beforeUpload={beforeUpload}
                                // onChange={handleChange}
                            >
                                {imageUrl ? (
                                    <img src={imageUrl} alt="avatar" style={{ width: '100%' }} />
                                ) : (
                                    uploadButton
                                )}
                            </Upload>
                            <div className="form-group col-md-5 mb-3">
                                <label className="mb-2">Tên đăng nhập</label>
                                <Input size="large" />
                            </div>
                            <div className="form-group col-md-5 mb-3">
                                <label className="mb-2">Họ tên</label>
                                <Input size="large" />
                            </div>
                            <div className="form-group col-md-5 mb-3">
                                <label className="mb-2">Email</label>
                                <Input size="large" />
                            </div>
                            <div className="form-group col-md-5 mb-3">
                                <label className="mb-2">Số điện thoại</label>
                                <Input size="large" />
                            </div>
                            <button type="submit" className="btn btn-secondary">
                                Sign in
                            </button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    );
}

export default EditStudentProfile;
