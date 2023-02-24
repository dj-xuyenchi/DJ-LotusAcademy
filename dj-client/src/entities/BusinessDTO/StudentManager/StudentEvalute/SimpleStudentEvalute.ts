export interface SimpleStudentEvalute {
    id: number;
    info: {
        avatar: string,
        name: string
    };
    phoneNumber: string;
    mentor: string;
    courses: string[];
    status: string;
}

// "studentLAName": "Ngọc Bảo Châu",
// "studentLASdt": "098765523",
// "studentCourses": [],
// "employeeLAId": 5,
// "employeeLAName": "2 mét",
// "isActive": 1
export const mapData = (input: any): SimpleStudentEvalute[] => {
    if (input === null || input.length === 0) {
        return [];
    }
    return input.map((element: any) => {


        return {
            id: element.studentLAId,
            info: {
                avatar: "https://thietbigiadinh.org/wp-content/uploads/2022/04/anh-3d-meo-01.jpg",
                name: element.studentLAName
            },
            phoneNumber: element.studentLASdt,
            mentor: element.employeeLAName,
            courses: element.studentCourses ? element.studentCourses : [],
            status: element.isActive == 1 ? "Học Online" : "Học Offline"
        };
    });
};
