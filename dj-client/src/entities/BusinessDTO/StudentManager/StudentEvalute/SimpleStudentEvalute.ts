export interface SimpleStudentEvalute {
    studentAvatar: string;
    studentName: string;
    studentSdt: string;
    studentCourse: string;
    studentTurtor: string;
    studentActive: boolean;
}

// "studentLAName": "Ngọc Bảo Châu",
// "studentLASdt": "098765523",
// "studentCourses": [],
// "employeeLAId": 5,
// "employeeLAName": "2 mét",
// "isActive": 1
export const mapData = (input: any): SimpleStudentEvalute[] => {
    return input.map((element: any) => {
        return {
            studentAvatar:
                "https://img.meta.com.vn/Data/image/2021/09/22/anh-meo-cute-de-thuong-dang-yeu-41.jpg",
            studentName: element.studentLAName,
            studentSdt: element.studentLASdt,
            studentCourse: "13",
            studentTurtor: element.employeeLAName,
            studentActive: true,
        };
    });
};
