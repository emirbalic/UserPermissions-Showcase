import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DataService } from '../data.service';

@Component({
  selector: 'app-permissions',
  templateUrl: './permissions.component.html',
  styleUrls: ['./permissions.component.css']
})
export class PermissionsComponent implements OnInit {
  permissions: any;
  constructor(
    private http: HttpClient,
    private data: DataService
    ) {}

  ngOnInit() {
    this.getPermissions();
  }

  getPermissions() {
    this.data.getPermissions().subscribe(
      response => {
        this.permissions = response;
        console.log(this.permissions);
      },
      error => {
        console.log(error);
      }
    );
  }
}
