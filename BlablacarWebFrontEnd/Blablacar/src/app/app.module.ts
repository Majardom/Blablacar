import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule, APP_INITIALIZER } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { SideMenuComponent } from './MainNavigation/side-menu/side-menu.component';
import { SideMenuItemComponent } from './MainNavigation/side-menu-item/side-menu-item.component';
import { HomePageComponent } from './Pages/Home/home-page/home-page.component';
import { ClickOutsideModule } from 'ng-click-outside';
import { TripsListComponent } from './Pages/Trips/trips-list/trips-list.component';
import { TripsListItemComponent } from './Pages/Trips/trips-list-item/trips-list-item.component';

import { MaterialModule } from './Modules/material-module';

import { CreateTripDialogComponent } from './Dialogs/create-trip-dialog/create-trip-dialog.component';
import { InputDialogFieldComponent } from './Controls/input-dialog-field/input-dialog-field.component';
import { DatePickerComponent } from './Controls/date-picker/date-picker.component';
import { ListOfValuesComponent } from './Controls/list-of-values/list-of-values.component';
import { OrderDialogComponent } from './Dialogs/order-dialog/order-dialog.component';

import { HttpClientModule } from '@angular/common/http';
import { AppConfigService } from 'src/services/app-config/app-config.service';

import { FormsModule } from '@angular/forms';

const appRoutes: Routes = [
  { path: 'trips', component: TripsListComponent },
  { path: 'home', component: HomePageComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' }
];

export function initializeApp(appConfig: AppConfigService) {
  return () => appConfig.load();
}

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
    DatePickerComponent,
    ListOfValuesComponent,
    OrderDialogComponent
  ],
  providers: [
    AppConfigService,
    {
      provide: APP_INITIALIZER,
      useFactory: initializeApp,
      deps: [AppConfigService], multi: true
    }
  ],
  entryComponents: [CreateTripDialogComponent, OrderDialogComponent],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    ClickOutsideModule,
    MaterialModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
