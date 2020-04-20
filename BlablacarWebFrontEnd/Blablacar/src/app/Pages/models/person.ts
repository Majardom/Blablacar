import { IBaseModel } from './base-model';

export interface IPerson extends IBaseModel
{
    Name: string;
    Gender: "Male" | "Female";
    PhoneNumber: string;
}