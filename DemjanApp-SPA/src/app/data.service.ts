import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class DataService {
  constructor(private http: HttpClient) {}

  getPermissions() {

    return this.http.get('http://localhost:5000/api/permissions');
  }

  getUsers() {
    return this.http.get('http://localhost:5000/api/users');
  }
}
