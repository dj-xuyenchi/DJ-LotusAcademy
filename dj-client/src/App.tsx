import LotusLayout from './Layout/LotusLayout';
import EmployeeLogin from './components/Login/EmployeeLogin';
import { useState } from 'react';
function App() {
    const [isLogin, setIsLogin] = useState(true);

    const checkLogin = (data: any) => {
        setIsLogin(data);
        
    };
    return isLogin ? <LotusLayout checkLogin={checkLogin} /> : <EmployeeLogin checkLogin={checkLogin} />;
}

export default App;
