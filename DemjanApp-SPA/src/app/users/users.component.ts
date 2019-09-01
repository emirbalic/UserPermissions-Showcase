import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DataService } from '../data.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {
  users: any;
  permissionList = false;

  constructor(
    private http: HttpClient,
    private data: DataService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.getUsers();
  }

  getUsers() {
    this.data.getUsers().subscribe(
      response => {
        this.users = response;
        console.log(this.users);
      },
      error => {
        console.log(error);
      }
    );
  }

  //,
  onManage(user: any) {
    this.router.navigate(['users',  { id: user.id }] , { relativeTo: this.route });
    console.log(user);
  }

  onShowPermissions() {
    if (!this.permissionList) {
      this.permissionList = true;
    } else {
      this.permissionList = false;
    }
  }
}
