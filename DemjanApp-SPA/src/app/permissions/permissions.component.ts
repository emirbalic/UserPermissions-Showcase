import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-permissions',
  templateUrl: './permissions.component.html',
  styleUrls: ['./permissions.component.css']
})
export class PermissionsComponent implements OnInit {
  permissions: any;
  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getPermissions();
  }

  getPermissions() {
    this.http.get('http://localhost:5000/api/permissions').subscribe(
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
