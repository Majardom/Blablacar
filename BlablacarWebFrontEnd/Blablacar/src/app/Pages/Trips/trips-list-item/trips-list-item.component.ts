import { Component, OnInit, Input } from '@angular/core';
import { ITrip } from '../../models/trip';

@Component({
  selector: 'app-trips-list-item',
  templateUrl: './trips-list-item.component.html',
  styleUrls: ['./trips-list-item.component.scss']
})
export class TripsListItemComponent implements OnInit {

  @Input()
  trip : ITrip;

  constructor() { }

  ngOnInit(): void {
  }

}
