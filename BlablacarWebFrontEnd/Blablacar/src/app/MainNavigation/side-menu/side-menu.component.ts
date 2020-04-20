import { Component, OnInit, HostListener } from '@angular/core';
import { IMenuItem } from '../models/menu-item';

@Component({
  selector: 'app-side-menu',
  templateUrl: './side-menu.component.html',
  styleUrls: ['./side-menu.component.scss']
})
export class SideMenuComponent implements OnInit {

  menuItems: IMenuItem[] = [];
  isClosed: boolean = true;

  constructor() {
  }

  ngOnInit(): void {
    //Almost load from config)
    this.menuItems.push({ caption: "Home", iconName: "home.svg", routeLink: "/home" });
    this.menuItems.push({ caption: "Create New Trip", iconName: "plus.svg", onClickEvent: "openCreateTripDialog"});
    this.menuItems.push({ caption: "Aviable Trips", iconName: "car.svg", routeLink: "/rides" });
    this.menuItems.push({ caption: "Booked Trips", iconName: "booked.svg", routeLink: "/home" });
    this.menuItems.push({ caption: "Log Out", iconName: "logout.svg", customClasses: ["logout"], routeLink: "/home" });
  }

  arrowClick() {
    this.isClosed = !this.isClosed;
  }

  provideClassStringForMenuItem(menuItem: IMenuItem): string {
    let resultClasses = '';

    if (!menuItem || !menuItem.customClasses)
      return resultClasses;

    for (let styleClass of menuItem.customClasses)
      resultClasses += styleClass;

    return resultClasses;
  }

  openCreateTripDialog(): void {
    console.log("shit");
  }
} 
