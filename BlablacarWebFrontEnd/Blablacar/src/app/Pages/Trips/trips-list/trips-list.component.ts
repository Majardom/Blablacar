import { Component, OnInit } from '@angular/core';
import { ITrip } from '../../models/trip';
import { ICustomer } from '../../models/customer';
import { formatDate } from '@angular/common';

@Component({
  selector: 'app-trips-list',
  templateUrl: './trips-list.component.html',
  styleUrls: ['./trips-list.component.scss']
})
export class TripsListComponent implements OnInit {

  trips: ITrip[] = [];

  constructor() { }

  ngOnInit(): void {
    let driver: ICustomer = {Id: 1, Gender: "Male", Name:"Some Driver", PhoneNumber:"380blablabla"}; 
    let trip: ITrip = {Id: 1, Customer: null, DepatureTime: formatDate(new Date(), 'yyyy-MM-dd hh:mm', 'en_US'), Driver: driver, From:"SHIT", To:"ASS", Price:300};

    this.trips.push(trip);
    this.trips.push(trip);
    this.trips.push(trip);
    this.trips.push(trip);
    this.trips.push(trip);
    this.trips.push(trip);
    this.trips.push(trip);
    this.trips.push(trip);
    this.trips.push(trip);
    this.trips.push(trip);
    this.trips.push(trip);
    this.trips.push(trip);
    this.trips.push(trip);
    this.trips.push(trip);
    this.trips.push(trip);
    this.trips.push(trip);
  }

}
