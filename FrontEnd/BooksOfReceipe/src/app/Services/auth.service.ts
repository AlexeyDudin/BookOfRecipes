import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../Entityes/user';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient) { }

  authorize(){

  }

  createUser(user: User) {
    return this.http.post('http://localhost:5119/api/user/add', user, {withCredentials:true});
  }
}
