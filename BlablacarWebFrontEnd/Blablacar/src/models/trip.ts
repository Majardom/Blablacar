import { IDriver } from './driver';
import { ICustomer } from './customer';
import { IBaseModel } from './base-model';

export interface ITrip extends IBaseModel
{
    from: string;
    to: string;
    departureTime: string;
    driver: IDriver;
    customer: ICustomer;
    price: number
}