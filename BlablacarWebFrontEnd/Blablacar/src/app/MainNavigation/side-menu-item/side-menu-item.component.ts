import { Component, OnInit, Input } from '@angular/core';
import { IMenuItem } from '../models/menu-item';

@Component({
  selector: 'app-side-menu-item',
  templateUrl: './side-menu-item.component.html',
  styleUrls: ['./side-menu-item.component.scss'],
})
export class SideMenuItemComponent implements OnInit {

  @Input()
  menuItem: IMenuItem;

  constructor() { }

  ngOnInit(): void {
  }

  provideIconPath(): string {
    return `assets/Icons/${this.menuItem.iconName}`;
  }
}
