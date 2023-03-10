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
import MeoAI from './MeoAI';
const { Sider } = Layout;

const LotusLayout = ({setContent, setCatReact,content,catReact ,checkLogin}:any) => {
    const [collapsed, setCollapsed] = useState(true);
    const component = useRoutes(Routes);
    const location = useLocation();
    return (
        <Layout className="bg-white ">
            <Sider style={{
                position:"fixed",
                height:'100vh',
                zIndex: 1,
                width:"5%"
            }} trigger={null} collapsible collapsed={collapsed} className="border-r-[2px] border-[#ededed]">
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
                    <Avatar onClick={()=>{checkLogin(false)}}
                        className="h-[50px] w-[50px] bg-top bg-cover bg-[url('https://khoinguonsangtao.vn/wp-content/uploads/2022/09/hinh-anh-gai-trung-quoc.jpg')] align-middle"
                        size="large"
                    ></Avatar>
                </div>
            </Sider>
            <div style={{
                width:"95%",
                marginLeft:"5%"
            }}>
            {component}
            </div>
            {/* <MeoAI catReact={catReact} content={content} setContent={setContent} setCatReact={setCatReact}/> */}
        </Layout>
    );
};

export default LotusLayout;
