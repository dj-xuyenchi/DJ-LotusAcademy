export interface ActiveSolution {
    sortNumber:string;
    createDateTime:string;
    slot:string;
    status:string;
    reason:string;
    confirmDateTime:string;
    confirmEmployee:string;
}


export const mapData = (input: any): ActiveSolution[] => {
    if (input === null || input.length === 0) {
        return [];
    }
    return input.map((element: any) => {
        return {
            sortNumber: element.sortNumber,
            courseName: element.courseName,
            signInDateTime: element.signInDateTime,
            supportTime: element.supportTime + " tháng",
            doneExpectedDateTime: element.doneExpectedDateTime,
            lessonNow: element.lessonNow,
            evalute: element.evalute
        };
    });
};
