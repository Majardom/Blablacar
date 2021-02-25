import { Component, OnInit } from '@angular/core';
import { IDriver } from 'src/models/driver';
import { TripsService } from 'src/services/trips/trips.service';
import { ITrip } from 'src/models/trip';
import { Gender } from 'src/models/person';

@Component({
  selector: 'app-create-trip-dialog',
  templateUrl: './create-trip-dialog.component.html',
  styleUrls: ['./create-trip-dialog.component.scss']
})
export class CreateTripDialogComponent implements OnInit {

  drivers: IDriver[] = [];
  selected: IDriver;
  trip: ITrip = {id:0,customer: null, departureTime: null, driver: null, from: null,price: 0,to:null };

  selectedDriverId: number;

  constructor(private tripsService: TripsService) { }

  ngOnInit(): void {

    this.drivers.push({id:0, gender: Gender.Male, name:'Some Driver 1', phoneNumber:'380123213123'});

    this.selected = this.drivers[0];
  }

  createTrip(): void {
    const driver = this.drivers.filter(x => x.id == this.selectedDriverId)[0];
    this.trip.driver = driver;
    this.trip.price = parseFloat(this.trip.price.toString());
    this.tripsService.addTrip(this.trip)
    //this.tripsService.addTrip(this.trip).subscribe();
  }
}
