import { useEffect, useRef, useState } from 'react';
import { AiOutlineCloseCircle } from 'react-icons/ai';
import { FaCat } from 'react-icons/fa';
import "./MeoAI.css"
import { MeoAI as route} from './MeoAiRoute'
function MeoAI({setContent,setCatReact,content,catReact}:any) {
    const [isActive, setActive] = useState(true)
    return (
        <>
            {isActive ? <Content content={content} catReact={catReact} isActive={isActive} setActive={setActive} /> : <ShowContent isActive={isActive} setActive={setActive} setContent={setContent}setCatReact={setCatReact}/>}
        </>
    )
}
function Content({ setActive, isActive ,content,catReact}: any) {
    
    const showContentSpan = useRef<any>();
    let i = 0
    let dataChat = ""
    const interval = setInterval(() => {
        if (i === content.length) {
           
            clearInterval(interval)
        }
        if (content[i] != undefined) {
            dataChat = dataChat + content[i]
            showContentSpan.current.innerHTML = dataChat
            i++
        }
    }, 50)
    return (
        <>
            <div className="MeoAI">
                <AiOutlineCloseCircle style={{
                    height: "30px",
                    width: "30px",
                    position: "absolute",
                    right: "-2%",
                    color: "#5f5e5e"
                }} onClick={() => {
                    setActive(!isActive)
                }} />
                <div className="content-chat">
                    <span ref={showContentSpan}></span>
                </div>
                <img src={require(`${catReact}`)} alt="" />
                <input type="text" name="" id="" placeholder="Nói gì đi :3:3:3 " />
            </div>
        </>
    )
}
function ShowContent({ setActive, isActive,setContent,setCatReact }: any) {
    return (
        <>
            <div className="MeoAI">
                <div className="show">
                    <FaCat style={{
                        height: "40px",
                        width: "40px"
                    }} onClick={() => {
                        setContent("Cần gì cứ nháy nha. :3")
                        setCatReact(route.maiyeu)
                        setActive(!isActive)
                    }} />
                </div>
            </div>
        </>
    )
}

export default MeoAI;