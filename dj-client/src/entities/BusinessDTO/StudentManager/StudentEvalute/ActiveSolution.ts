import { activeType } from './../../../../enums/ActiveType';
import { slotEnum } from "../../../../enums/SlotEnum";

export interface ActiveSolution {
    day:number;
    slot:slotEnum;
    activeType:activeType;
    reason:string;
    confirmDateTime:string;
    employeeConfirm:string;
    late:number
}


export const mapDataActiveSolution = (input: any): ActiveSolution[] => {
    if (input === null || input.length === 0) {
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

export default ActiveSolution