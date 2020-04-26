import { Component, OnInit } from '@angular/core';
import { ITrip } from '../../../../models/trip';
import { ICustomer } from '../../../../models/customer';
import { formatDate } from '@angular/common';
import { Gender } from 'src/models/person';
import { TripsService } from 'src/services/trips/trips.service';

@Component({
  selector: 'app-trips-list',
  templateUrl: './trips-list.component.html',
  styleUrls: ['./trips-list.component.scss']
})
export class TripsListComponent implements OnInit {

  trips: ITrip[] = [];

  constructor(private tripsService: TripsService) { }

  ngOnInit(): void {
    this.tripsService.getAllTrips().subscribe((data: ITrip[]) => {
        this.trips = data;
    });
  }

}
