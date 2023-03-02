import React, { useState } from 'react';
import './LotusLayout.scss';
import { Layout, Menu } from 'antd';
import { Avatar } from 'antd';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import {
    faSchool,
    faUser,
    faUserGroup,
    faHouse,
    faCalendar,
    faList,
    faMessage,
} from '@fortawesome/free-solid-svg-icons';
import { Link, useLocation, useRoutes } from 'react-router-dom';
import Routes from '../route/Router';
const { Sider } = Layout;

const LotusLayout = (props:any) => {
    const [collapsed, setCollapsed] = useState(true);
    const component = useRoutes(Routes);
    const location = useLocation();
    return (
        <Layout className="bg-white ">
            <Sider trigger={null} collapsible collapsed={collapsed} className="border-r-[2px] border-[#ededed]">
                <div>
                    <div className="logo h-[60px] d-flex align-items-center justify-content-center text-white">
                        <FontAwesomeIcon icon={faSchool} className="text-[#042341]" />
                    </div>
                    <Menu
                        theme="dark"
                        mode="inline"
                        defaultSelectedKeys={[location.pathname === '/' ? '1' : '2']}
                        className="text-[#042341] bg-white flex items-center justify-center flex-col px-3"
                        items={[
                            {
                                key: '1',
                                icon: (
                                    <Link to="/">
                                        <FontAwesomeIcon icon={faHouse} />
                                    </Link>
                                ),
                            },
                            {
                                key: '2',
                                icon: (
                                    <Link to="/hocvien">
                                        <FontAwesomeIcon icon={faUser} />
                                    </Link>
                                ),
                            },
                            {
                                key: '3',
                                icon: <FontAwesomeIcon icon={faUserGroup} />,
                            },
                            {
                                key: '4',
                                icon: <FontAwesomeIcon icon={faList} />,
                            },
                            {
                                key: '5',
                                icon: <FontAwesomeIcon icon={faCalendar} />,
                            },
                        ]}
                    />
                </div>
                <div className="d-flex flex-column justify-content-between align-items-center mb-3">
                    <div className="mb-3" onClick={()=>{
                       
                    }}>
                        <FontAwesomeIcon icon={faMessage} className="text-[#042341]" />
                    </div>
                    <Avatar onClick={()=>{props.checkLogin(false)}}
                        className="h-[50px] w-[50px] bg-top bg-cover bg-[url('https://khoinguonsangtao.vn/wp-content/uploads/2022/09/hinh-anh-gai-trung-quoc.jpg')] align-middle"
                        size="large"
                    ></Avatar>
                </div>
            </Sider>
            {component}
        </Layout>
    );
};

export default LotusLayout;
