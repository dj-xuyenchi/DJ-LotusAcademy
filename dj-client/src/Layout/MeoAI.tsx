import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { AiOutlineCloseCircle }from 'react-icons/ai';
import "./MeoAI.css"
function MeoAI() {
    const a:any =AiOutlineCloseCircle
    return (
        <>
            <div className="MeoAI">
                <button>
                    <FontAwesomeIcon icon={a}/>
                </button>
                <div className="content-chat">
                    <span>ahihi</span>
                </div>
                <img src={require("../assets/meoai2.gif")} alt="" />
                <input type="text" name="" id="" placeholder="Nói gì đi :3:3:3 " />
            </div>
        </>
    )
}


export default MeoAI;