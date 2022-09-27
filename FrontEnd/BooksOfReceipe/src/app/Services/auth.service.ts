import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../Entityes/user';
import { BaseService } from './base.service';
import * as jwt from 'jsonwebtoken';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private baseService: BaseService) { }

  authorize(user: User){
    return this.baseService.sendPost('/api/auth/login', user);
  }

  createUser(user: User) {
    return this.baseService.sendPost('/api/user/add', user);
  }
}
