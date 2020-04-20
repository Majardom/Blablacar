import { Component, OnInit, Input, HostListener } from '@angular/core';
import { IMenuItem } from '../models/menu-item';

import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { CreateTripDialogComponent } from 'src/app/Dialogs/create-trip-dialog/create-trip-dialog.component';

@Component({
  selector: 'app-side-menu-item',
  templateUrl: './side-menu-item.component.html',
  styleUrls: ['./side-menu-item.component.scss'],
})
export class SideMenuItemComponent implements OnInit {

  @Input()
  menuItem: IMenuItem;

  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {
  }

  provideIconPath(): string {
    return `assets/Icons/${this.menuItem.iconName}`;
  }

  @HostListener('click', ['$event'])
  onClick(e) {
    const clickEvent = this.menuItem.onClickEvent;

    if (!clickEvent)
      return;

    if (clickEvent == "openCreateTripDialog")
      this.openCreateTripDialog();
  }

  private openCreateTripDialog() {
      this.dialog.open(CreateTripDialogComponent);
  }


}
