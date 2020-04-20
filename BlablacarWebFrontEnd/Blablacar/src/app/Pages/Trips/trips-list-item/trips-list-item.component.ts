import { Component, OnInit, Input } from '@angular/core';
import { ITrip } from '../../../../models/trip';
import { MatDialog } from '@angular/material/dialog';
import { OrderDialogComponent } from 'src/app/Dialogs/order-dialog/order-dialog.component';

@Component({
  selector: 'app-trips-list-item',
  templateUrl: './trips-list-item.component.html',
  styleUrls: ['./trips-list-item.component.scss']
})
export class TripsListItemComponent implements OnInit {

  @Input()
  trip : ITrip;

  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {
  }

  order() {
    this.dialog.open(OrderDialogComponent, {
      data: {trip: this.trip}
    });
  }
}
