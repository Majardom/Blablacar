import { Component, OnInit } from '@angular/core';
import { IDriver } from 'src/models/driver';

@Component({
  selector: 'app-create-trip-dialog',
  templateUrl: './create-trip-dialog.component.html',
  styleUrls: ['./create-trip-dialog.component.scss']
})
export class CreateTripDialogComponent implements OnInit {

  drivers: IDriver[] = [];
  selected: IDriver;


  constructor() { }

  ngOnInit(): void {

    this.drivers.push({Id:0, Gender: 'Male', Name:'SomeShit1', PhoneNumber:'380'});
    this.drivers.push({Id:0, Gender: 'Male', Name:'SomeShit2', PhoneNumber:'380'});
    this.drivers.push({Id:0, Gender: 'Male', Name:'SomeShit3', PhoneNumber:'380'});

    this.selected = this.drivers[0];
  }

}
