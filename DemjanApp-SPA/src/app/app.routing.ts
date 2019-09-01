import { Routes, RouterModule } from '@angular/router';

import { PermissionsComponent } from './permissions/permissions.component';
import { UsersComponent } from './users/users.component';
import { ManagePermissionsComponent } from './users/manage-permissions/manage-permissions.component';
import { NgModule } from '@angular/core';

const appRoutes: Routes = [
  // {
  //   path: 'permissions',
  //   component: PermissionsComponent
  // },
  {
    path: 'users',
    component: UsersComponent,
    children: [
      {
        path: ':id',
        component: ManagePermissionsComponent
      }
    ]
  },
];

@NgModule({
  imports: [
    RouterModule.forRoot(appRoutes)
  ],
  exports: [RouterModule]
})

export class AppRouting{}
