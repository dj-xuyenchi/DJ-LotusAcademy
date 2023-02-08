import { useRoutes } from 'react-router-dom';
import Header from './component/layout/components/Header/Header';
import SideBar from './component/layout/components/Sidebar/SideBar';
import EvaluteStudent from './component/Business/StudentManager/Evalute/EvaluteStudent';
import routes from './router/router';
import './App.css';
function App() {
    const element = useRoutes(routes);
    return (
        <>
            <div className="wrapper">
                <SideBar />
                <div className="main">
                    <Header />
                    <div className="content">
                        <EvaluteStudent />
                    </div>
                </div>
            </div>
        </>
    );
}

export default App;
