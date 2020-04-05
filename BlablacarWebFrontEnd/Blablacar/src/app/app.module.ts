import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { SideMenuComponent } from './MainNavigation/side-menu/side-menu.component';
import { SideMenuItemComponent } from './MainNavigation/side-menu-item/side-menu-item.component';
import { HomePageComponent } from './Pages/Home/home-page/home-page.component';
import { RideListComponent } from './Pages/Rides/ride-list/ride-list.component';
import { RideListItemComponent } from './Pages/Rides/ride-list-item/ride-list-item.component';
import { ClickOutsideModule } from 'ng-click-outside';

const appRoutes: Routes = [
  { path: 'rides', component: RideListComponent },
  { path: 'home', component: HomePageComponent },
  { path: '',   redirectTo: '/home', pathMatch: 'full' }
];

@NgModule({
  declarations: [
    AppComponent,
    SideMenuComponent,
    SideMenuItemComponent,
    HomePageComponent,
    RideListComponent,
    RideListItemComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    ClickOutsideModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
