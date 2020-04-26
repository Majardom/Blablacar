import { IBaseModel } from './base-model';

export enum Gender{
    Male,
    Female
}

export interface IPerson extends IBaseModel
{
    name: string;
    gender: Gender;
    phoneNumber: string;
}