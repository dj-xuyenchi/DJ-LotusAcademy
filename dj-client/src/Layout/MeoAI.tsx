import { AiOutlineCloseCircle }from 'react-icons/ai';
import "./MeoAI.css"
import { MeoAI as route }  from "./MeoAiRoute";
function MeoAI() {
    return (
        <>
            <div className="MeoAI">
                <button>
                    <AiOutlineCloseCircle />
                </button>
                <div className="content-chat">
                    <span>ahihi</span>
                </div>
                <img src={require(`${route["troi oi xinh qua"]}`)} alt="" />
                <input type="text" name="" id="" placeholder="Nói gì đi :3:3:3 " />
            </div>
        </>
    )
}


export default MeoAI;