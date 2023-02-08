import './Header.scss';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';

import { faBarsStaggered, faBell, faGear } from '@fortawesome/free-solid-svg-icons';
import { useProSidebar } from 'react-pro-sidebar';
import { useEffect, useState } from 'react';
import studentManagerApi from '../../../../api/BusinessApi/StudentManagerApi';
function Header() {
    const { collapseSidebar } = useProSidebar();
    const [data, setData] = useState(0);
    useEffect(() => {
        const getData = async () => {
            const data = await studentManagerApi.login1();
            setData(data);
        };
        getData();
    }, []);
    return (
        <div className="header">
            <div className="header_left">
                <button className="header_icon" onClick={() => collapseSidebar()}>
                    <FontAwesomeIcon icon={faBarsStaggered} />
                </button>
            </div>
            <div className="header_right">
                <button className="header_icon">
                    <FontAwesomeIcon icon={faBell} />
                </button>
                <button className="header_icon">
                    <FontAwesomeIcon icon={faGear} />
                </button>
                <div className="user_card">
                    <div className="avatar">
                        <img src="https://elstar.themenate.net/img/avatars/thumb-1.jpg" alt="" />
                    </div>
                    <div>
                        <div className="role">Admin</div>
                        <div className="user_name">Nguyễn Quang Anh</div>
                    </div>
                </div>
            </div>
        </div>
    );
}

export default Header;
