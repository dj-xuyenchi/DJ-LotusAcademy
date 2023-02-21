import { SimpleStudentEvalute } from "../../../../../entities/BusinessDTO/StudentManager/StudentEvalute/SimpleStudentEvalute";
import { Link } from "react-router-dom";
function SimpleStudentDataEvalute(studentData: SimpleStudentEvalute) {
    return (
        <>
            <tr className="table-data-row">
                <th id="table-name">
                    <div className="w-100">
                        <Link
                            to="/hocvien/1"
                            className="no-underline font-semibold text-black text-[16px]"
                        >
                            <div className="flex items-center">
                                <img
                                    src={studentData.studentAvatar}
                                    alt=""
                                ></img>
                                <span>{studentData.studentName}</span>
                            </div>
                        </Link>
                    </div>
                </th>
                <th id="table-contact">
                    <span>{studentData.studentSdt}</span>
                </th>
                <th id="table-course">
                    <span>{studentData.studentCourse}</span>
                </th>
                <th id="table-turtol">
                    <span>{studentData.studentTurtor}</span>
                </th>
                <th id="table-active">
                    <span>
                        {studentData.studentActive ? "Active" : "Offline"}
                    </span>
                </th>
            </tr>
        </>
    );
}

export default SimpleStudentDataEvalute;
