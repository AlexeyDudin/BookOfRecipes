import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../Entityes/user';
import { BaseService } from './base.service';
import * as jwt from 'jsonwebtoken';
// import * as moment from "moment";

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private baseService: BaseService) { }


  // private saveAuthToLocalStorage(authResult) {
  //   const expiresAt = moment().add(authResult.expiresIn,'second');
    
  //   localStorage.setItem('id_token', authResult.idToken);
  //   localStorage.setItem("expires_at", JSON.stringify(expiresAt.valueOf()) );
  // }

  authorize(user: User){
    return this.baseService.sendPost('/api/auth/login', user);
  }

  createUser(user: User) {
    return this.baseService.sendPost('/api/user/add', user);
  }
}
