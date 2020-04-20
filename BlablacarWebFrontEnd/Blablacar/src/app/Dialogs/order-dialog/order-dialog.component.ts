import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ITrip } from 'src/models/trip';

@Component({
  selector: 'app-order-dialog',
  templateUrl: './order-dialog.component.html',
  styleUrls: ['./order-dialog.component.scss']
})
export class OrderDialogComponent implements OnInit {

  trip: ITrip;
  genders = [{Id:0, Name:'Male'}, {Id: 1, Name:'Female'}]

  constructor(@Inject(MAT_DIALOG_DATA) data) { 
    this.trip = data.trip;
  }

  ngOnInit(): void {
  }
}
