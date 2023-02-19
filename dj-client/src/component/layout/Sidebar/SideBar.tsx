import './Sidebar.css';
import logo from '../../../assets/logo.png';
import { Sidebar, Menu, MenuItem, SubMenu } from 'react-pro-sidebar';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faHouse, faUser, faUserGroup, faBars, faCalendarCheck } from '@fortawesome/free-solid-svg-icons';
import { Link } from 'react-router-dom';
import { useProSidebar } from 'react-pro-sidebar';
function SideBar() {
    const { collapsed } = useProSidebar();
    return (
        <Sidebar
            rootStyles={{
                width: '290px',
                minWidth: '290px',
                height: '100vh',
                color: '#4B5563',
                backgroundColor: '#F3F4F6 !important',
            }}
        >
            <Link className="sidebar_logo" to="/">
                <img src={logo} alt="img" />
                <div className="sidebar_title">
                    <p className="brand_name">Lotus Academy</p>
                </div>
            </Link>
            <div
                style={{
                    padding: '0 24px',
                    marginTop: '18px',
                    fontWeight: '500',
                    textTransform: 'uppercase',
                    fontSize: '16px',
                    display: collapsed ? 'none' : 'block',
                }}
            >
                apps
            </div>
            <Menu>
                <MenuItem icon={<FontAwesomeIcon icon={faHouse} />} className="menu_item">
                    Bảng tin
                </MenuItem>
                <SubMenu label="Học viên" icon={<FontAwesomeIcon icon={faUser} />} className="sub_menu">
                    <MenuItem className="menu_item">Danh sách học viên</MenuItem>
                </SubMenu>
                <SubMenu label="Trợ giảng" icon={<FontAwesomeIcon icon={faUserGroup} />} className="sub_menu">
                    <MenuItem className="menu_item">Điểm danh</MenuItem>
                </SubMenu>
                <SubMenu label="Sale" icon={<FontAwesomeIcon icon={faBars} />} className="sub_menu">
                    <MenuItem className="menu_item">Đăng ký học viên</MenuItem>
                    <MenuItem className="menu_item">Đăng ký khóa học</MenuItem>
                </SubMenu>
                <SubMenu label="Công việc" icon={<FontAwesomeIcon icon={faCalendarCheck} />} className="sub_menu">
                    <MenuItem className="menu_item">Nhóm việc của tôi</MenuItem>
                </SubMenu>
            </Menu>
        </Sidebar>
    );
}

export default SideBar;
