import { Input, Upload } from 'antd';
import { SettingOutlined, UserOutlined, LoadingOutlined, PlusOutlined } from '@ant-design/icons';
import { useState } from 'react';
import { Button, Cascader, DatePicker, Form, InputNumber, Radio, Select, Switch, TreeSelect } from 'antd';
function AccountInformation() {
    const [loading, setLoading] = useState(false);
    const [imageUrl, setImageUrl] = useState('');
    const uploadButton = (
        <div>
            {loading ? <LoadingOutlined /> : <PlusOutlined />}
            <div style={{ marginTop: 8 }}>Tải ảnh lên</div>
        </div>
    );
    return (
        <>
            {/* <div className="mb-8">
                <h3 className="mb-2">Thông tin tài khoản</h3>
            </div> */}
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
                    {imageUrl ? <img src={imageUrl} alt="avatar" style={{ width: '100%' }} /> : uploadButton}
                </Upload>
                <div className="row mb-2">
                    <div className="form-group col-md-6">
                        <label className="mb-2">Họ & tên đệm</label>
                        <Input size="large" />
                    </div>
                    <div className="form-group col-md-6">
                        <label className="mb-2">Tên</label>
                        <Input size="large" />
                    </div>
                </div>
                <div className="form-group mb-2">
                    <label className="mb-2">Email</label>
                    <Input size="large" />
                </div>
                <div className="row mb-2">
                    <div className="form-group col-md-6">
                        <label className="mb-2">Giới tính</label>
                        <Select style={{ width: '100%' }} size="large">
                            <Select.Option value="demo">Nam</Select.Option>
                            <Select.Option value="demo">Nữ</Select.Option>
                            <Select.Option value="demo">LGBT</Select.Option>
                        </Select>
                    </div>
                    <div className="form-group col-md-6">
                        <label className="mb-2">Ngày sinh</label>
                        <DatePicker style={{ width: '100%' }} size="large" />
                    </div>
                </div>
                <div className="row mb-2">
                    <div className="form-group col-md-6">
                        <label className="mb-2">Số điện thoại</label>
                        <Input size="large" />
                    </div>
                    <div className="form-group col-md-6">
                        <label className="mb-2">Tình trạng</label>
                        <Select style={{ width: '100%' }} size="large">
                            <Select.Option value="demo">Độc thân</Select.Option>
                            <Select.Option value="demo">Đã có vợ / chồng</Select.Option>
                        </Select>
                    </div>
                </div>
                <div className="row mb-2">
                    <div className="form-group col-md-6">
                        <label className="mb-2">Trường CĐ / ĐH</label>
                        <Select style={{ width: '100%' }} size="large">
                            <Select.Option value="demo">Demo</Select.Option>
                        </Select>
                    </div>
                    <div className="form-group col-md-4">
                        <label className="mb-2">Khoa / Chuyên ngành</label>
                        <Select style={{ width: '100%' }} size="large">
                            <Select.Option value="demo">Demo</Select.Option>
                        </Select>
                    </div>
                    <div className="form-group col-md-2">
                        <label className="mb-2">Năm thứ</label>
                        <Select style={{ width: '100%' }} size="large">
                            <Select.Option value="1">1</Select.Option>
                            <Select.Option value="2">2</Select.Option>
                            <Select.Option value="3">3</Select.Option>
                            <Select.Option value="4">4</Select.Option>
                            <Select.Option value="5">5</Select.Option>
                        </Select>
                    </div>
                </div>
                <div className="row mb-2">
                    <div className="form-group col-md-4">
                        <label className="mb-2">Tỉnh / Thành phố</label>
                        <Select style={{ width: '100%' }} size="large">
                            <Select.Option value="demo">Demo</Select.Option>
                        </Select>
                    </div>
                    <div className="form-group col-md-4">
                        <label className="mb-2">Quận / Huyện</label>
                        <Select style={{ width: '100%' }} size="large">
                            <Select.Option value="demo">Demo</Select.Option>
                        </Select>
                    </div>
                    <div className="form-group col-md-4">
                        <label className="mb-2">Xã / Phường</label>
                        <Select style={{ width: '100%' }} size="large">
                            <Select.Option value="demo">Demo</Select.Option>
                        </Select>
                    </div>
                </div>
                <div className="form-group mb-2">
                    <label className="mb-2">Địa chỉ</label>
                    <Input size="large" />
                </div>
            </form>
            <div className="d-flex justify-content-center">
                <button type="submit" className="btn btn-primary mt-2" style={{ color: 'black' }}>
                    Lưu lại
                </button>
            </div>
        </>
    );
}

export default AccountInformation;
