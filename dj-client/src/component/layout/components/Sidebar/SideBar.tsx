import './Sidebar.scss';
import logo from '../../../../assets/logo.png';
import { Sidebar, Menu, MenuItem, SubMenu } from 'react-pro-sidebar';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faHouse, faUser, faUserGroup, faBars, faCalendarCheck } from '@fortawesome/free-solid-svg-icons';

function SideBar() {
    return (
        <Sidebar rootStyles={{ width: '290px', height: '100vh', color: '#4B5563' }}>
            <a className="sidebar_logo" href="/">
                <img src={logo} alt="" />
                <div className="sidebar_title">
                    <p className="brand_name">Lotus Academy</p>
                </div>
            </a>
            <Menu>
                <MenuItem icon={<FontAwesomeIcon icon={faHouse} />} className="menu_item">
                    Bảng tin
                </MenuItem>
                <SubMenu label="Trợ giảng" icon={<FontAwesomeIcon icon={faUser} />} className="sub_menu">
                    <MenuItem className="menu_item">Điểm danh</MenuItem>
               //     <MenuItem className="menu_item">Danh sách học viên</MenuItem>
                </SubMenu>
                <SubMenu label="Sale" icon={<FontAwesomeIcon icon={faUserGroup} />} className="sub_menu">
                    <MenuItem className="menu_item">Học viên của tôi</MenuItem>
                    <MenuItem className="menu_item">Giám sát học tập</MenuItem>
                </SubMenu>
                <SubMenu label="Admin" icon={<FontAwesomeIcon icon={faBars} />} className="sub_menu">
                    <MenuItem className="menu_item">Thư viện đề thi</MenuItem>
                </SubMenu>
                <SubMenu label="Công việc" icon={<FontAwesomeIcon icon={faCalendarCheck} />} className="sub_menu">
                    <MenuItem className="menu_item">Nhóm việc của tôi</MenuItem>
                </SubMenu>
            </Menu>
        </Sidebar>
    );
}

export default SideBar;
