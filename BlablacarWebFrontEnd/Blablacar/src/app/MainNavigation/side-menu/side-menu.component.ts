import { Component, OnInit, HostListener } from '@angular/core';
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
    this.menuItems.push({ caption: "Home", iconName: "home.svg", customClasses: [], routeLink:"/home" });
    this.menuItems.push({ caption: "Create New Ride", iconName: "plus.svg", customClasses: [], routeLink:"/home" });
    this.menuItems.push({ caption: "Aviable Rides", iconName: "car.svg", customClasses: [], routeLink:"/rides" });
    this.menuItems.push({ caption: "Booked Rides", iconName: "booked.svg", customClasses: [], routeLink:"/home" });
    this.menuItems.push({ caption: "Log Out", iconName: "logout.svg", customClasses: ["logout"], routeLink:"/home" });
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
