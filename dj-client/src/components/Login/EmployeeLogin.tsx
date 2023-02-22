import './EmployeeLogin.css';
import { EyeOutlined, EyeInvisibleOutlined } from '@ant-design/icons';
import { useState } from 'react';
const EmployeeLogin = () => {
    const [showPassword, setShowPassword] = useState(false);
    return (
        <div className="login">
            <div className="login__background"></div>
            <div className="login-main">
                <div className="login-main_content">
                    <div className="login-container">
                        <div className="login__title">
                            <h3 className="mb-1">Welcome back!</h3>
                            <p>Please enter your credentials to sign in!</p>
                        </div>
                        <div>
                            <form>
                                <div className="form-group mb-7">
                                    <label className="mb-2">User Name</label>
                                    <input
                                        type="email"
                                        className="form-control"
                                        id="exampleInputEmail1"
                                        aria-describedby="emailHelp"
                                        placeholder="Enter Email"
                                    />
                                </div>
                                <div className="form-group  mb-7">
                                    <label className="mb-2">Password</label>
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
                                        <p className="ml-2">Remember Me</p>
                                    </div>
                                    <a href="/">Forgot Password?</a>
                                </div>
                                <button type="submit" className="btn btn-primary w-100 h-11">
                                    Sign In
                                </button>
                                <div className="mt-3 text-center">
                                    <span>Don't have an account yet?</span>
                                    <a className="ml-2 text-decoration-none" href="/">
                                        Sign up
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
