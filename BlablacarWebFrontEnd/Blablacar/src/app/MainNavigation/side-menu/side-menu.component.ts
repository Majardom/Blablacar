import { Component, OnInit } from '@angular/core';
import { IMenuItem } from '../models/menu-item';

@Component({
  selector: 'app-side-menu',
  templateUrl: './side-menu.component.html',
  styleUrls: ['./side-menu.component.scss']
})
export class SideMenuComponent implements OnInit {

  menuItems: IMenuItem[] = [];
  isOpened: boolean = true;

  constructor() {
  }

  ngOnInit(): void {
    //Load from config (maybe)
    this.menuItems.push({ caption: "Home", iconName: "home.svg", customClasses: [] });
    this.menuItems.push({ caption: "Create New Ride", iconName: "plus.svg", customClasses: [] });
    this.menuItems.push({ caption: "Aviable Rides", iconName: "car.svg", customClasses: [] });
    this.menuItems.push({ caption: "Booked Rides", iconName: "booked.svg", customClasses: [] });
    this.menuItems.push({ caption: "Log Out", iconName: "logout.svg", customClasses: ["logout"] });
  }

  arrowClick() {
    this.isOpened = !this.isOpened;
  }

  provideClassStringForMenuItem(menuItem: IMenuItem): string {
    let resultClasses = '';

    for (let styleClass of menuItem.customClasses)
      resultClasses += styleClass;

    return resultClasses;
  }
} 
