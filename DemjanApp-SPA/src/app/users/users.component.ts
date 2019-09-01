import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {
  users: any;

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getUsers();
  }

  getUsers() {
    this.http.get('http://localhost:5000/api/users').subscribe(
      response => {
        this.users = response;
        console.log(this.users);
      },
      error => {
        console.log(error);
      }
    );
  }

  onManage(user: any) {
    console.log(user);
  }
}
