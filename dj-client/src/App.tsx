import LotusLayout from './Layout/LotusLayout';
import EmployeeLogin from './components/Login/EmployeeLogin';
import { useState } from 'react';
import { MeoAI as route} from './Layout/MeoAiRoute'
function App() {
    const [isLogin, setIsLogin] = useState(true);
    const [content, setContent] = useState("Xin chào! Tớ là DJ - Xuyến Chi trợ lý ảo của LTS Edu cậu cần tớ giúp gì nèo.")
    const [catReact, setCatReact] = useState(route.quaylen)
    const checkLogin = (data: any) => {
        setIsLogin(data);
        
    };
    return isLogin ? <LotusLayout checkLogin={checkLogin} catReact={catReact} content={content} setContent={setContent} setCatReact={setCatReact}/> : <EmployeeLogin checkLogin={checkLogin} />;
}

export default App;
