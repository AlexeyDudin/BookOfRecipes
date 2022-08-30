import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../Entityes/user';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private baseService: BaseService) { }

  authorize(){

  }

  createUser(user: User) {
    return this.baseService.sendPost('/api/user/add', user);
  }
}
