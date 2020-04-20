import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { SideMenuComponent } from './MainNavigation/side-menu/side-menu.component';
import { SideMenuItemComponent } from './MainNavigation/side-menu-item/side-menu-item.component';
import { HomePageComponent } from './Pages/Home/home-page/home-page.component';
import { ClickOutsideModule } from 'ng-click-outside';
import { TripsListComponent } from './Pages/Trips/trips-list/trips-list.component';
import { TripsListItemComponent } from './Pages/Trips/trips-list-item/trips-list-item.component';

import {MaterialModule} from './Modules/material-module';

import { CreateTripDialogComponent } from './Dialogs/create-trip-dialog/create-trip-dialog.component';
import { InputDialogFieldComponent } from './Controls/input-dialog-field/input-dialog-field.component';
import { DatePickerComponent } from './Controls/date-picker/date-picker.component';

const appRoutes: Routes = [
  { path: 'rides', component: TripsListComponent },
  { path: 'home', component: HomePageComponent },
  { path: '',   redirectTo: '/home', pathMatch: 'full' }
];

@NgModule({
  declarations: [
    AppComponent,
    SideMenuComponent,
    SideMenuItemComponent,
    HomePageComponent,
    TripsListItemComponent,
    TripsListComponent,
    CreateTripDialogComponent,
    InputDialogFieldComponent,
    DatePickerComponent
  ],
  entryComponents: [CreateTripDialogComponent],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    ClickOutsideModule,
    MaterialModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
