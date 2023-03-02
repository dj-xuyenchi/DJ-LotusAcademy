export interface ActiveSolution {
    sortNumber: string;
    createDateTime: string;
    slot: string;
    activeStatus: string;
    reason: string;
    confirmDateTime: string;
    employeeConfirm: string;
}

export const mapDataActiveSolution = (input: any): ActiveSolution[] => {
    if (input === null || input === undefined) {
        return [];
    }
    return input.map((element: any) => {
        return {
            sortNumber: element.sortNumber,
            createDateTime: element.createDateTime,
            slot: element.slot,
            activeStatus: element.activeStatus,
            reason: element.reason,
            confirmDateTime: element.confirmDateTime,
            employeeConfirm: element.employeeConfirm,
        };
    });
};

export default ActiveSolution;
