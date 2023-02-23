import LotusLayout from './Layout/LotusLayout';
import EmployeeLogin from './components/Login/EmployeeLogin';
import { useState } from 'react';
function App() {
    const [isLogin, setLogin] = useState(false)
    const loginF = () => {
        
    }
    return (
        <>
            {isLogin ? <EmployeeLogin setLogin={loginF}/> : <LotusLayout setLogin={setLogin}/>}
        </>
    )
}

export default App;
