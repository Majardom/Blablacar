import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AppConfigService } from '../app-config/app-config.service';
import { Observable } from 'rxjs';
import { ITrip } from 'src/models/trip';
import { Gender } from 'src/models/person';

@Injectable({
  providedIn: 'root'
})
export class TripsService {
  static trips: ITrip[] = [
    {
      id: 0,
      customer: {id: 0,  gender: Gender.Female, name: "Some Customer", phoneNumber: "380934234234"},
      departureTime: new Date().toString(),
      driver: {id: 0,  gender: Gender.Female, name: "Some Driver", phoneNumber: "380934234234"},
      from: "Kyiv",
      to: "Lviv",
      price: 300
   }
  ];

  private tripsUrl = `${AppConfigService.settings.backend.endpoint}${AppConfigService.settings.backend.restful.trips}`;

  constructor(private http: HttpClient) { }
  
  getAllTrips(): ITrip[] {
    return TripsService.trips;
  }

  addTrip(trip: ITrip) {
    TripsService.trips.push(trip);
  }

  //getAllTrips() : Observable<ITrip[]> {
  // return this.http.get<ITrip[]>(this.tripsUrl);
  //}

  //addTrip(trip: ITrip) : Observable<ITrip>{
  //    return this.http.post<ITrip>(this.tripsUrl, trip);
  //}
}
