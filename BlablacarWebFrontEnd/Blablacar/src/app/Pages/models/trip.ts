import { IDriver } from './driver';
import { ICustomer } from './customer';
import { IBaseModel } from './base-model';

export interface ITrip extends IBaseModel
{
    From: string;
    To: string;
    DepatureTime: string;
    Driver: IDriver;
    Customer: ICustomer;
    Price: number
}