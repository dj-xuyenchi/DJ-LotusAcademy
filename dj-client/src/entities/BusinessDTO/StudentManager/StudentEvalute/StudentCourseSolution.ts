export interface StudentCourseSolution {
    sortNumber: string;
    courseName: string;
    signInDateTime: string;
    supportTime: string;
    doneExpectedDateTime: string;
    lessonNow: string;
    evalute: string;
}


export const mapData = (input: any): StudentCourseSolution[] => {

    if (input === null||input === undefined) {
        return [];
    }
    return input?.map((element: any) => {
        return {
            sortNumber: element.sortNumber,
            courseName: element.courseName,
            signInDateTime: element.signInDateTime,
            supportTime: element.supportTime + ' tháng',
            doneExpectedDateTime: element.doneExpectedDateTime,
            lessonNow: element.lessonNow,
            evalute: element.evalute,
        };
    });
};
