import { activeType } from "../../../../enums/ActiveType";
import { slotEnum } from "../../../../enums/SlotEnum";

export interface ActiveNote {
   day:number;
   activeType:activeType;
   lateTotal:string;
   slot:slotEnum;
   note:string;
   confirmDate:string;
   confirmEmployee:string;
}
