import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AppConfigService } from '../app-config/app-config.service';

@Injectable({
  providedIn: 'root'
})
export class TripsService {

  private tripsUrl = `${AppConfigService.settings.backend.endpoint}${AppConfigService.settings.backend.restful.trips}`;

  constructor(private http: HttpClient) { }
}
