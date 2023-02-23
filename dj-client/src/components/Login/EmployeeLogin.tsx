import './EmployeeLogin.css';
import { EyeOutlined, EyeInvisibleOutlined } from '@ant-design/icons';
import { useState } from 'react';
const EmployeeLogin = (props:any) => {
    const [showPassword, setShowPassword] = useState(false);
    return (
        <div className="login">
            <div className="login__background"></div>
            <div className="login-main">
                <div className="login-main_content">
                    <div className="login-container">
                        <div className="login__title">
                            <h3 style={{color:"#0d6efd"}} className="mb-1">LTS Edu!</h3>
                            <p>Nhập tên đăng nhập và mật khẩu!</p>
                        </div>
                        <div>
                            <form>
                                <div className="form-group mb-7">
                                    <label className="mb-2">Tên đăng nhập</label>
                                    <input
                                        type="text"
                                        className="form-control"
                                        id="userName"
                                        aria-describedby=""
                                        placeholder="Tên đăng nhập"
                                    />
                                </div>
                                <div className="form-group  mb-7">
                                    <label className="mb-2">Mật khẩu</label>
                                    <div className="position-relative">
                                        <input
                                            type={showPassword ? 'text' : 'password'}
                                            className="form-control pr-5"
                                            id="exampleInputPassword1"
                                            placeholder="Password"
                                        />
                                        <div
                                            className="position-absolute top-0 right-0 w-9 h-9 btn-showpass"
                                            role="button"
                                            onClick={() => setShowPassword((prev) => !prev)}
                                        >
                                            {showPassword ? <EyeOutlined /> : <EyeInvisibleOutlined />}
                                        </div>
                                    </div>
                                </div>
                                <div className="d-flex justify-content-between">
                                    <div className="d-flex">
                                        <input type="checkbox" role="button" className="w-4 h-4 mt-1" />
                                        <p className="ml-2">Lưu tài khoản</p>
                                    </div>
                                    <a href="/">Quên mật khẩu?</a>
                                </div>
                                <button type="submit" className="btn btn-primary w-100 h-11" onClick={()=>{props.checkLogin(true)}}>
                                    Sign In
                                </button>
                                <div className="mt-3 text-center">
                                    <span>Bạn không có tài khoản?</span>
                                    <a className="ml-2 text-decoration-none" href="/">
                                       Đăng ký
                                    </a>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
};
export default EmployeeLogin;
