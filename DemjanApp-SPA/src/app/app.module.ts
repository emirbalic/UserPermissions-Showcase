import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { PermissionsComponent } from './permissions/permissions.component';
import { UsersComponent } from './users/users.component';
import { DataService } from './data.service';
import { AppRouting } from './app.routing';
import { ManagePermissionsComponent } from './users/manage-permissions/manage-permissions.component';

@NgModule({
   declarations: [
      AppComponent,
      PermissionsComponent,
      UsersComponent,
      ManagePermissionsComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      AppRouting
   ],
   providers: [DataService],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
