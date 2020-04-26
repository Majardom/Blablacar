import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AppConfigService } from '../app-config/app-config.service';
import { Observable } from 'rxjs';
import { ITrip } from 'src/models/trip';

@Injectable({
  providedIn: 'root'
})
export class TripsService {

  private tripsUrl = `${AppConfigService.settings.backend.endpoint}${AppConfigService.settings.backend.restful.trips}`;

  constructor(private http: HttpClient) { }

  getAllTrips() : Observable<ITrip[]> {
    return this.http.get<ITrip[]>(this.tripsUrl);
  }

  addTrip(trip: ITrip) : Observable<ITrip>{
      return this.http.post<ITrip>(this.tripsUrl, trip);
  }
}
